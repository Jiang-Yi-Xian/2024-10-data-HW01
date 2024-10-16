using System;
using System.Collections;
namespace data_HW01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //讀取輸入
            char[] expression = input.ToCharArray(); //將輸入結果轉為字元陣列
            Stack index = new Stack(); //建立堆疊

            for (int i = 0; i < expression.Length; i++) 
            {
                if (expression[i] == '(') //遇到左括則放入堆疊
                {
                    index.Push(i);
                }
                else if (expression[i] == ')') //遇到右括
                {
                    if (index.Count > 0) //堆疊不為空
                    {
                        int leftIndex = (int)index.Pop(); //取得左括的索引值
                        Console.WriteLine($"{leftIndex},{i}"); //輸出配對
                    }
                    else
                    {
                        Console.WriteLine($"-1,{i}"); //右括沒有配對到的情況
                    }
                }
            }
            while (index.Count > 0) //當堆疊不為空
            {
                int left = (int)index.Pop(); //取得左括的索引值
                Console.WriteLine($"{left},-1"); //左括沒有配對到的情況
            }
        }
    }
}
