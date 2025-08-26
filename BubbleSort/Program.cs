namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("泡泡排序法");
            int[] input = new[] { 10, 90, -20, 1, 80, 170, 60, 50,-5,-9 };
            Console.WriteLine($"input length = {input.Length}");

            //印出排序前資料
            Console.WriteLine($"input before sort");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"[{input[i]}] ");
            }
            Console.WriteLine($"\r\nSTART Sort");
            //進行排序
            var afterSort = Sort(input);

            //印出排序結果
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
                        //上面那段可以寫成  (input[i], input[j]) = (input[j], input[i]);
                    }
                }
                //輸出每輪排序後結果
                Console.Write($" i={i} ");
                for (int k = 0; k < input.Length; k++)
                {
                    Console.Write($"[{input[k]}] ");
                }
                Console.Write($"\r\n");
            }

            return input;
        }


    }
}
