using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift11._1_och_11._2
{
    class Kontakt
    {
        //medlemsvariabler

        private string fornamn;
        private string efternamn;
        private string telefon;

        //konstruktor

        public Kontakt(string fornamn, string efternamn, string telefon)
        {
            this.fornamn = fornamn;
            this.efternamn = efternamn;
            this.telefon = telefon;
        }

        //Egenskaper

            //redigera förnamn

        public string Fornamn
        {
            get
            {
                return fornamn;
            }
            set
            {
                fornamn = value;
            }

        }

            //redigera efternamn

        public string Efternamn
        {
            get
            {
                return efternamn;
            }
            set
            {
                efternamn = value;
            }

        }

            //redigera telefon

        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
            }

        }

        //Metoder

        public override string ToString()
        {
            return this.fornamn + " " + this.efternamn + " " + this.telefon;
        }

    }
}
