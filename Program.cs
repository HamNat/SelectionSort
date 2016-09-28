using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelectionSort
            int[] a = {27, 3, 64, 33, 52, 85, 9, 12, 42, 77};
            int j;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[0] < a[i])
                {
                    j = a[0];
                    a[0] = a[i];
                    a[i] = j;
                }
            }
            Console.WriteLine(a[0]);

        }
    }
}
