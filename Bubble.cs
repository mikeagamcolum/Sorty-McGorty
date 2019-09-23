using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace sorty_mcgorty
{
    class Bubble
    {
        public static List<Double> BubbleSort(List<Double> x)
        {
            List<double> y = x;
            for (int b = 0; b < y.Count - 1; b++)
            {
                for (int a = 1; a < y.Count - b; a++)
                {
                    if (y[a] < y[a - 1])
                    {
                        double g = y[a];
                        y[a] = y[a - 1];
                        y[a - 1] = g;
                    }
                }
            }
            System.Console.Write("Double Bubble Sort: ");
            for (int b = 0; b < y.Count; b++)
            {
                System.Console.Write(y[b]);
            }
            System.Console.Write("\n");
            return y;
        }
        public static string GuidToHash(Guid x)
        {
         //   for(int a = 0; a < x.; x++)
         //  {

            }
            SHA512.Create(string();
            return "";
        }
        public static List<Guid> BubbleSort(List<Guid> x)
        {
            List<Guid> y = x;
            for (int b = 0; b < y.Count - 1; b++)
            {
                for (int a = 1; a < y.Count - b; a++)
                {
                    if (y[a] < y[a - 1])
                    {
                        double g = y[a];
                        y[a] = y[a - 1];
                        y[a - 1] = g;
                    }
                }
            }
            System.Console.Write("Guid Bubble Sort: ");
            for (int b = 0; b < y.Count; b++)
            {
                System.Console.Write(y[b]);
            }
            System.Console.Write("\n");
            return y;
        }
    }
}
