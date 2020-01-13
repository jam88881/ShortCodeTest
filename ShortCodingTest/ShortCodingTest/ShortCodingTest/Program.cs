﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
//using System.Core;

namespace ShortCodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Short Code Test");

            var list = new Listify(100, 200);
            Console.WriteLine("Listify object has been created from 100 to 200");
            var val = list[50];
            Console.WriteLine("Here is element 50 from the listify object:");
            Console.WriteLine(val);

            Console.ReadLine();

            Console.WriteLine("NONESSENTIAL START");
            var oEnumerator = list.GetEnumerator();

            Console.WriteLine("Listify elements are");
            while (oEnumerator.MoveNext())
            {
                Console.WriteLine(oEnumerator.Current);
            }

            for (int j = 0; j < list.Count; j++)
            {
                Console.WriteLine("Listify element " + j.ToString() + " is " + list[j]);
            }

            Console.WriteLine("NONESSENTIAL END");
            Console.ReadLine();
        }

    }


    //Listify implements the IList interface to get an IEnmunerable (an unstructured array) to act like a List (a well defined, structured array)
    public class Listify : IList<int>
    {
        public int Start = 10;
        public int End = 20;
        IEnumerable<int> oIEnumerable;

        public Listify()
        {
            oIEnumerable = Enumerable.Range(Start, End).Select(x => x);
        }

        public Listify(int pStart, int pEnd)
        {
            Start = pStart;
            End = pEnd;
            oIEnumerable = Enumerable.Range(Start, End).Select(x => x);
        }

        readonly IList<int> _list = new List<int>();

        public int this[int index] { get => oIEnumerable.ElementAt<int>(index); set => throw new NotImplementedException(); }

        public int Count => Math.Abs(End - Start);

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return oIEnumerable.GetEnumerator();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return oIEnumerable.GetEnumerator();
        }
    }

}
