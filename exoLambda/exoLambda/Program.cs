using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exoLambda
{   
    public static partial class ArrayExtensions
    {
        public static ArrayList filtre(this ArrayList arr, Func<int,bool> func)
        {
            ArrayList newArr = new ArrayList();
            foreach(int item in arr)
            {
                if (func(item))
                {
                    newArr.Add(item);
                }
            }
            return newArr;
        }
    }
    internal class Program
    {
        public static void affiche(ArrayList arr)
        {
            foreach(String item in arr)
            {
                Console.Write(item);
                Console.Write("-");
            }
            Console.WriteLine();
        }
        public static ArrayList filtre(ArrayList arr,Func<String, bool> func)
        {
            ArrayList newArr = new ArrayList();
            foreach (String item in arr)
            {
                if (func(item))
                {
                    newArr.Add(item);
                }
            }
            return newArr;
        }
        static void Main(string[] args)
        {
           /* ArrayList desInts = new ArrayList();
            for (int i = 1; i <= 100; i++) { desInts.Add(i); }
            affiche(desInts.filtre((a) => a % 9 == 0));*/
            ArrayList capitales = new ArrayList(){"Paris","Madrid","Londres","Rome","Genève","Dublin","Moscou","Zurich","Prague" };
            affiche(filtre(capitales, ch => ch.StartsWith("P") || ch.StartsWith("Ma") || ch.Contains("dr") || !ch.Contains('o') || ch.EndsWith("e") || ch.EndsWith("ve")));
            Thread.Sleep(5000);
        }
    }
}
