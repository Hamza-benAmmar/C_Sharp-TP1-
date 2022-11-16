using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public delegate int CalculDelegate(int a, int b);

    class Calcul
    {
        public static int somme(int a, int b)
        {
            return a + b;
        }
        public static int produit(int a, int b)
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Donner 2 entier et un caractere d'opéeration");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            String c = Console.ReadLine();
            /*if (c.CompareTo("+")==0)
            {
                Console.WriteLine(Calcul.somme(a, b));
            }
            else if(c.CompareTo("*")==0)
            {
                Console.WriteLine(Calcul.produit(a, b));
            }*/
            CalculDelegate calcul = null;
            if (c.CompareTo("+") == 0)
            {
                calcul = Calcul.somme;
            }
            else if (c.CompareTo("*") == 0)
            {
                calcul = Calcul.produit;
            }
            Console.WriteLine(calcul(a, b));


        }
    }
}
