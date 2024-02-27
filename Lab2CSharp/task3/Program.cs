namespace Task3
{
    class Program
    {
        static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("Enter a size of massif: ");

            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            return arr;
        }

        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}", arr[i, j]);
                }
        }

        static void Swap(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
                for(int j = 0; j < arr.GetLength(1) / 2; j++)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, arr.GetLength(1) - 1 - j];
                    arr[i, arr.GetLength(1) - 1 - j] = temp;
                }

            Print(arr);
        }

        static void Main(string[] args)
        {
            int n, m;
            int[,] arr = Input(out n, out m);
            Console.WriteLine("Your array: ");
            Print(arr);
            Console.WriteLine("Swap array: ");
            Swap(arr);
        }
    }
}