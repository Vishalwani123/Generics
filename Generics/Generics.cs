using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //internal class Generics<T>
    //{
    //    T[] arr = new T[10];
    //    int count = 0;

    //    public void Add(T item)
    //    {
    //        if (count < arr.Length)
    //        {
    //            arr[count] = item;
    //            count++;
    //        }
    //        else
    //        {
    //            Console.WriteLine(" Array is Full. ");
    //        }
    //    }

    //    public T this[int index]
    //    {
    //        get { return arr[index]; }
    //        set { arr[index] = value;}
    //    }


    //}

    internal class Generics
    {

        public void Add<T>(T[] arr, T item, int index)
        {   
            if(index < arr.Length)
            {
                arr[index] = item;
            }
            else
            {
                Console.WriteLine("Array is Full. ");
            }
        }

        public void Display<T>(T[] arr)
        {
            foreach(T item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
