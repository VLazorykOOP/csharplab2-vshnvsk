namespace TwoDimensionalMassif
{
    class Program
    {
        public static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("Enter a size of massif: ");

            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, m];

            for(int i = 0; i < n; i++) 
                for(int j = 0; j < m; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            return arr;
        }

        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}", arr[i, j]); 
                }
        }

        public static void ArithmeticMean(int[,] arr)
        {
            int sum = 0;
            double result;

            for (int i = 0;i < arr.GetLength(0); i++)
                for(int j = 0;j < arr.GetLength(1); j++) 
                { 
                    sum += arr[i, j]; 
                }
            
            result = Convert.ToDouble(sum) / Convert.ToDouble(arr.Length);
            Console.WriteLine(Convert.ToDouble(result).ToString());
        }
    }
}