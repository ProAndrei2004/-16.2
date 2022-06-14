using System;
using System.Linq;
using System.Collections.Generic;

namespace Практическая_16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] m = new string[5] { "wweg", "wege", "/", "2", "ERHER" };
            string cifr = "1234567890";
            List<int> cifrCount = new List<int>();
            int c = 0;
            for (int i = 0; i < m.Length; i++)
            {
                string gg = m[i];
                for (int j = 0; j < gg.Length; j++)
                {
                    if (cifr.Contains(gg[j]))
                    {
                        cifrCount.Add(1);
                        break;
                    }
                }
            }
            Console.WriteLine("кол-во цифр " + cifrCount.Sum());
            int numSlesh = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == "/")
                {
                    numSlesh = i;
                }
            }
            Console.WriteLine();
            string[] a = new string[numSlesh];
            for (int i = 0; i < numSlesh; i++)
            {
                a[i] = m[i];
                Console.Write(a[i] + " ");
            }
            string[] b = new string[m.Length - numSlesh - 1];
            bool bb = false;
            int jj = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (bb == true)
                {
                    b[jj] = m[i];
                    jj++;
                }

                if (m[i] == "/")
                {
                    bb = true;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].ToLower() == b[i])
                {
                    b[i] = b[i].ToUpper();
                }
                if (b[i].ToUpper() == b[i])
                {
                    b[i] = b[i].ToLower();
                }
                Console.Write(b[i] + " ");
            }
        }
    }
}
