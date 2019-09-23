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
            Bubble.BubbleSort(y);
            Selection.SelectionSort(y);
        }
    }
}
