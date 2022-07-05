using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Jeu
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        List<Champions> lesChampions = new List<Champions>();
        Champions championRandom;
        Random Generateur = new Random();
        List<Champions> passé = new List<Champions>();
        int nbPoints = 0, numChamp = 0, nbEssai = 5;
        

        public MainWindow()
        {
            this.InitializeComponent();
            lesChampions = ChargeChampions();
            this.Answer.Visibility = Visibility.Hidden;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nbEssai = 5;
            this.bouttonLol.Content = "Lancer";
            this.Answer.Visibility = Visibility.Hidden;

            var bc = new BrushConverter();
            this.NbPoints.Background = (Brush)bc.ConvertFrom("#FFF17B67");


            Display();

            this.BoxNom.FontStyle = FontStyles.Italic;
            this.BoxNom.Text = $"{lesChampions[Generateur.Next(lesChampions.Count)].Nom.ToLower()} ?";

            this.BoxNom.Visibility = Visibility.Visible;
            this.LabelFaire.Visibility = Visibility.Visible;
            this.bouttonVerif.Visibility = Visibility.Visible;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BouttonVerif_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();

            if (championRandom.Nom.ToUpper() == this.BoxNom.Text.ToUpper())
            {
                this.NbPoints.Background = Brushes.Green;
                this.bouttonVerif.Visibility = Visibility.Hidden;
                this.bouttonLol.Content = "Réssayer avec un autre";
                this.Answer.Foreground = System.Windows.Media.Brushes.Green;
                if(championRandom.Nom == "QIYANA")
                {
                    this.Answer.Content = $"Bien joué, c'est bien {championRandom.Nom} le meilleur champion du jeu!";
                }
                else
                    this.Answer.Content = $"Bien joué, c'est bien {championRandom.Nom} !";

                nbPoints += 3;
                this.Answer.Visibility = Visibility.Visible;
            }
            else
            {
                nbEssai--;
                this.NbPoints.Background = Brushes.Red;
                this.Answer.Foreground = System.Windows.Media.Brushes.Red;
                this.Answer.Content = $"Aïe, c'est pas {this.BoxNom.Text.ToUpper()} \nplus que {nbEssai} essais !";
                this.Answer.Visibility = Visibility.Visible;
                nbPoints--;
            }

            if (nbEssai == 0)
            {
                this.bouttonVerif.Visibility = Visibility.Hidden;
                this.Answer.Content = $"Nuuuul, c'était {championRandom.Nom}";
                this.bouttonLol.Content = "Réssayer avec un autre";
            }


            this.NbPoints.Content = $"Points : {nbPoints}";

            passé.Add(championRandom);

        }

        public static List<Champions> ChargeChampions()
        {
            List<Champions> lesStocks = null;
            try
            {
                String contenuFichier = File.ReadAllText("lolv2.json");
                lesStocks = JsonConvert.DeserializeObject<List<Champions>>(contenuFichier);
            }
            catch (Exception e) { throw e; }
            return lesStocks;
        }

        private void BoxNom_GotFocus(object sender, RoutedEventArgs e)
        {
            this.BoxNom.Text = String.Empty;
        }

        private void Display()
        {

            if (passé.Count == lesChampions.Count)
            {
                this.bouttonVerif.Visibility = Visibility.Hidden;
                this.bouttonLol.Visibility = Visibility.Hidden;
                this.Answer.Content = "Vous avez fais tous les champions !";
            }

            do
            {
                championRandom = lesChampions[Generateur.Next(lesChampions.Count)];
            } while (passé.Contains(championRandom) && passé.Count != lesChampions.Count);

            Console.WriteLine(championRandom.Nom);

            var converter = new ImageSourceConverter();

            this.ImmageIntero.Source = (ImageSource)converter.ConvertFromString(championRandom.ImagePath);

            numChamp++;

            this.NumQuestion.Content = $"N°{numChamp}/{lesChampions.Count}";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}