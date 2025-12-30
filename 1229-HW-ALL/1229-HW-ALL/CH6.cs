using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _1229_HW_ALL
{
    internal class CH6
    {
        //6-1
        //輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin
        internal static void Exercise_1()
        {
            Console.WriteLine("輸入姓名");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi~{name}");
        }

        //6-2
        //請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。
        internal static void Exercise_2()
        {
            string text = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            
            Console.WriteLine("請輸入任何一個字");
            string input = Console.ReadLine();

            if (text.Contains(input) == true)
            {
                Console.WriteLine($"[{input}]出現在[人人為我，我為人人、饒人不癡漢，癡漢不饒人]中");
            }
            else
            {
                Console.WriteLine($"[{input}]沒有出現在[人人為我，我為人人、饒人不癡漢，癡漢不饒人]中");
            }

        }

        //6-3
        //輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。
        internal static void Exercise_3()
        {
            Console.WriteLine("輸入一段字");
            string input = Console.ReadLine();
            int len = input.Length;

            for (int i = 0; i < len; i++)
            {
                if(i == len - 1)
                {
                    Console.Write($"{input[i]}\n");
                }
                else
                {
                    Console.Write($"{input[i]}-");
                }
            }
        }

        //6-4
        //輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg
        internal static void Exercise_4()
        {
            Console.WriteLine("輸入檔名");
            string fname = Console.ReadLine();

            string[] fsplit = fname.Split('.');

            Console.WriteLine($"副檔名為{fsplit[fsplit.Length - 1]}");
        }

        //6-5
        //輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字
        internal static void Exercise_5()
        {
            Console.WriteLine("輸入一個單字");
            string input = Console.ReadLine();

            if(input.Length < 5)
            {
                Console.WriteLine("長度不夠");
            }
            else
            {
                Console.WriteLine($"前三個字為{input.Substring(0, 3)}");
            }
        }

        //6-6
        //輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌
        internal static void Exercise_6()
        {
            Console.WriteLine("輸入一段字");
            string input = Console.ReadLine();

            Console.WriteLine(input.Replace("我","小明"));
        }

        //6-7
        //輸入一串字，顯示輸入幾個字
        internal static void Exercise_7()
        {
            Console.WriteLine("輸入一串字");
            string input = Console.ReadLine();

            Console.WriteLine($"輸入{input.Length}個字");
        }

        //補充1
        //連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過
        internal static void Extra_1()
        {
            int input_num = 10;
            List<string> input_list = new List<string>();

            for (int i = 0; i < input_num; i++)
            {
                Console.WriteLine($"請輸入第{i+1}組文字");
                string input = Console.ReadLine();

                if (i == 0)
                {
                    input_list.Add(input);
                }
                else
                {
                    if(input_list.Contains(input) == true)
                    {
                        Console.WriteLine("輸入過");
                    }
                    else
                    {
                        input_list.Add(input);
                        Console.WriteLine("沒出現過");
                    }
                }
            }
        }


    }
}
