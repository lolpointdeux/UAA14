using System;

namespace I1P622_Rioli
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;
            string color;

            Feux[] feux = new Feux[2];
            feux[0] = new Feux("42", "rouge");
            feux[1] = new Feux("12", "vert" );

            Console.WriteLine("Etats des feux  :");
            for (int i = 0; i < 2; i++)
            {

                feux[i].chainString();

            }
            Console.WriteLine("Changement d'Etat : ");
            for (int i = 0; i < 5; i++)
            {
                feux[i].changeColor();
                feux[i].chainString();
            }
            Console.WriteLine("Feu clignotant : "); 
                for (int i = 0; i < 5; i++)
                {
                    feux[i].clignoter();

                }
               
            }



           /* Voulais randomizer les id des feux 
            * for (int i = 0; i < 2; i++)
            {            
                Random random = new Random();
                id = random.Next(1, 100).ToString();
                int ran = random.Next(1, 2);
                if (ran == 1)
                {
                    color = "rouge";
                }
                else
                    color = "vert";

                feux[i] = new Feux(id, color);
            }*/
            
           
            
        }
    }
}
