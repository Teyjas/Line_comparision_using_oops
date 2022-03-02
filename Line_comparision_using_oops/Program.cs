using System;

namespace Line_Comparison_Using_Opps
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to line comparison program");

            Line line1 = new Line();
            Line line2 = new Line();
            double length1 = line1.GetLength();
            double length2 = line2.GetLength();
            int val = length1.CompareTo(length2);

            if (val == 0)
                Console.WriteLine("Length of lines are equal");
            else if (val > 0)
                Console.WriteLine("Length of line 1 is greater than line 2");
            else
                Console.WriteLine("Length of line 2 is greater than line 1");
        }
    }
}