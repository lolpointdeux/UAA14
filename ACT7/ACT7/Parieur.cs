using System;
using System.Collections.Generic;
using System.Text;

namespace ACT7
{
    class Parieur
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private int _cash;

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        private Pari _pari;

        public Pari Pari
        {
            get { return _pari; }
            set { _pari = value; }
        }


        public Parieur(string nom, int cash, Pari monpari)
        {
            _nom = nom;
            _cash = cash;
            _pari = monpari;
        }


    }
}
