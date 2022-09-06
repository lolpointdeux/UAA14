using System;
using static ACT00_REVISION.MethodesDuProjet;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE
            
            string rep;
            string methode;
            string infos;
            MethodesDuProjet Methodes = new MethodesDuProjet();

            double a = 0; 
            double b = 0;
            double c = 0;
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            
            bool ok = false;
            // instanciation de la structure
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                Console.WriteLine("Entrez la valeur du coté 1");
                double.TryParse(Console.ReadLine(), out a);
                Console.WriteLine("Entrez la valeur du coté 2");
                double.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("Entrez la valeur du coté 3");
                double.TryParse(Console.ReadLine(), out c);
                //lecture des 3 côtés
                c1 = lireDouble(1);
                c2 = lireDouble(2);
                c3 = lireDouble(3);
                

                // ordonner les côtés => APPEL ORDONNECOTES
                Methodes.OrdonneCotes(ref a,ref b,ref c);


                // ...
                // série de test (voir consignes)
                if (Methodes.Triangle(a, b, c))
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    Methodes.Affiche(true, "triangle", out infos);
                    Console.WriteLine(infos);
                    // ...

                    // vérification équilatéral
                    if (Methodes.Equi(a, b, c)) // on a un triangle équilatéral...)

                    {
                        Methodes.Affiche(true, "equilateral",
                            out infos); // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        Console.WriteLine(infos);
                        // ...
                    }
                    else
                    {
                        // vérification triangle rectangle
                        if (Methodes.TriangleRectangle(a, b, c))
                        {
                            Methodes.Affiche(true, "rectangle",
                                out infos); // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            Console.WriteLine(infos); // ...
                            // ...
                        }
                        else
                        {
                            Methodes.Affiche(false, "rectangle",
                                out infos); // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            Console.WriteLine(infos); // ...
                            // ...
                        }

                        // vérification du cas isocèle et affichage dans le cas positif
                        Methodes.Isocele(a, b, c);
                        Methodes.Affiche(true, "isocele", out infos);
                        //...
                        //...
                        //... A vous de voir en combien de lignes...
                    }
                }
                else 
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                      Methodes.Affiche(false, methode : "triangle", out infos);
                    // ...
                }
                
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}