using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class BubbleSort
    {
        int[] a = new int[20];
        public void GenerateArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (int)(rnd.NextDouble() * 250);
            }
        }
        public void OutputArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public void Sorts()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int g = i + 1; g < a.Length; g++)
                {
                    if (a[i] > a[g])
                    {
                        int t = a[i];
                        a[i] = a[g];
                        a[g] = t;
                    }
                }
            }
        }
    }
}
