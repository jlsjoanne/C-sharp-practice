using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1229_HW_ALL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool is_continue = true;
            
            Console.WriteLine("請輸入題目編號\n" +
                "CH6習題輸入6-1,6-2,...,6-7\n" +
                "CH6補充習題輸入6-extra-1, 6-extra-2,...,6-extra-6\n" +
                "CH7習題:\n" +
                "檔案部分輸入File-1,File-2，補充習題輸入File-extra-1,File-extra-2,File-extra-3\n" +
                "亂數部分輸入Random-1,...,Random-3，補充習題輸入Random-extra-1,...,Random-extra-3\n" +
                "日期部分輸入Date-1,...,Date-6，補充習題輸入Date-extra-1,...,Date-extra-3\n" +
                "Function習題輸入Function-1,Function-2,...,Function-10\n");


            while (is_continue)
            {
                string exercise_num = Console.ReadLine();

                switch (exercise_num)
                {
                    case "6-1":
                        exerciseCH6.Exercise_1();
                        break;
                    case "6-2":
                        exerciseCH6.Exercise_2();
                        break;
                    case "6-3":
                        exerciseCH6.Exercise_3();
                        break;
                    case "6-4":
                        exerciseCH6.Exercise_4();
                        break;
                    case "6-5":
                        exerciseCH6.Exercise_5();
                        break;
                    case "6-6":
                        exerciseCH6.Exercise_6();
                        break;
                    case "6-7":
                        exerciseCH6.Exercise_7();
                        break;
                    case "6-extra-1":
                        exerciseCH6.Extra_1();
                        break;
                    case "6-extra-2":
                        exerciseCH6.Extra_2();
                        break;
                    case "6-extra-3":
                        exerciseCH6.Extra_3();
                        break;
                    case "6-extra-4":
                        exerciseCH6.Extra_4();
                        break;
                    case "6-extra-5":
                        exerciseCH6.Extra_5();
                        break;
                    case "6-extra-6":
                        exerciseCH6.Extra_6();
                        break;
                    case "File-1":
                        exerciseCH7.File_Exercise_1();
                        break;
                    case "File-2":
                        exerciseCH7.File_Exercise_2();
                        break;
                    case "File-extra-1":
                        exerciseCH7.File_Extra_1();
                        break;
                    case "File-extra-2":
                        exerciseCH7.File_Extra_2();
                        break;
                    case "File-extra-3":
                        exerciseCH7.File_Extra_3();
                        break;
                    case "Random-1":
                        exerciseCH7.Random_Exercise_1();
                        break;
                    case "Random-2":
                        exerciseCH7.Random_Exercise_2();
                        break;
                    case "Random-3":
                        exerciseCH7.Random_Exercise_3();
                        break;
                    case "Random-extra-1":
                        exerciseCH7.Random_Extra_1();
                        break;
                    case "Rando-extra-2":
                        exerciseCH7.Random_Extra_2();
                        break;
                    case "Random-extra-3":
                        exerciseCH7.Random_Extra_3();
                        break;
                    case "Date-1":
                        exerciseCH7.DT_Exercise_1();
                        break;
                    case "Date-2":
                        exerciseCH7.DT_Exercise_2();
                        break;
                    case "Date-3":
                        exerciseCH7.DT_Exercise_3();
                        break;
                    case "Date-4":
                        exerciseCH7.DT_Exercise_4();
                        break;
                    case "Date-5":
                        exerciseCH7.DT_Exercise_5();
                        break;
                    case "Date-6":
                        exerciseCH7.DT_Exercise_6();
                        break;
                    case "Date-extra-1":
                        exerciseCH7.DT_Extra_1();
                        break;
                    case "Date-extra-2":
                        exerciseCH7.DT_Extra_2();
                        break;
                    case "Date-extra-3":
                        exerciseCH7.DT_Extra_3();
                        break;
                    case "Function-1":
                        break;
                    case "Function-2":
                        break;
                    case "Function-3":
                        break;
                    case "Function-4":
                        break;
                    case "Function-5":
                        break;
                    case "Function-6":
                        break;
                    case "Function-7":
                        break;
                    case "Function-8":
                        break;
                    case "Function-9":
                        break;
                    case "Function-10":
                        break;
                    default:
                        Console.WriteLine("格式輸入錯誤");
                        break;
                }

                Console.WriteLine("是否繼續輸入題目編號(Y/N)");
                string yn = Console.ReadLine();

                if (yn == "N" | yn == "n")
                {
                    is_continue = false;
                    Console.WriteLine("程式結束");
                }
                else if (yn == "Y" | yn == "y")
                {
                    Console.WriteLine("繼續輸入題目標號");
                }
                else
                {
                    Console.WriteLine("輸入錯誤，程式結束");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
