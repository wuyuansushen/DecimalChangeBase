using System;
using System.Collections.Generic;

namespace DecimalChangeBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Base Number(2-36): ");
            int baseNum = Convert.ToInt32(Console.ReadLine());

            if (baseNum > 36 || baseNum < 2)
            {
                Console.WriteLine("Base Number error");
                return;
            }
            else
            {

                List<int> output = new List<int>();

                //Display
                #region
                Dictionary<int, char> outputMap = new Dictionary<int, char>();

                char LessTen = '0';
                if (baseNum < 10)
                {
                    for (int i = 0; i < baseNum; i++)
                    {
                        outputMap.Add(i, LessTen);
                        LessTen++;
                    }
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        outputMap.Add(i, LessTen);
                        LessTen++;
                    }
                    LessTen = 'A';
                    for (int i = 10; i < baseNum; i++)
                    {
                        outputMap.Add(i, LessTen);
                        LessTen++;
                    }
                }
                #endregion

                //Input Process and Half return
                #region
                    while (input >= baseNum)
                    {
                        int tmp = input % baseNum;
                        output.Add(tmp);
                        input = (input - tmp) / baseNum;
                    }
                    output.Add(input);
                #endregion

                //another half Output
                for (int i = output.Count - 1; i >= 0; i--)
                {
                    Console.Write($"{outputMap[output[i]]}");
                }
            }
        }
    }
}
