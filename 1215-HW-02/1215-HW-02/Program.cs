using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1215_HW_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ch3_3_7();
            Console.ReadKey();
        }

        //ch3
        //3-1

        static void ch3_3_1()
        {
            int min = int.MaxValue;

            Console.WriteLine("3-1.寫一程式，輸入10個整數，求其最小值");
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"輸入第{i+1}個整數");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input < min)
                {
                    min = input;
                }
            }

            Console.WriteLine($"最小值為{min}");
        }

        //3-2
        static void ch3_3_2()
        {
            //set vatiables
            int n;
            int input_min = int.MaxValue;

            Console.WriteLine("3-2.寫一程式，輸入N個整數，求其最小值");
            Console.WriteLine("請輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"輸入第{i+1}個整數");
                int input_num = Convert.ToInt32(Console.ReadLine());

                if (input_num < input_min)
                {
                    input_min = input_num;
                }
            }

            Console.WriteLine($"最小值為{input_min}");
        }

        //3-3
        static void ch3_3_3()
        {

            var over_12 = new List<int>();

            Console.WriteLine("3-3.寫一程式，輸入10個整數，列出其中所有大於12的數字");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"輸入第{i+1}個整數");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input > 12)
                {
                    over_12.Add(input);
                }
            }

            int over_12_len = over_12.Count;

            Console.Write("大於12的整數為:");

            for (int i = 0; i < over_12_len; i++)
            {
                Console.Write($"{over_12[i]} ");
            }
        }

        //3-4
        static void ch3_3_4()
        {
            Console.WriteLine("3-4.寫一程式，輸入10個整數，列出其中所有大於12的數字的總和");

            int sum = 0;

            for (int i = 0; i< 10; i++)
            {
                Console.WriteLine($"輸入第{i+1}個數字");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input > 12)
                {
                    sum += input;
                }
            }

            Console.WriteLine($"所有大於12的數字的總和為{sum}");
        }

        //3-4
        static void ch3_3_5()
        {
            int n;
            int max = int.MinValue;

            Console.WriteLine("3-5.寫一程式，輸入N個數字，求其所有奇數中的最大值");
            Console.WriteLine("請輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"輸入第{i+1}個數字");
                int input = Convert.ToInt32(Console.ReadLine());

                if (Math.Abs(input % 2) == 1)
                {
                    if (input > max)
                    {
                        max = input;
                    }
                }
            }

            if (max > int.MinValue)
            {
                Console.WriteLine($"奇數中的大值為{max}");
            }
            else
            {
                Console.WriteLine("輸入值無奇數");
            }
        }

        static void ch3_3_6()
        {
            int n;
            int sum = 0;

            Console.WriteLine("3-6.寫一程式，輸入N個數字，求其所有正數之平方的加總");
            Console.WriteLine("請輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"輸入第{i+1}個數字");
                
                int input = Convert.ToInt32(Console.ReadLine());

                if (input > 0)
                {
                    sum += input * input;
                }
            }

            Console.WriteLine($"所有正數之平方加總為{sum}");
        }

        static void ch3_3_7()
        {
            int n;
            var old_list = new List<double>();
            var new_list = new List<double>();

            Console.WriteLine("3-7.寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數");
            Console.WriteLine("請輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"輸入第{i+1}個數");
                double input = Convert.ToDouble(Console.ReadLine());

                old_list.Add(input);
                new_list.Add(Math.Abs(input));

            }

            Console.Write("原輸入數字為:");
            old_list.ForEach(i => Console.Write($"{i} "));
            Console.Write("\n負數轉換為正數後結果為:");
            new_list.ForEach(i => Console.Write($"{i} "));
        }
    }
}
