namespace OneDimensionalMassif
{
    class Program
    {
        public static int[] Input()
        {
            Console.WriteLine("Enter a size of massif: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        public static void Print(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++) Console.Write("{0} ", arr[i]);
            Console.WriteLine();
        }

        public static void ArithmeticMean(int[] arr) 
        {
            int sum = 0;
            double result;

            for (int i = 0; i < arr.Length; i++) 
            {
                sum += arr[i];
            }

            result = Convert.ToDouble(sum) / Convert.ToDouble(arr.Length);
            Console.WriteLine(Convert.ToDouble(result).ToString());
        }
    }
}