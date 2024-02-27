namespace Task4
{
    class Program
    {
        static int[][] Input()
        {
            Console.WriteLine("Enter a size of array: ");
            
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[i + 1];
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }

        static void SecondPrint(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++, Console.WriteLine())
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0,4}", arr[i][j]);
                }
            }
        }

        static int[] CountGreaterElements(int[][] arr, int num)
        {
            int n = arr.Length;
            int[] counts = new int[n];

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                foreach (int x in arr[i])
                {
                    if (x > num)
                    {
                        count++;
                    }
                }
                counts[i] = count;
            }

            return counts;
        }

        static void Main(string[] args)
        {
            int[][] arr = Input();

            Console.WriteLine("Enter number for search: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your array: ");
            SecondPrint(arr);

            int[] counts = CountGreaterElements(arr, num);
            Console.WriteLine("Counts of elements greater than {0} in each row: ", num);
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine("Row {0}: {1}", i + 1, counts[i]);
            }
        }
    }
}