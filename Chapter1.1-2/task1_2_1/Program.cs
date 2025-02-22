﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 50000000;

            ArrayList arrayList = new ArrayList();
            List<string> listS = new List<string>();
            Hashtable hashTable = new Hashtable();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            Console.WriteLine("ArrayList vs. List<T>");

            Console.WriteLine("-> Add");
            Console.Write("\tArrayList:\t");
            DateTime start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                arrayList.Add("lubię placki");
            }
            Console.WriteLine(DateTime.Now - start);

            Console.Write("\tList<T>:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                listS.Add("lubię placki");
            }
            Console.WriteLine(DateTime.Now - start);

            Console.WriteLine("-> Access");
            Console.Write("\tArrayList:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                var s = (string)arrayList[i];
            }

            Console.WriteLine(DateTime.Now - start);
            Console.Write("\tList<T>:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                var s = listS[i];
            }
            Console.WriteLine(DateTime.Now - start);

            Console.WriteLine("-> Delete");
            Console.Write("\tArrayList:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                arrayList.RemoveAt(arrayList.Count - 1);
            }
            Console.WriteLine(DateTime.Now - start);

            Console.Write("\tList<T>:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                listS.RemoveAt(listS.Count - 1);
            }
            Console.WriteLine(DateTime.Now - start);

            N = 10000000;

            Console.WriteLine("Hashtable vs. Dictionary");

            Console.WriteLine("-> Add");
            Console.Write("\tHashtable:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                hashTable.Add(i, "lubię placki");
            }
            Console.WriteLine(DateTime.Now - start);

            Console.Write("\tDictionary:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                dictionary.Add(i, "lubię placki");
            }
            Console.WriteLine(DateTime.Now - start);

            Console.WriteLine("-> Access");
            Console.Write("\tHashtable:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                var s = (string)hashTable[i];
            }
            Console.WriteLine(DateTime.Now - start);

            Console.Write("\tDictionary:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                var a = dictionary[i];
            }
            Console.WriteLine(DateTime.Now - start);

            Console.WriteLine("-> Delete");
            Console.Write("\tHashtable:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                hashTable.Remove(i);
            }
            Console.WriteLine(DateTime.Now - start);

            Console.Write("\tDictionary:\t");
            start = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                dictionary.Remove(i);
            }
            Console.WriteLine(DateTime.Now - start);

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
