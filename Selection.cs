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
                System.Console.Write(selection[b]);
            }
            System.Console.Write("\n");
            return selection;
        }
        public static List<Guid> SelectionSort(List<Guid> p)
        {
            List<Guid> selection = p;
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

            System.Console.Write("Guid Selection Sort: ");
            for (int b = 0; b < selection.Count; b++)
            {
                System.Console.Write(selection[b]);
            }
            System.Console.Write("\n");
            return selection;
        }
    }
}
