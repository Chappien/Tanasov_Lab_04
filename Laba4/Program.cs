using System;

namespace Lab04
{
    class Program
    {
        static double Func2(double x1, double x2)
        {
            return Math.Sin(x1 - Math.Pow(x2, 2) + Math.Sqrt(x1)) - 1.3 * Math.Pow(x1, 3);
        }



        static void Main(string[] args)
        {
            double startX = 1, dx = 0.5;
            const int size = 500;
            double[] arr = ClassLibraryLab04.Class1.CreateArrayFromTemplate(startX, dx, size, x => Func2(x * 2.76, x * 0.5));
            ClassLibraryLab04.Class1.PrintArray(arr);
            ClassLibraryLab04.Class1.BubbleSort(arr);
            ClassLibraryLab04.Class1.PrintArray(arr);

            ClassLibraryLab04.Class1.ProcessArray(arr, out double min, out double max, out double avg);

            Console.WriteLine("Min={0:#0.####}, Max={1:#0.####}, Avg={2:#0.####}", min, max, avg);

            int count = ClassLibraryLab04.Class1.PostProcessArray(arr, x => x >= 0.9 * avg && x <= 1.1 * avg);
            Console.WriteLine("R={0}", count);
            Console.WriteLine();

        }
    }
}