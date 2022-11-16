using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercice_generique
{   
    class Pile:IEnumerable , IEnumerator
    {
        public delegate void FullDelegate(int n);
        public event FullDelegate FullPile;
        public ArrayList arr;
        private int length { get;  }
        public virtual void OnFullPile(int n)
        {
            if (FullPile!=null)
            {
                FullPile(n);
            }
        }
        public object Current
        {
            get { return arr[_position]; }
        }

        public Pile(int size)
        {
            arr = new ArrayList(size);
            length = size;
        }
        public void empile<T>(T p)
        {
            if (arr.Count < length)
            {
                arr.Insert(0, p);
            }
            if (arr.Count == length)
            {
                OnFullPile(length);
            }
        }
        public void depile()
        {
            if (arr.Count > 0)
            {
                arr.RemoveAt(0);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this ;
        }
        private int _position = -1;
        public bool MoveNext()
        {
            _position++;
            return (_position < arr.Count);
        }

        public void Reset()
        {
            _position = 0;
        }
    }
    class Personne
    {
        public Personne(string nom, int age)
        { this.nom = nom; this.age = age; }
        public override string ToString()
        {
            return this.nom + " " + this.age.ToString();
        }
        private string nom;
        private int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pile p = new Pile(4);
            p.FullPile += pilePleine;
            p.depile();
            p.empile(new Personne("toto", 12));
            p.empile(new Personne("titi", 15));
            p.empile(new Personne("tutu", 25));
            p.depile();
            p.empile(new Personne("toutou", 28));
            p.empile(new Personne("tintin", 14));
            p.empile(new Personne("tata", 11));
            foreach (Personne pe in p)
                Console.WriteLine(pe.ToString());
            Thread.Sleep(4000);
        }
        static void pilePleine(int n)
        {
            Console.WriteLine($"nbre d'element : {n} \nAttention Pile pleine");
        }
    }
}
