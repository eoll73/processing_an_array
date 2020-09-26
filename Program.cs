using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processing_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 487, 95, 140, 7, 998, 7, 22, 18, 2 };

            int max = a[0];
            int max2 = a[1];
            if (max2 > max)
            {
                max = max2;
                max2 = a[0];
            }
            for (int i = 2; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max2 = max;
                    max = a[i];
                }

                if (max2 < a[i] && a[i] != max)
                {
                    max2 = a[i];
                }
            }
            Console.Write(max + " ");
            Console.Write(max2);

            //Delay
            Console.ReadKey();


            // Find the minimum element of the array
            //int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            //int min = a[0];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (min > a[i])
            //    {
            //        min = a[i];
            //    }
            //}

            //Console.WriteLine(min);

        }



    }
}
