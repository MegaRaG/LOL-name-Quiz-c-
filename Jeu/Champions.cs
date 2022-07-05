using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu
{
    public class Champions
    {
        private String nom;
        private string imagePath;
        private string description;
        public Champions(string nom,string imagePath, string description)
        {
            this.Nom = nom;
            this.ImagePath = imagePath;
            this.Description = description;
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }

        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string Description { get => description; set => description = value; }

        public override string ToString()
        {
            return $"nom : {this.Nom}" +
                $"\nImage : {this.ImagePath}" +
                $"\nDescri : {this.Description}";

        }

        public override bool Equals(object obj)
        {
            return obj is Champions chapions &&
                   this.nom == chapions.nom;
        }
        public static double RandomTous()
        {
            Random Generateur = new Random();
            double numeroChampionRandom = Generateur.Next(166);
            return numeroChampionRandom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.nom);
        }
    }
}
