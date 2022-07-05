using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu
{
    public class Chapions
    {
        private String nom;
        private int numeroChampion;
        public Chapions()
        {

        }
        public Chapions(string nom,int numeroChampion)
        {
            this.Nom = nom;
            this.NumeroChampion = numeroChampion;
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

        public int NumeroChampion
        {
            get
            {
                return this.numeroChampion;
            }

            set
            {
                this.numeroChampion = value;
            }
        }

        public override string ToString()
        {
            return "Numéro Champion : " + this.NumeroChampion
                + "\n Nom : " + this.Nom;

        }

        public override bool Equals(object obj)
        {
            return obj is Chapions chapions &&
                   this.nom == chapions.nom &&
                   this.numeroChampion == chapions.numeroChampion;
        }
        public static double RandomTous()
        {
            Random Generateur = new Random();
            double numeroChampionRandom = Generateur.Next(166);
            return numeroChampionRandom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.nom, this.numeroChampion);
        }
    }
}
