namespace Task2
{
    class Program
    {
        static int[] Input()
        {
            Console.WriteLine("Enter a size of massif: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) Console.Write("{0} ", arr[i]);
            Console.WriteLine();
        }

        static void Max(int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            Console.WriteLine("Index of all number, which less than the max value: ");      
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != max)
                {
                    Console.Write(i + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = Input();
            Console.WriteLine("Your array: ");
            Print(arr);
            Max(arr);
        }
    }
}