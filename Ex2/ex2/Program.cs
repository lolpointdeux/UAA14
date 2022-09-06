using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ex2.Class1;
namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            double[] Tableau = new double[10];
            
            string sentence = "";
            double test = 10;


            sentence = "Entrer un nombre : ";
            Tableau[1] = class1.Double(sentence);
           

           
            class1.color();


            Console.WriteLine(test);
            Console.ReadLine();

        }
    }
}