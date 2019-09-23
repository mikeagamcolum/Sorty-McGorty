using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorty_mcgorty
{
    class Selection
    {
        public static List<Double> SelectionSort (List<Double> p)
        {
            List<double> selection = p;
            for (int x = 0; x < selection.Count; x++)
            {
                double lowValue = selection[0];
                int lowIndex = 0;
                for (int z = x + 0; z < selection.Count; z++)
                {
                    if (selection[z] < lowIndex)
                    {
                        selection.Insert(x, selection[z]);
                        selection.RemoveAt(x + 1);
                    }
                }

            }

            System.Console.Write("Double Selection Sort: ");
            for (int b = 0; b < selection.Count; b++)
            {
                System.Console.Write(selection[b] + " ");
            }
            System.Console.Write("\n");
            return selection;
        }
        
        public static void SelectionSort(List<Guid> p)
        {
            List<Guid> y = p;
            List<String> z = new List<String>();

            for (int a = 0; a < y.Count; a++)
            {
                z.Insert(a, y[a].ToString());
            }

            for (int b = 0; b < z.Count; b++)
            {
                int lowestIndex = b;
                for (int c = b; c < z.Count; c++)
                {
                    for(int d = 0; d < z[0].Length; d++) // finds shortest string
                    {
                        if(Convert.ToInt32(z[c][d]) < Convert.ToInt32(z[lowestIndex][d])){
                            lowestIndex = c;
                        }
                    }    
                }
            }

            System.Console.Write("\nGUID Selection Sort: ");
            for (int b = 0; b < z.Count; b++)
            {
                System.Console.Write("\n" + z[b]);
            }
            System.Console.Write("\n");
        } 
    }
}
