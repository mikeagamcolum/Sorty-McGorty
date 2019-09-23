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
                System.Console.Write(y[b] + " ");
            }
            System.Console.Write("\n");
            return y;
        }
        public static void BubbleSort(List<Guid> x)
        {
            List<Guid> y = x;
            List<String> z = new List<String>();

            for(int a = 0; a < y.Count; a++)
            {
                z.Insert(a, y[a].ToString());
            }

            for (int a = 0; a < z.Count - 1; a++)
            {
                for(int b = 0; b < z[0].Length; b++) // this loop compares characters
                {
                    if(Convert.ToInt32(z[a][b]) > Convert.ToInt32(z[a+1][b])) // gets ascii value of char to sort with
                    {
                        // swaps values
                        string temp = z[a + 1];
                        z[a + 1] = z[a];
                        z[a] = temp;
                    }
                    else if (Convert.ToInt32(z[a][b]) < Convert.ToInt32(z[a + 1][b]))
                    {
                        break; // because value is less than its successor, no need to continue this loop
                    }
                    // characters are equal, continue loop
                }
            }
            System.Console.Write("\nGUID Bubble Sort: ");
            for (int b = 0; b < z.Count; b++)
            {
                System.Console.Write("\n" + z[b]);
            }
            System.Console.Write("\n");
        }
    }
}
