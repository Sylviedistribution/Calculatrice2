using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Caluculatrice");
            Console.WriteLine("Ce programme permet d'effectuer les differentes operations:");
            Console.WriteLine("L'addition representee par +");
            Console.WriteLine("La soustraction representee par -");
            Console.WriteLine("La multiplication repesente par *");
            Console.WriteLine("La division representee par /");
            Console.WriteLine("Le modulo reprsente par %");
            int a, b, res;
            string answer;

            do
            {
                Console.WriteLine("Choisissez le type d'operation: '+', '-', '*', '/', '%' ou 'q' pour quitter");
                answer = Console.ReadLine();
                if (answer=="q")
                {
                    break;
                }

                Console.WriteLine("Saisissez le premier nombre:");
                // Utilisez int.TryParse pour convertir la saisie en un nombre entier
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Saisie invalide. Veuillez entrer un nombre entier valide.");
                }

                Console.WriteLine("Saisissez le deuxième nombre:");
                // Utilisez int.TryParse pour convertir la saisie en un nombre entier
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Saisie invalide. Veuillez entrer un nombre valide.");
                }

                switch (answer)
                {
                    case "+":
                        res = addition(a, b);
                        Console.WriteLine($"Résultat de l'addition : {res}");
                        break;
                    case "-":
                        res = soustraction(a, b);
                        Console.WriteLine($"Résultat de la soustraction : {res}");
                        break;
                    case "*":
                        res = multiplication(a, b);
                        Console.WriteLine($"Résultat de la multiplication : {res}");
                        break;
                    case "/":
                        if (b != 0)
                        {
                            res = division(a, b);
                            Console.WriteLine($"Résultat de la division : {res}");
                        }

                        else
                            Console.WriteLine("Un nombre ne peut etre divise par 0. Reessayer");
                        break;

                }
            } while (answer != "q");
        }

        static int addition(int a, int b) {
            return a + b;

        }
        static double addition(double a, double b) 
        {
            return a + b;

        }
        static int soustraction(int a, int b)
        {
            return a - b;

        }
        static double soustraction(double a, double b)
        {
            return a - b;

        }
        static int multiplication(int a, int b)
        {
            return a * b;

        }
        static double multiplication(double a, double b)
        {
            return a + b;

        }
        static int division(int a, int b)
        {
            
                return a / b;
        }
            
        public double division(double a, double b)
        {
            
             return a / b;
      
        }
    }
}
