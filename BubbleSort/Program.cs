namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] input = new[] { 10, 90, 20, 15, 80, 70, 60, 50,-5,-9,182,2245,10,7,578,521,023574 };
            Console.WriteLine($"input length = {input.Length}");
            Console.WriteLine($"input before sort");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"[{input[i]}] ");
            }
            //進行排序
            var afterSort = Sort(input);
            //排序結果
            Console.WriteLine($"\r\n input after sort");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"[{afterSort[i]}] ");
            }


        }

        /// <summary>
        /// 泡泡排序法
        /// </summary>
        /// <param name="input">輸入</param>
        /// <returns>排序結果</returns>
        public static int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j] )
                    {
                        //swap
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
                Console.Write($"\r\n i={i} ");
                for (int k = 0; k < input.Length; k++)
                {
                    Console.Write($"[{input[k]}] ");
                }
            }

            return input;
        }


    }
}
