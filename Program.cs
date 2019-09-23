using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorty_mcgorty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> y = new List<double> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
            List<Guid> z = new List<Guid> { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()};
            Bubble.BubbleSort(y);
            Selection.SelectionSort(y);
            System.Console.Write("\nUnsorted GUIDs: ");
            for (int b = 0; b < z.Count; b++)
            {
                System.Console.Write("\n" + z[b]);
            }
            System.Console.Write("\n");
            Bubble.BubbleSort(z);
            Selection.SelectionSort(z);
        }
    }
}
