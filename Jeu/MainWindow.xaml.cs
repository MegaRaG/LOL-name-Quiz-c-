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
        public static List<Chapions> lesChampions = ChargeChampions();
        public static Random Generateur = new Random();
        public static BrushConverter bc = new BrushConverter();
        public static List<int> passé = new List<int>();
        public string reponseNom = "";
        public MainWindow()
        {
            //List<Chapions> lesChampions = ChargeChampions();
            this.InitializeComponent();
        }
       /* public static List<Chapions> ChargeChampions()
        {
            List<Chapions> lesStocks = null;
            try
            {
                String contenuFichier = File.ReadAllText("Championsse.json");
                lesStocks = JsonConvert.DeserializeObject<List<Chapions>>(contenuFichier);
            }
            catch (Exception e) { throw e; }
            return lesStocks;
        }
        public static void AfficheListe(List<Chapions> liste)
        {
            foreach (Chapions unChampion in liste)
                Console.WriteLine(unChampion);
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string numDuChamp = "";
            this.Numieme();
            BoxNom.Text = "Nom";
            this.Immage1.Visibility = Visibility.Hidden;
            this.Immage2.Visibility = Visibility.Hidden;
            this.Immage3.Visibility = Visibility.Hidden;
            this.Immage4.Visibility = Visibility.Hidden;
            this.Immage5.Visibility = Visibility.Hidden;
            this.Immage6.Visibility = Visibility.Hidden;
            this.Immage7.Visibility = Visibility.Hidden;
            this.Immage8.Visibility = Visibility.Hidden;
            this.Immage9.Visibility = Visibility.Hidden;
            this.Immage10.Visibility = Visibility.Hidden;
            this.Immage11.Visibility = Visibility.Hidden;
            this.Immage12.Visibility = Visibility.Hidden;
            this.Immage13.Visibility = Visibility.Hidden;
            this.Immage14.Visibility = Visibility.Hidden;
            this.Immage15.Visibility = Visibility.Hidden;
            this.Immage16.Visibility = Visibility.Hidden;
            this.Immage17.Visibility = Visibility.Hidden;
            this.Immage18.Visibility = Visibility.Hidden;
            this.Immage19.Visibility = Visibility.Hidden;
            this.Immage20.Visibility = Visibility.Hidden;
            this.Immage21.Visibility = Visibility.Hidden;
            this.Immage22.Visibility = Visibility.Hidden;
            this.Immage23.Visibility = Visibility.Hidden;
            this.Immage24.Visibility = Visibility.Hidden;
            this.Immage25.Visibility = Visibility.Hidden;
            this.Immage26.Visibility = Visibility.Hidden;
            this.Immage27.Visibility = Visibility.Hidden;
            this.Immage28.Visibility = Visibility.Hidden;
            this.Immage29.Visibility = Visibility.Hidden;
            this.Immage30.Visibility = Visibility.Hidden;
            this.Immage31.Visibility = Visibility.Hidden;
            this.Immage32.Visibility = Visibility.Hidden;
            this.Immage33.Visibility = Visibility.Hidden;
            this.Immage34.Visibility = Visibility.Hidden;
            this.Immage35.Visibility = Visibility.Hidden;
            this.Immage36.Visibility = Visibility.Hidden;
            this.Immage37.Visibility = Visibility.Hidden;
            this.Immage38.Visibility = Visibility.Hidden;
            this.Immage39.Visibility = Visibility.Hidden;
            this.Immage40.Visibility = Visibility.Hidden;
            this.Immage41.Visibility = Visibility.Hidden;
            this.Immage42.Visibility = Visibility.Hidden;
            this.Immage43.Visibility = Visibility.Hidden;
            this.Immage44.Visibility = Visibility.Hidden;
            this.Immage45.Visibility = Visibility.Hidden;
            this.Immage46.Visibility = Visibility.Hidden;
            this.Immage47.Visibility = Visibility.Hidden;
            this.Immage48.Visibility = Visibility.Hidden;
            this.Immage49.Visibility = Visibility.Hidden;
            this.Immage50.Visibility = Visibility.Hidden;
            this.Immage51.Visibility = Visibility.Hidden;
            this.Immage52.Visibility = Visibility.Hidden;
            this.Immage53.Visibility = Visibility.Hidden;
            this.Immage54.Visibility = Visibility.Hidden;
            this.Immage55.Visibility = Visibility.Hidden;
            this.Immage56.Visibility = Visibility.Hidden;
            this.Immage57.Visibility = Visibility.Hidden;
            this.Immage58.Visibility = Visibility.Hidden;
            this.Immage59.Visibility = Visibility.Hidden;
            this.Immage60.Visibility = Visibility.Hidden;
            this.Immage61.Visibility = Visibility.Hidden;
            this.Immage62.Visibility = Visibility.Hidden;
            this.Immage63.Visibility = Visibility.Hidden;
            this.Immage64.Visibility = Visibility.Hidden;
            this.Immage65.Visibility = Visibility.Hidden;
            this.Immage66.Visibility = Visibility.Hidden;
            this.Immage67.Visibility = Visibility.Hidden;
            this.Immage68.Visibility = Visibility.Hidden;
            this.Immage69.Visibility = Visibility.Hidden;
            this.Immage70.Visibility = Visibility.Hidden;
            this.Immage71.Visibility = Visibility.Hidden;
            this.Immage72.Visibility = Visibility.Hidden;
            this.Immage73.Visibility = Visibility.Hidden;
            this.Immage74.Visibility = Visibility.Hidden;
            this.Immage75.Visibility = Visibility.Hidden;
            this.Immage76.Visibility = Visibility.Hidden;
            this.Immage77.Visibility = Visibility.Hidden;
            this.Immage78.Visibility = Visibility.Hidden;
            this.Immage79.Visibility = Visibility.Hidden;
            this.Immage80.Visibility = Visibility.Hidden;
            this.Immage81.Visibility = Visibility.Hidden;
            this.Immage82.Visibility = Visibility.Hidden;
            this.Immage83.Visibility = Visibility.Hidden;
            this.Immage84.Visibility = Visibility.Hidden;
            this.Immage85.Visibility = Visibility.Hidden;
            this.Immage86.Visibility = Visibility.Hidden;
            this.Immage87.Visibility = Visibility.Hidden;
            this.Immage88.Visibility = Visibility.Hidden;
            this.Immage89.Visibility = Visibility.Hidden;
            this.Immage90.Visibility = Visibility.Hidden;
            this.Immage91.Visibility = Visibility.Hidden;
            this.Immage92.Visibility = Visibility.Hidden;
            this.Immage93.Visibility = Visibility.Hidden;
            this.Immage94.Visibility = Visibility.Hidden;
            this.Immage95.Visibility = Visibility.Hidden;
            this.Immage96.Visibility = Visibility.Hidden;
            this.Immage97.Visibility = Visibility.Hidden;
            this.Immage98.Visibility = Visibility.Hidden;
            this.Immage99.Visibility = Visibility.Hidden;
            this.Immage100.Visibility = Visibility.Hidden;
            this.Immage101.Visibility = Visibility.Hidden;
            this.Immage102.Visibility = Visibility.Hidden;
            this.Immage103.Visibility = Visibility.Hidden;
            this.Immage104.Visibility = Visibility.Hidden;
            this.Immage105.Visibility = Visibility.Hidden;
            this.Immage106.Visibility = Visibility.Hidden;
            this.Immage107.Visibility = Visibility.Hidden;
            this.Immage108.Visibility = Visibility.Hidden;
            this.Immage109.Visibility = Visibility.Hidden;
            this.Immage110.Visibility = Visibility.Hidden;
            this.Immage111.Visibility = Visibility.Hidden;
            this.Immage112.Visibility = Visibility.Hidden;
            this.Immage113.Visibility = Visibility.Hidden;
            this.Immage114.Visibility = Visibility.Hidden;
            this.Immage115.Visibility = Visibility.Hidden;
            this.Immage116.Visibility = Visibility.Hidden;
            this.Immage117.Visibility = Visibility.Hidden;
            this.Immage118.Visibility = Visibility.Hidden;
            this.Immage119.Visibility = Visibility.Hidden;
            this.Immage120.Visibility = Visibility.Hidden;
            this.Immage121.Visibility = Visibility.Hidden;
            this.Immage122.Visibility = Visibility.Hidden;
            this.Immage123.Visibility = Visibility.Hidden;
            this.Immage124.Visibility = Visibility.Hidden;
            this.Immage125.Visibility = Visibility.Hidden;
            this.Immage126.Visibility = Visibility.Hidden;
            this.Immage127.Visibility = Visibility.Hidden;
            this.Immage128.Visibility = Visibility.Hidden;
            this.Immage129.Visibility = Visibility.Hidden;
            this.Immage130.Visibility = Visibility.Hidden;
            this.Immage131.Visibility = Visibility.Hidden;
            this.Immage132.Visibility = Visibility.Hidden;
            this.Immage133.Visibility = Visibility.Hidden;
            this.Immage134.Visibility = Visibility.Hidden;
            this.Immage135.Visibility = Visibility.Hidden;
            this.Immage136.Visibility = Visibility.Hidden;
            this.Immage137.Visibility = Visibility.Hidden;
            this.Immage138.Visibility = Visibility.Hidden;
            this.Immage139.Visibility = Visibility.Hidden;
            this.Immage140.Visibility = Visibility.Hidden;
            this.Immage141.Visibility = Visibility.Hidden;
            this.Immage142.Visibility = Visibility.Hidden;
            this.Immage143.Visibility = Visibility.Hidden;
            this.Immage144.Visibility = Visibility.Hidden;
            this.Immage145.Visibility = Visibility.Hidden;
            this.Immage146.Visibility = Visibility.Hidden;
            this.Immage147.Visibility = Visibility.Hidden;
            this.Immage148.Visibility = Visibility.Hidden;
            this.Immage149.Visibility = Visibility.Hidden;
            this.Immage150.Visibility = Visibility.Hidden;
            this.Immage151.Visibility = Visibility.Hidden;
            this.Immage152.Visibility = Visibility.Hidden;
            this.Immage153.Visibility = Visibility.Hidden;
            this.Immage154.Visibility = Visibility.Hidden;
            this.Immage155.Visibility = Visibility.Hidden;
            this.Immage156.Visibility = Visibility.Hidden;
            this.Immage157.Visibility = Visibility.Hidden;
            this.Immage158.Visibility = Visibility.Hidden;
            this.Immage159.Visibility = Visibility.Hidden;



            int numeroChampionRandom = Generateur.Next(159);

            if(passé.Contains(numeroChampionRandom))
            {
                while(passé.Contains(numeroChampionRandom))
                {
                    numeroChampionRandom = Generateur.Next(159);
                }
            }
            passé.Add(numeroChampionRandom);

            foreach (Chapions unChampion in lesChampions)
            {
                if (unChampion.NumeroChampion == numeroChampionRandom)
                    numDuChamp = unChampion.NumeroChampion.ToString();
            }

            switch(numDuChamp)
            {
                case "1":
                    {
                        Immage1.Visibility = Visibility.Visible;
                    }
                    break;
                case "2":
                    {
                        Immage2.Visibility = Visibility.Visible;
                    }
                    break;
                case "3":
                    {
                        Immage3.Visibility = Visibility.Visible;
                    }
                    break;
                case "4":
                    {
                        Immage4.Visibility = Visibility.Visible;
                    }
                    break;
                case "5":
                    {
                        Immage5.Visibility = Visibility.Visible;
                    }
                    break;
                case "6":
                    {
                        Immage6.Visibility = Visibility.Visible;
                    }
                    break;
                case "7":
                    {
                        Immage7.Visibility = Visibility.Visible;
                    }
                    break;
                case "8":
                    {
                        Immage8.Visibility = Visibility.Visible;
                    }
                    break;
                case "9":
                    {
                        Immage9.Visibility = Visibility.Visible;
                    }
                    break;
                case "10":
                    {
                        Immage10.Visibility = Visibility.Visible;
                    }
                    break;
                case "11":
                    {
                        Immage11.Visibility = Visibility.Visible;
                    }
                    break;
                case "12":
                    {
                        Immage12.Visibility = Visibility.Visible;
                    }
                    break;
                case "13":
                    {
                        Immage13.Visibility = Visibility.Visible;
                    }
                    break;
                case "14":
                    {
                        Immage14.Visibility = Visibility.Visible;
                    }
                    break;
                case "15":
                    {
                        Immage15.Visibility = Visibility.Visible;
                    }
                    break;
                case "16":
                    {
                        Immage16.Visibility = Visibility.Visible;
                    }
                    break;
                case "17":
                    {
                        Immage17.Visibility = Visibility.Visible;
                    }
                    break;
                case "18":
                    {
                        Immage18.Visibility = Visibility.Visible;
                    }
                    break;
                case "19":
                    {
                        Immage19.Visibility = Visibility.Visible;
                    }
                    break;
                case "20":
                    {
                        Immage20.Visibility = Visibility.Visible;
                    }
                    break;
                case "21":
                    {
                        Immage21.Visibility = Visibility.Visible;
                    }
                    break;
                case "22":
                    {
                        Immage22.Visibility = Visibility.Visible;
                    }
                    break;
                case "23":
                    {
                        Immage23.Visibility = Visibility.Visible;
                    }
                    break;
                case "24":
                    {
                        Immage24.Visibility = Visibility.Visible;
                    }
                    break;
                case "25":
                    {
                        Immage25.Visibility = Visibility.Visible;
                    }
                    break;
                case "26":
                    {
                        Immage26.Visibility = Visibility.Visible;
                    }
                    break;
                case "27":
                    {
                        Immage27.Visibility = Visibility.Visible;
                    }
                    break;
                case "28":
                    {
                        Immage28.Visibility = Visibility.Visible;
                    }
                    break;
                case "29":
                    {
                        Immage29.Visibility = Visibility.Visible;
                    }
                    break;
                case "30":
                    {
                        Immage30.Visibility = Visibility.Visible;
                    }
                    break;
                case "31":
                    {
                        Immage31.Visibility = Visibility.Visible;
                    }
                    break;
                case "32":
                    {
                        Immage32.Visibility = Visibility.Visible;
                    }
                    break;
                case "33":
                    {
                        Immage33.Visibility = Visibility.Visible;
                    }
                    break;
                case "34":
                    {
                        Immage34.Visibility = Visibility.Visible;
                    }
                    break;
                case "35":
                    {
                        Immage35.Visibility = Visibility.Visible;
                    }
                    break;
                case "36":
                    {
                        Immage36.Visibility = Visibility.Visible;
                    }
                    break;
                case "37":
                    {
                        Immage37.Visibility = Visibility.Visible;
                    }
                    break;
                case "38":
                    {
                        Immage38.Visibility = Visibility.Visible;
                    }
                    break;
                case "39":
                    {
                        Immage39.Visibility = Visibility.Visible;
                    }
                    break;
                case "40":
                    {
                        Immage40.Visibility = Visibility.Visible;
                    }
                    break;
                case "41":
                    {
                        Immage41.Visibility = Visibility.Visible;
                    }
                    break;
                case "42":
                    {
                        Immage42.Visibility = Visibility.Visible;
                    }
                    break;
                case "43":
                    {
                        Immage43.Visibility = Visibility.Visible;
                    }
                    break;
                case "44":
                    {
                        Immage44.Visibility = Visibility.Visible;
                    }
                    break;
                case "45":
                    {
                        Immage45.Visibility = Visibility.Visible;
                    }
                    break;
                case "46":
                    {
                        Immage46.Visibility = Visibility.Visible;
                    }
                    break;
                case "47":
                    {
                        Immage47.Visibility = Visibility.Visible;
                    }
                    break;
                case "48":
                    {
                        Immage48.Visibility = Visibility.Visible;
                    }
                    break;
                case "49":
                    {
                        Immage49.Visibility = Visibility.Visible;
                    }
                    break;
                case "50":
                    {
                        Immage50.Visibility = Visibility.Visible;
                    }
                    break;
                case "51":
                    {
                        Immage51.Visibility = Visibility.Visible;
                    }
                    break;
                case "52":
                    {
                        Immage52.Visibility = Visibility.Visible;
                    }
                    break;
                case "53":
                    {
                        Immage53.Visibility = Visibility.Visible;
                    }
                    break;
                case "54":
                    {
                        Immage54.Visibility = Visibility.Visible;
                    }
                    break;
                case "55":
                    {
                        Immage55.Visibility = Visibility.Visible;
                    }
                    break;
                case "56":
                    {
                        Immage56.Visibility = Visibility.Visible;
                    }
                    break;
                case "57":
                    {
                        Immage57.Visibility = Visibility.Visible;
                    }
                    break;
                case "58":
                    {
                        Immage58.Visibility = Visibility.Visible;
                    }
                    break;
                case "59":
                    {
                        Immage59.Visibility = Visibility.Visible;
                    }
                    break;
                case "60":
                    {
                        Immage60.Visibility = Visibility.Visible;
                    }
                    break;
                case "61":
                    {
                        Immage61.Visibility = Visibility.Visible;
                    }
                    break;
                case "62":
                    {
                        Immage62.Visibility = Visibility.Visible;
                    }
                    break;
                case "63":
                    {
                        Immage63.Visibility = Visibility.Visible;
                    }
                    break;
                case "64":
                    {
                        Immage64.Visibility = Visibility.Visible;
                    }
                    break;
                case "65":
                    {
                        Immage65.Visibility = Visibility.Visible;
                    }
                    break;
                case "66":
                    {
                        Immage66.Visibility = Visibility.Visible;
                    }
                    break;
                case "67":
                    {
                        Immage67.Visibility = Visibility.Visible;
                    }
                    break;
                case "68":
                    {
                        Immage68.Visibility = Visibility.Visible;
                    }
                    break;
                case "69":
                    {
                        Immage69.Visibility = Visibility.Visible;
                    }
                    break;
                case "70":
                    {
                        Immage70.Visibility = Visibility.Visible;
                    }
                    break;
                case "71":
                    {
                        Immage71.Visibility = Visibility.Visible;
                    }
                    break;
                case "72":
                    {
                        Immage72.Visibility = Visibility.Visible;
                    }
                    break;
                case "73":
                    {
                        Immage73.Visibility = Visibility.Visible;
                    }
                    break;
                case "74":
                    {
                        Immage74.Visibility = Visibility.Visible;
                    }
                    break;
                case "75":
                    {
                        Immage75.Visibility = Visibility.Visible;
                    }
                    break;
                case "76":
                    {
                        Immage76.Visibility = Visibility.Visible;
                    }
                    break;
                case "77":
                    {
                        Immage77.Visibility = Visibility.Visible;
                    }
                    break;
                case "78":
                    {
                        Immage78.Visibility = Visibility.Visible;
                    }
                    break;
                case "79":
                    {
                        Immage79.Visibility = Visibility.Visible;
                    }
                    break;
                case "80":
                    {
                        Immage80.Visibility = Visibility.Visible;
                    }
                    break;
                case "81":
                    {
                        Immage81.Visibility = Visibility.Visible;
                    }
                    break;
                case "82":
                    {
                        Immage82.Visibility = Visibility.Visible;
                    }
                    break;
                case "83":
                    {
                        Immage83.Visibility = Visibility.Visible;
                    }
                    break;
                case "84":
                    {
                        Immage84.Visibility = Visibility.Visible;
                    }
                    break;
                case "85":
                    {
                        Immage85.Visibility = Visibility.Visible;
                    }
                    break;
                case "86":
                    {
                        Immage86.Visibility = Visibility.Visible;
                    }
                    break;
                case "87":
                    {
                        Immage87.Visibility = Visibility.Visible;
                    }
                    break;
                case "88":
                    {
                        Immage88.Visibility = Visibility.Visible;
                    }
                    break;
                case "89":
                    {
                        Immage89.Visibility = Visibility.Visible;
                    }
                    break;
                case "90":
                    {
                        Immage90.Visibility = Visibility.Visible;
                    }
                    break;
                case "91":
                    {
                        Immage91.Visibility = Visibility.Visible;
                    }
                    break;
                case "92":
                    {
                        Immage92.Visibility = Visibility.Visible;
                    }
                    break;
                case "93":
                    {
                        Immage93.Visibility = Visibility.Visible;
                    }
                    break;
                case "94":
                    {
                        Immage94.Visibility = Visibility.Visible;
                    }
                    break;
                case "95":
                    {
                        Immage95.Visibility = Visibility.Visible;
                    }
                    break;
                case "96":
                    {
                        Immage96.Visibility = Visibility.Visible;
                    }
                    break;
                case "97":
                    {
                        Immage97.Visibility = Visibility.Visible;
                    }
                    break;
                case "98":
                    {
                        Immage98.Visibility = Visibility.Visible;
                    }
                    break;
                case "99":
                    {
                        Immage99.Visibility = Visibility.Visible;
                    }
                    break;
                case "100":
                    {
                        Immage100.Visibility = Visibility.Visible;
                    }
                    break;
                case "101":
                    {
                        Immage101.Visibility = Visibility.Visible;
                    }
                    break;
                case "102":
                    {
                        Immage102.Visibility = Visibility.Visible;
                    }
                    break;
                case "103":
                    {
                        Immage103.Visibility = Visibility.Visible;
                    }
                    break;
                case "104":
                    {
                        Immage104.Visibility = Visibility.Visible;
                    }
                    break;
                case "105":
                    {
                        Immage105.Visibility = Visibility.Visible;
                    }
                    break;
                case "106":
                    {
                        Immage106.Visibility = Visibility.Visible;
                    }
                    break;
                case "107":
                    {
                        Immage107.Visibility = Visibility.Visible;
                    }
                    break;
                case "108":
                    {
                        Immage108.Visibility = Visibility.Visible;
                    }
                    break;
                case "109":
                    {
                        Immage109.Visibility = Visibility.Visible;
                    }
                    break;
                case "110":
                    {
                        Immage110.Visibility = Visibility.Visible;
                    }
                    break;
                case "111":
                    {
                        Immage111.Visibility = Visibility.Visible;
                    }
                    break;
                case "112":
                    {
                        Immage112.Visibility = Visibility.Visible;
                    }
                    break;
                case "113":
                    {
                        Immage113.Visibility = Visibility.Visible;
                    }
                    break;
                case "114":
                    {
                        Immage114.Visibility = Visibility.Visible;
                    }
                    break;
                case "115":
                    {
                        Immage115.Visibility = Visibility.Visible;
                    }
                    break;
                case "116":
                    {
                        Immage116.Visibility = Visibility.Visible;
                    }
                    break;
                case "117":
                    {
                        Immage117.Visibility = Visibility.Visible;
                    }
                    break;
                case "118":
                    {
                        Immage118.Visibility = Visibility.Visible;
                    }
                    break;
                case "119":
                    {
                        Immage119.Visibility = Visibility.Visible;
                    }
                    break;
                case "120":
                    {
                        Immage120.Visibility = Visibility.Visible;
                    }
                    break;
                case "121":
                    {
                        Immage121.Visibility = Visibility.Visible;
                    }
                    break;
                case "122":
                    {
                        Immage122.Visibility = Visibility.Visible;
                    }
                    break;
                case "123":
                    {
                        Immage123.Visibility = Visibility.Visible;
                    }
                    break;
                case "124":
                    {
                        Immage124.Visibility = Visibility.Visible;
                    }
                    break;
                case "125":
                    {
                        Immage125.Visibility = Visibility.Visible;
                    }
                    break;
                case "126":
                    {
                        Immage126.Visibility = Visibility.Visible;
                    }
                    break;
                case "127":
                    {
                        Immage127.Visibility = Visibility.Visible;
                    }
                    break;
                case "128":
                    {
                        Immage128.Visibility = Visibility.Visible;
                    }
                    break;
                case "129":
                    {
                        Immage129.Visibility = Visibility.Visible;
                    }
                    break;
                case "130":
                    {
                        Immage130.Visibility = Visibility.Visible;
                    }
                    break;
                case "131":
                    {
                        Immage131.Visibility = Visibility.Visible;
                    }
                    break;
                case "132":
                    {
                        Immage132.Visibility = Visibility.Visible;
                    }
                    break;
                case "133":
                    {
                        Immage133.Visibility = Visibility.Visible;
                    }
                    break;
                case "134":
                    {
                        Immage134.Visibility = Visibility.Visible;
                    }
                    break;
                case "135":
                    {
                        Immage135.Visibility = Visibility.Visible;
                    }
                    break;
                case "136":
                    {
                        Immage136.Visibility = Visibility.Visible;
                    }
                    break;
                case "137":
                    {
                        Immage137.Visibility = Visibility.Visible;
                    }
                    break;
                case "138":
                    {
                        Immage138.Visibility = Visibility.Visible;
                    }
                    break;
                case "139":
                    {
                        Immage139.Visibility = Visibility.Visible;
                    }
                    break;
                case "140":
                    {
                        Immage140.Visibility = Visibility.Visible;
                    }
                    break;
                case "141":
                    {
                        Immage141.Visibility = Visibility.Visible;
                    }
                    break;
                case "142":
                    {
                        Immage142.Visibility = Visibility.Visible;
                    }
                    break;
                case "143":
                    {
                        Immage143.Visibility = Visibility.Visible;
                    }
                    break;
                case "144":
                    {
                        Immage144.Visibility = Visibility.Visible;
                    }
                    break;
                case "145":
                    {
                        Immage145.Visibility = Visibility.Visible;
                    }
                    break;
                case "146":
                    {
                        Immage146.Visibility = Visibility.Visible;
                    }
                    break;
                case "147":
                    {
                        Immage147.Visibility = Visibility.Visible;
                    }
                    break;
                case "148":
                    {
                        Immage148.Visibility = Visibility.Visible;
                    }
                    break;
                case "149":
                    {
                        Immage149.Visibility = Visibility.Visible;
                    }
                    break;
                case "150":
                    {
                        Immage150.Visibility = Visibility.Visible;
                    }
                    break;
                case "151":
                    {
                        Immage151.Visibility = Visibility.Visible;
                    }
                    break;
                case "152":
                    {
                        Immage152.Visibility = Visibility.Visible;
                    }
                    break;
                case "153":
                    {
                        Immage153.Visibility = Visibility.Visible;
                    }
                    break;
                case "154":
                    {
                        Immage154.Visibility = Visibility.Visible;
                    }
                    break;
                case "155":
                    {
                        Immage155.Visibility = Visibility.Visible;
                    }
                    break;
                case "156":
                    {
                        Immage156.Visibility = Visibility.Visible;
                    }
                    break;
                case "157":
                    {
                        Immage157.Visibility = Visibility.Visible;
                    }
                    break;
                case "158":
                    {
                        Immage158.Visibility = Visibility.Visible;
                    }
                    break;
                case "159":
                    {
                        Immage159.Visibility = Visibility.Visible;
                    }
                    break;

            }


            this.BoxNom.Visibility = Visibility.Visible;
            this.LabelFaire.Visibility = Visibility.Visible;
            this.bouttonVerif.Visibility = Visibility.Visible;
           
        }

        private void Numieme()
        {
            string str2 = Convert.ToString(this.LeNumIeme.Content);
            int leNeme = int.Parse(str2) + 1;
            if (leNeme == 159)
            {
                int sleepfor = 2000;
                Thread.Sleep(sleepfor);
                Application.Current.Shutdown();
            }
            string leNemeEnString = leNeme.ToString();
            object leNemeEnObject = leNemeEnString;
            LeNumIeme.Content = leNemeEnObject;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BouttonVerif_Click(object sender, RoutedEventArgs e)
        {
            string str1 = Convert.ToString(this.LaPoints.Content);
            int points = int.Parse(str1);
            this.Numieme();
            string nbPage = "152";
            _ = this.LaPoints.Content;

            if (this.Immage1.Visibility == Visibility.Visible) { nbPage = "1"; }
            else if (this.Immage2.Visibility == Visibility.Visible) { nbPage = "2"; }
            else if (this.Immage3.Visibility == Visibility.Visible) { nbPage = "3"; }
            else if (this.Immage4.Visibility == Visibility.Visible) { nbPage = "4"; }
            else if (this.Immage5.Visibility == Visibility.Visible) { nbPage = "5"; }
            else if (this.Immage6.Visibility == Visibility.Visible) { nbPage = "6"; }
            else if (this.Immage7.Visibility == Visibility.Visible) { nbPage = "7"; }
            else if (this.Immage8.Visibility == Visibility.Visible) { nbPage = "8"; }
            else if (this.Immage9.Visibility == Visibility.Visible) { nbPage = "9"; }
            else if (this.Immage10.Visibility == Visibility.Visible) { nbPage = "10"; }
            else if (this.Immage11.Visibility == Visibility.Visible) { nbPage = "11"; }
            else if (this.Immage12.Visibility == Visibility.Visible) { nbPage = "12"; }
            else if (this.Immage13.Visibility == Visibility.Visible) { nbPage = "13"; }
            else if (this.Immage14.Visibility == Visibility.Visible) { nbPage = "14"; }
            else if (this.Immage15.Visibility == Visibility.Visible) { nbPage = "15"; }
            else if (this.Immage16.Visibility == Visibility.Visible) { nbPage = "16"; }
            else if (this.Immage17.Visibility == Visibility.Visible) { nbPage = "17"; }
            else if (this.Immage18.Visibility == Visibility.Visible) { nbPage = "18"; }
            else if (this.Immage19.Visibility == Visibility.Visible) { nbPage = "19"; }
            else if (this.Immage20.Visibility == Visibility.Visible) { nbPage = "20"; }
            else if (this.Immage21.Visibility == Visibility.Visible) { nbPage = "21"; }
            else if (this.Immage22.Visibility == Visibility.Visible) { nbPage = "22"; }
            else if (this.Immage23.Visibility == Visibility.Visible) { nbPage = "23"; }
            else if (this.Immage24.Visibility == Visibility.Visible) { nbPage = "24"; }
            else if (this.Immage25.Visibility == Visibility.Visible) { nbPage = "25"; }
            else if (this.Immage26.Visibility == Visibility.Visible) { nbPage = "26"; }
            else if (this.Immage27.Visibility == Visibility.Visible) { nbPage = "27"; }
            else if (this.Immage28.Visibility == Visibility.Visible) { nbPage = "28"; }
            else if (this.Immage29.Visibility == Visibility.Visible) { nbPage = "29"; }
            else if (this.Immage30.Visibility == Visibility.Visible) { nbPage = "30"; }
            else if (this.Immage31.Visibility == Visibility.Visible) { nbPage = "31"; }
            else if (this.Immage32.Visibility == Visibility.Visible) { nbPage = "32"; }
            else if (this.Immage33.Visibility == Visibility.Visible) { nbPage = "33"; }
            else if (this.Immage34.Visibility == Visibility.Visible) { nbPage = "34"; }
            else if (this.Immage35.Visibility == Visibility.Visible) { nbPage = "35"; }
            else if (this.Immage36.Visibility == Visibility.Visible) { nbPage = "36"; }
            else if (this.Immage37.Visibility == Visibility.Visible) { nbPage = "37"; }
            else if (this.Immage38.Visibility == Visibility.Visible) { nbPage = "38"; }
            else if (this.Immage39.Visibility == Visibility.Visible) { nbPage = "39"; }
            else if (this.Immage40.Visibility == Visibility.Visible) { nbPage = "40"; }
            else if (this.Immage41.Visibility == Visibility.Visible) { nbPage = "41"; }
            else if (this.Immage42.Visibility == Visibility.Visible) { nbPage = "42"; }
            else if (this.Immage43.Visibility == Visibility.Visible) { nbPage = "43"; }
            else if (this.Immage44.Visibility == Visibility.Visible) { nbPage = "44"; }
            else if (this.Immage45.Visibility == Visibility.Visible) { nbPage = "45"; }
            else if (this.Immage46.Visibility == Visibility.Visible) { nbPage = "46"; }
            else if (this.Immage47.Visibility == Visibility.Visible) { nbPage = "47"; }
            else if (this.Immage48.Visibility == Visibility.Visible) { nbPage = "48"; }
            else if (this.Immage49.Visibility == Visibility.Visible) { nbPage = "49"; }
            else if (this.Immage50.Visibility == Visibility.Visible) { nbPage = "50"; }
            else if (this.Immage51.Visibility == Visibility.Visible) { nbPage = "51"; }
            else if (this.Immage52.Visibility == Visibility.Visible) { nbPage = "52"; }
            else if (this.Immage53.Visibility == Visibility.Visible) { nbPage = "53"; }
            else if (this.Immage54.Visibility == Visibility.Visible) { nbPage = "54"; }
            else if (this.Immage55.Visibility == Visibility.Visible) { nbPage = "55"; }
            else if (this.Immage56.Visibility == Visibility.Visible) { nbPage = "56"; }
            else if (this.Immage57.Visibility == Visibility.Visible) { nbPage = "57"; }
            else if (this.Immage58.Visibility == Visibility.Visible) { nbPage = "58"; }
            else if (this.Immage59.Visibility == Visibility.Visible) { nbPage = "59"; }
            else if (this.Immage60.Visibility == Visibility.Visible) { nbPage = "60"; }
            else if (this.Immage61.Visibility == Visibility.Visible) { nbPage = "61"; }
            else if (this.Immage62.Visibility == Visibility.Visible) { nbPage = "62"; }
            else if (this.Immage63.Visibility == Visibility.Visible) { nbPage = "63"; }
            else if (this.Immage64.Visibility == Visibility.Visible) { nbPage = "64"; }
            else if (this.Immage65.Visibility == Visibility.Visible) { nbPage = "65"; }
            else if (this.Immage66.Visibility == Visibility.Visible) { nbPage = "66"; }
            else if (this.Immage67.Visibility == Visibility.Visible) { nbPage = "67"; }
            else if (this.Immage68.Visibility == Visibility.Visible) { nbPage = "68"; }
            else if (this.Immage69.Visibility == Visibility.Visible) { nbPage = "69"; }
            else if (this.Immage70.Visibility == Visibility.Visible) { nbPage = "70"; }
            else if (this.Immage71.Visibility == Visibility.Visible) { nbPage = "71"; }
            else if (this.Immage72.Visibility == Visibility.Visible) { nbPage = "72"; }
            else if (this.Immage73.Visibility == Visibility.Visible) { nbPage = "73"; }
            else if (this.Immage74.Visibility == Visibility.Visible) { nbPage = "74"; }
            else if (this.Immage75.Visibility == Visibility.Visible) { nbPage = "75"; }
            else if (this.Immage76.Visibility == Visibility.Visible) { nbPage = "76"; }
            else if (this.Immage77.Visibility == Visibility.Visible) { nbPage = "77"; }
            else if (this.Immage78.Visibility == Visibility.Visible) { nbPage = "78"; }
            else if (this.Immage79.Visibility == Visibility.Visible) { nbPage = "79"; }
            else if (this.Immage80.Visibility == Visibility.Visible) { nbPage = "80"; }
            else if (this.Immage81.Visibility == Visibility.Visible) { nbPage = "81"; }
            else if (this.Immage82.Visibility == Visibility.Visible) { nbPage = "82"; }
            else if (this.Immage83.Visibility == Visibility.Visible) { nbPage = "83"; }
            else if (this.Immage84.Visibility == Visibility.Visible) { nbPage = "84"; }
            else if (this.Immage85.Visibility == Visibility.Visible) { nbPage = "85"; }
            else if (this.Immage86.Visibility == Visibility.Visible) { nbPage = "86"; }
            else if (this.Immage87.Visibility == Visibility.Visible) { nbPage = "87"; }
            else if (this.Immage88.Visibility == Visibility.Visible) { nbPage = "88"; }
            else if (this.Immage89.Visibility == Visibility.Visible) { nbPage = "89"; }
            else if (this.Immage90.Visibility == Visibility.Visible) { nbPage = "90"; }
            else if (this.Immage91.Visibility == Visibility.Visible) { nbPage = "91"; }
            else if (this.Immage92.Visibility == Visibility.Visible) { nbPage = "92"; }
            else if (this.Immage93.Visibility == Visibility.Visible) { nbPage = "93"; }
            else if (this.Immage94.Visibility == Visibility.Visible) { nbPage = "94"; }
            else if (this.Immage95.Visibility == Visibility.Visible) { nbPage = "95"; }
            else if (this.Immage96.Visibility == Visibility.Visible) { nbPage = "96"; }
            else if (this.Immage97.Visibility == Visibility.Visible) { nbPage = "97"; }
            else if (this.Immage98.Visibility == Visibility.Visible) { nbPage = "98"; }
            else if (this.Immage99.Visibility == Visibility.Visible) { nbPage = "99"; }
            else if (this.Immage100.Visibility == Visibility.Visible) { nbPage = "100"; }
            else if (this.Immage101.Visibility == Visibility.Visible) { nbPage = "101"; }
            else if (this.Immage102.Visibility == Visibility.Visible) { nbPage = "102"; }
            else if (this.Immage103.Visibility == Visibility.Visible) { nbPage = "103"; }
            else if (this.Immage104.Visibility == Visibility.Visible) { nbPage = "104"; }
            else if (this.Immage105.Visibility == Visibility.Visible) { nbPage = "105"; }
            else if (this.Immage106.Visibility == Visibility.Visible) { nbPage = "106"; }
            else if (this.Immage107.Visibility == Visibility.Visible) { nbPage = "107"; }
            else if (this.Immage108.Visibility == Visibility.Visible) { nbPage = "108"; }
            else if (this.Immage109.Visibility == Visibility.Visible) { nbPage = "109"; }
            else if (this.Immage110.Visibility == Visibility.Visible) { nbPage = "110"; }
            else if (this.Immage111.Visibility == Visibility.Visible) { nbPage = "111"; }
            else if (this.Immage112.Visibility == Visibility.Visible) { nbPage = "112"; }
            else if (this.Immage113.Visibility == Visibility.Visible) { nbPage = "113"; }
            else if (this.Immage114.Visibility == Visibility.Visible) { nbPage = "114"; }
            else if (this.Immage115.Visibility == Visibility.Visible) { nbPage = "115"; }
            else if (this.Immage116.Visibility == Visibility.Visible) { nbPage = "116"; }
            else if (this.Immage117.Visibility == Visibility.Visible) { nbPage = "117"; }
            else if (this.Immage118.Visibility == Visibility.Visible) { nbPage = "118"; }
            else if (this.Immage119.Visibility == Visibility.Visible) { nbPage = "119"; }
            else if (this.Immage120.Visibility == Visibility.Visible) { nbPage = "120"; }
            else if (this.Immage121.Visibility == Visibility.Visible) { nbPage = "121"; }
            else if (this.Immage122.Visibility == Visibility.Visible) { nbPage = "122"; }
            else if (this.Immage123.Visibility == Visibility.Visible) { nbPage = "123"; }
            else if (this.Immage124.Visibility == Visibility.Visible) { nbPage = "124"; }
            else if (this.Immage125.Visibility == Visibility.Visible) { nbPage = "125"; }
            else if (this.Immage126.Visibility == Visibility.Visible) { nbPage = "126"; }
            else if (this.Immage127.Visibility == Visibility.Visible) { nbPage = "127"; }
            else if (this.Immage128.Visibility == Visibility.Visible) { nbPage = "128"; }
            else if (this.Immage129.Visibility == Visibility.Visible) { nbPage = "129"; }
            else if (this.Immage130.Visibility == Visibility.Visible) { nbPage = "130"; }
            else if (this.Immage131.Visibility == Visibility.Visible) { nbPage = "131"; }
            else if (this.Immage132.Visibility == Visibility.Visible) { nbPage = "132"; }
            else if (this.Immage133.Visibility == Visibility.Visible) { nbPage = "133"; }
            else if (this.Immage134.Visibility == Visibility.Visible) { nbPage = "134"; }
            else if (this.Immage135.Visibility == Visibility.Visible) { nbPage = "135"; }
            else if (this.Immage136.Visibility == Visibility.Visible) { nbPage = "136"; }
            else if (this.Immage137.Visibility == Visibility.Visible) { nbPage = "137"; }
            else if (this.Immage138.Visibility == Visibility.Visible) { nbPage = "138"; }
            else if (this.Immage139.Visibility == Visibility.Visible) { nbPage = "139"; }
            else if (this.Immage140.Visibility == Visibility.Visible) { nbPage = "140"; }
            else if (this.Immage141.Visibility == Visibility.Visible) { nbPage = "141"; }
            else if (this.Immage142.Visibility == Visibility.Visible) { nbPage = "142"; }
            else if (this.Immage143.Visibility == Visibility.Visible) { nbPage = "143"; }
            else if (this.Immage144.Visibility == Visibility.Visible) { nbPage = "144"; }
            else if (this.Immage145.Visibility == Visibility.Visible) { nbPage = "145"; }
            else if (this.Immage146.Visibility == Visibility.Visible) { nbPage = "146"; }
            else if (this.Immage147.Visibility == Visibility.Visible) { nbPage = "147"; }
            else if (this.Immage148.Visibility == Visibility.Visible) { nbPage = "148"; }
            else if (this.Immage149.Visibility == Visibility.Visible) { nbPage = "149"; }
            else if (this.Immage150.Visibility == Visibility.Visible) { nbPage = "150"; }
            else if (this.Immage151.Visibility == Visibility.Visible) { nbPage = "151"; }
            else if (this.Immage152.Visibility == Visibility.Visible) { nbPage = "152"; }
            else if (this.Immage153.Visibility == Visibility.Visible) { nbPage = "153"; }
            else if (this.Immage154.Visibility == Visibility.Visible) { nbPage = "154"; }
            else if (this.Immage155.Visibility == Visibility.Visible) { nbPage = "155"; }
            else if (this.Immage156.Visibility == Visibility.Visible) { nbPage = "156"; }
            else if (this.Immage157.Visibility == Visibility.Visible) { nbPage = "157"; }
            else if (this.Immage158.Visibility == Visibility.Visible) { nbPage = "158"; }
            else if (this.Immage159.Visibility == Visibility.Visible) { nbPage = "159"; }

            string pointsEnString;
            object pointsEnObject;
            switch (nbPage)
            {
                case "1":
                    {
                        this.reponseNom = "Aatrox";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "2":
                    {
                        this.reponseNom = "Ahri";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "3":
                    {
                        this.reponseNom = "Akali";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "4":
                    {
                        this.reponseNom = "Akshan";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "5":
                    {
                        this.reponseNom = "Alistar";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "6":
                    {
                        this.reponseNom = "Amumu";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "7":
                    {
                        this.reponseNom = "Anivia";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "8":
                    {
                        this.reponseNom = "Annie";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "9":
                    {
                        this.reponseNom = "Aphelios";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "10":
                    {
                        this.reponseNom = "Ashe";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "11":
                    {
                        this.reponseNom = "Aurelion Sol";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "12":
                    {
                        this.reponseNom = "Azir";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "13":
                    {
                        this.reponseNom = "Bard";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "14":
                    {
                        this.reponseNom = "Blitzcrank";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "15":
                    {
                        this.reponseNom = "Brand";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "16":
                    {
                        this.reponseNom = "Braum";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "17":
                    {
                        this.reponseNom = "Caitlyn";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "18":
                    {
                        this.reponseNom = "Camille";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "19":
                    {
                        this.reponseNom = "Cassiopeia";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "20":
                    {
                        this.reponseNom = "Cho'Gath";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "21":
                    {
                        this.reponseNom = "Corki";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "22":
                    {
                        this.reponseNom = "Darius";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "23":
                    {
                        this.reponseNom = "Diana";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "24":
                    {
                        this.reponseNom = "Mundo";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "25":
                    {
                        this.reponseNom = "Draven";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "26":
                    {
                        this.reponseNom = "Ekko";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "27":
                    {
                        this.reponseNom = "Elise";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "28":
                    {
                        this.reponseNom = "Evelynn";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "29":
                    {
                        this.reponseNom = "Ezreal";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "30":
                    {
                        this.reponseNom = "Fiddlesticks";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "31":
                    {
                        this.reponseNom = "Fiora";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "32":
                    {
                        this.reponseNom = "Fizz";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "33":
                    {
                        this.reponseNom = "Galio";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "34":
                    {
                        this.reponseNom = "Gangplank";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "35":
                    {
                        this.reponseNom = "Garen";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "36":
                    {
                        this.reponseNom = "Gnar";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "37":
                    {
                        this.reponseNom = "Gragas";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "38":
                    {
                        this.reponseNom = "Graves";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "39":
                    {
                        this.reponseNom = "Gwen";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "40":
                    {
                        this.reponseNom = "Hecarim";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "41":
                    {
                        this.reponseNom = "Heimerdinger";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "42":
                    {
                        this.reponseNom = "Illaoi";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "43":
                    {
                        this.reponseNom = "Irelia";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "44":
                    {
                        this.reponseNom = "Ivern";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "45":
                    {
                        this.reponseNom = "Janna";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "46":
                    {
                        this.reponseNom = "Jarvan IV";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "47":
                    {
                        this.reponseNom = "Jax";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "48":
                    {
                        this.reponseNom = "Jayce";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "49":
                    {
                        this.reponseNom = "Jhin";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "50":
                    {
                        this.reponseNom = "Jinx";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "51":
                    {
                        this.reponseNom = "Kai'Sa";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "52":
                    {
                        this.reponseNom = "Kalista";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "53":
                    {
                        this.reponseNom = "Karma";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "54":
                    {
                        this.reponseNom = "Karthus";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "55":
                    {
                        this.reponseNom = "Kassadin";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "56":
                    {
                        this.reponseNom = "Katarina";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "57":
                    {
                        this.reponseNom = "Kayle";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "58":
                    {
                        this.reponseNom = "Kayn";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "59":
                    {
                        this.reponseNom = "Kennen";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "60":
                    {
                        this.reponseNom = "Kha'Zix";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "61":
                    {
                        this.reponseNom = "Kindred";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "62":
                    {
                        this.reponseNom = "Kled";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "63":
                    {
                        this.reponseNom = "Kog'Maw";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "64":
                    {
                        this.reponseNom = "LeBlanc";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "65":
                    {
                        this.reponseNom = "Lee Sin";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "66":
                    {
                        this.reponseNom = "Leona";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "67":
                    {
                        this.reponseNom = "Lillia";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "68":
                    {
                        this.reponseNom = "Lissandra";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "69":
                    {
                        this.reponseNom = "Lucian";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "70":
                    {
                        this.reponseNom = "Lulu";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "71":
                    {
                        this.reponseNom = "Lux";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "72":
                    {
                        this.reponseNom = "Malphite";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "73":
                    {
                        this.reponseNom = "Malzahar";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "74":
                    {
                        this.reponseNom = "Maokai";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "75":
                    {
                        this.reponseNom = "Master Yi";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "76":
                    {
                        this.reponseNom = "Miss Fortune";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "77":
                    {
                        this.reponseNom = "Mordekaizer";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "78":
                    {
                        this.reponseNom = "Morgana";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "79":
                    {
                        this.reponseNom = "Nami";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "80":
                    {
                        this.reponseNom = "Nautilus";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "81":
                    {
                        this.reponseNom = "Nasus";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "82":
                    {
                        this.reponseNom = "Neeko";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "83":
                    {
                        this.reponseNom = "Nidalee";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "84":
                    {
                        this.reponseNom = "Nocturne";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "85":
                    {
                        this.reponseNom = "Nunu & Willump";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "86":
                    {
                        this.reponseNom = "Olaf";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "87":
                    {
                        this.reponseNom = "Oriana";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "88":
                    {
                        this.reponseNom = "Ornn";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "89":
                    {
                        this.reponseNom = "Pantheon";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "90":
                    {
                        this.reponseNom = "Poppy";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "91":
                    {
                        this.reponseNom = "Pyke";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "92":
                    {
                        this.reponseNom = "Qiyana";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "93":
                    {
                        this.reponseNom = "Quinn";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "94":
                    {
                        this.reponseNom = "Rakan";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "95":
                    {
                        this.reponseNom = "Rammus";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "96":
                    {
                        this.reponseNom = "Rek'Sai";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "97":
                    {
                        this.reponseNom = "Rell";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "98":
                    {
                        this.reponseNom = "Renata";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "99":
                    {
                        this.reponseNom = "Renekton";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "100":
                    {
                        this.reponseNom = "Rengar";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "101":
                    {
                        this.reponseNom = "Riven";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "102":
                    {
                        this.reponseNom = "Rumble";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "103":
                    {
                        this.reponseNom = "Ryze";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "104":
                    {
                        this.reponseNom = "Sejuani";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "105":
                    {
                        this.reponseNom = "Samira";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "106":
                    {
                        this.reponseNom = "Senna";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "107":
                    {
                        this.reponseNom = "Séraphine";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "108":
                    {
                        this.reponseNom = "Sett";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "109":
                    {
                        this.reponseNom = "Shaco";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "110":
                    {
                        this.reponseNom = "Shen";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "111":
                    {
                        this.reponseNom = "Shyvana";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "112":
                    {
                        this.reponseNom = "Singed";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "113":
                    {
                        this.reponseNom = "Sion";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "114":
                    {
                        this.reponseNom = "Sivir";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "115":
                    {
                        this.reponseNom = "Skarner";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "116":
                    {
                        this.reponseNom = "Sona";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "117":
                    {
                        this.reponseNom = "Soraka";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "118":
                    {
                        this.reponseNom = "Swain";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "119":
                    {
                        this.reponseNom = "Sylas";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "120":
                    {
                        this.reponseNom = "Syndra";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "121":
                    {
                        this.reponseNom = "Tahm Kench";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "122":
                    {
                        this.reponseNom = "Taliyah";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "123":
                    {
                        this.reponseNom = "Talon";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "124":
                    {
                        this.reponseNom = "Taric";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "125":
                    {
                        this.reponseNom = "Teemo";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "126":
                    {
                        this.reponseNom = "Thresh";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "127":
                    {
                        this.reponseNom = "Tristana";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "128":
                    {
                        this.reponseNom = "Trundle";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "129":
                    {
                        this.reponseNom = "Tryndamere";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "130":
                    {
                        this.reponseNom = "Twisted Fate";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "131":
                    {
                        this.reponseNom = "Twitch";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "132":
                    {
                        this.reponseNom = "Udyr";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "133":
                    {
                        this.reponseNom = "Urgot";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "134":
                    {
                        this.reponseNom = "Varus";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "135":
                    {
                        this.reponseNom = "Vayne";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "136":
                    {
                        this.reponseNom = "Veigar";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "137":
                    {
                        this.reponseNom = "Vel'Koz";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "138":
                    {
                        this.reponseNom = "Vex";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "139":
                    {
                        this.reponseNom = "Vi";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "140":
                    {
                        this.reponseNom = "Viego";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "141":
                    {
                        this.reponseNom = "Viktor";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "142":
                    {
                        this.reponseNom = "Vladimir";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "143":
                    {
                        this.reponseNom = "Volibear";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "144":
                    {
                        this.reponseNom = "Warwick";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "145":
                    {
                        this.reponseNom = "Wukong";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "146":
                    {
                        this.reponseNom = "Xayah";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "147":
                    {
                        this.reponseNom = "Xerath";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "148":
                    {
                        this.reponseNom = "Xin Zhao";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "149":
                    {
                        this.reponseNom = "Yasuo";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "150":
                    {
                        this.reponseNom = "Yone";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "151":
                    {
                        this.reponseNom = "Yorick";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "152":
                    {
                        this.reponseNom = "Yuumi";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "153":
                    {
                        this.reponseNom = "Zac";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "154":
                    {
                        this.reponseNom = "Zed";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "155":
                    {
                        this.reponseNom = "Zeri";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "156":
                    {
                        this.reponseNom = "Ziggs";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "157":
                    {
                        this.reponseNom = "Zilean";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "158":
                    {
                        this.reponseNom = "Zoé";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;
                case "159":
                    {
                        this.reponseNom = "Zyra";
                        if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())
                        {
                            this.LabelFaire.Content = "Bravo c'est juste";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#FF0FFF00");
                            this.LabelFaire.Foreground = couleur1;
                            points += 1;
                        }
                        else
                        {
                            this.LabelFaire.Content = "Faux !";
                            Brush couleur1 = (Brush)bc.ConvertFrom("#f00020");
                            this.LabelFaire.Foreground = couleur1;
                            points -= 1;
                        }
                        pointsEnString = points.ToString();
                        pointsEnObject = pointsEnString;
                        LaPoints.Content = pointsEnObject;
                        Button_Click(sender, e);
                    }
                    break;



            }
        }

        public static List<Chapions> ChargeChampions()
        {
            List<Chapions> lesStocks = null;
            try
            {
                String contenuFichier = File.ReadAllText("Championsse.json");
                lesStocks = JsonConvert.DeserializeObject<List<Chapions>>(contenuFichier);
            }
            catch (Exception e) { throw e; }
            return lesStocks;
        }
        public static void AfficheListe(List<Chapions> liste)
        {
            foreach (Chapions unChampion in liste)
                Console.WriteLine(unChampion);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
