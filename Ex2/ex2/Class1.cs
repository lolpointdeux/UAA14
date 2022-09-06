using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ex2.Program;
namespace ex2
{
    public class Class1
    {
        string back;
        string fore;
        public double Double(string sentence)
        {
            double sortie = 0;
            string rep;

            do
            {
                Console.WriteLine(sentence);
                 rep = Console.ReadLine();
            } while (!double.TryParse(rep, out sortie));

            return sortie;
        }

        public void color()
        {
            
            ConsoleColor ForeColor = ConsoleColor.White;
            ConsoleColor BackColor = ConsoleColor.Black;


            do
            {
                Console.WriteLine("Couleur du font");
                back = Console.ReadLine();
            } while (!Enum.TryParse(back, out BackColor));

            do
            {
                Console.WriteLine("La couleur du texte");
                fore = Console.ReadLine();
            } while (!Enum.TryParse(fore, out ForeColor));

            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
        }
    }
}
