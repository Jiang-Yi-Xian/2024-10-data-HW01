using System;
using System.Collections;
namespace data_HW01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] expression = input.ToCharArray();
            Stack index = new Stack();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    index.Push(i);
                }
                else if (expression[i] == ')')
                {
                    if (index.Count > 0)
                    {
                        int leftindex = (int)index.Pop();
                        Console.WriteLine($"{leftindex},{i}");
                    }
                    else
                    {
                        Console.WriteLine($"-1,{i}");
                    }
                }
            }
            while (index.Count > 0)
            {
                int left = (int)index.Pop();
                Console.WriteLine($"{left},-1");
            }
        }
    }
}
