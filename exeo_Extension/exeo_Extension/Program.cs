using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tp1_ex2
{
    public static partial class StringExtension
    {
        public static String retireCar(this String s, char c)
        {
            /*while (s.IndexOf(c) != -1)
            {*/
            return s.Remove(s.IndexOf(c), 1);
            /*}
            return s;*/
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String ch = "voiture";
            Console.WriteLine(ch.retireCar('t'));
            Thread.Sleep(3000);

        }
    }
}