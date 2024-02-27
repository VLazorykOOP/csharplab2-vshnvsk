using System;
using OneDimensionalMassif;
using TwoDimensionalMassif;

namespace Task1
{
    class Program 
    {
        public static void OneDimensional()
        {
            int[] arr = OneDimensionalMassif.Program.Input();
            Console.WriteLine("Your array: ");
            OneDimensionalMassif.Program.Print(arr);
            Console.WriteLine("Arithmetical mean: ");
            OneDimensionalMassif.Program.ArithmeticMean(arr);
        }

        public static void TwoDimensional()
        {
            int n, m;
            int[,] arr = TwoDimensionalMassif.Program.Input(out n, out m);
            Console.WriteLine("Your array: ");
            TwoDimensionalMassif.Program.Print(arr);
            Console.WriteLine("Arithmetical mean: ");
            TwoDimensionalMassif.Program.ArithmeticMean(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Select an array type: \n" + 
                "\t1. One dimensional massif \n" + 
                "\t2. Two dimensional massif");

            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    OneDimensional();
                    break;
                case 2:
                    TwoDimensional();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
