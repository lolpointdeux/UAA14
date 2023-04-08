using System;
using System.Collections.Generic;
using System.Text;

namespace ACT7
{
    class Pari
    {
        private int _montant;
        private Parieur _joueur;

        public Parieur Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }

        public int Montant
        {
            get { return _montant; }
            set { _montant = value; }
        }

        private int _numChien;

        public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }
        
        public Pari(int montant,int numChien, Parieur joueur)
        {
            _numChien = numChien;
            _montant = montant;
            _joueur = joueur;
        }



    }
}
