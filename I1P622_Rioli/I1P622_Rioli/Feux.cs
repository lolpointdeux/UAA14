using System;
using System.Collections.Generic;
using System.Text;

namespace I1P622_Rioli
{
    class Feux
    {
        private string id;
        private string color;
        private bool etat = false;

        public Feux (string FeuxId, string FeuxColor)

        {
            id = FeuxId;
            color = FeuxColor;

        }
        public void changeColor()
        {
            if (color == "rouge")
            {
                color = "vert";
            }
            color = "rouge";

        } 
        public void clignoter()
        {
          
            string chain = "";

            
            chain = $"{id} est éteint";


            Console.WriteLine(chain);

            
        }
        public void chainString ()
        {
            string chain = "";

            chain = $"Le feu  de signalisation {id} est {color} ";

            Console.WriteLine(chain);

        }



    }
}

    