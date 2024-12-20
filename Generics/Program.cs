using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            // Generics for Integer 
            //Generics<int> num = new Generics<int>();
            //num.Add(1);
            //num.Add(2);
            //num.Add(3);
            //num.Add(4);
            //num.Add(5);

            //Console.WriteLine();
            //Console.WriteLine("Integers value are : ");
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //// Generics for String 
            //Generics<string> str = new Generics<string>();
            //str.Add("Vishal");
            //str.Add("Vipul");
            //str.Add("Dhiraj");
            //str.Add("Rushi");
            //str.Add("Harshal");

            //Console.WriteLine();
            //Console.WriteLine("Strings value are : ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //// Generics for Double
            //Generics<double> d = new Generics<double>();
            //d.Add(10.5);
            //d.Add(20.1);
            //d.Add(30.4);
            //d.Add(17.8);
            //d.Add(20);

            //Console.WriteLine();
            //Console.WriteLine("Double value are : ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(d[i]);

            Generics g = new Generics();

            // Generics for Integer
            Console.WriteLine();
            int[] a1 = new int[5];
            g.Add(a1, 1, 0);
            g.Add(a1, 2, 1);
            g.Add(a1, 3, 2);
            g.Add(a1, 4, 3);
            g.Add(a1, 5, 4);
            Console.WriteLine("Integer Array:");
            g.Display(a1);

            //Generics For String 
            Console.WriteLine();
            string[] a2 = new string[5];
            g.Add(a2, "Vishal", 0);
            g.Add(a2, "Vipul", 1);
            g.Add(a2, "Dhiraj", 2);
            g.Add(a2, "Rushi", 3);
            g.Add(a2, "Harshal", 4);
            Console.WriteLine("String Array:");
            g.Display(a2);

            //Generics For Double
            Console.WriteLine();
            double[] a3 = new double[5];
            g.Add(a3, 10.4, 0);
            g.Add(a3, 30.9, 1);
            g.Add(a3, 34.6, 2);
            g.Add(a3, 26, 3);
            g.Add(a3, 40.6, 4);
            Console.WriteLine("Double Array:");
            g.Display(a3);


        }

    }
}
