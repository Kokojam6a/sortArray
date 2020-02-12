using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        int[] a = new int[20];
        public void generateArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a [i] = (int)(rnd.NextDouble () * 250);
            }
        }
        public void outputArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a [i] + " ");
            }
        }

        public void sorts ()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int g = i + 1; g < a.Length; g++)
                {
                    if(a [i] > a [g])
                    {
                        int t = a[i];
                        a[i] = a[g];
                        a[g] = t;
                    }
                }
            }
        }

        public static void Main()
        {
          Program sort = new Program();

             sort.generateArray();
             sort.outputArray();
             sort.sorts();
            Console.WriteLine();
            sort.outputArray();

            Console.ReadKey();
         }
        }
    }

