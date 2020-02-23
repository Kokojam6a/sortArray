using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        public static void Main()
        {
            BubbleSort sort = new BubbleSort();
            sort.GenerateArray();
            sort.OutputArray();
            sort.Sorts();
            Console.WriteLine();
            sort.OutputArray();

            Console.ReadKey();
         }
        }
    }

