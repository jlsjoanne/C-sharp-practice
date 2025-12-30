using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1229_HW_ALL
{
    internal class CH7
    {
        internal static string path = @"C:\Users\jlsjo\Documents\RocketCamp\C-sharp-practice\sample-file\";
        //檔案處理
        //1
        //寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。
        internal static void Exercise_File_1()
        {
            string lyrics = @"本來應該從從容容 游刃有餘
現在是匆匆忙忙 連滾帶爬
睜眼說瞎話 你在哽咽什麼啦
你在哭什麼哭 沒出息！";
            File.WriteAllText(path + "1.txt", lyrics);

            Console.WriteLine("歌詞寫入檔案完成");
            
        }

        //2
        //讀取1.txt 顯示在畫面上。
        internal static void Exercise_File_2()
        {

            Console.WriteLine("讀取1.txt 顯示在畫面上");
            string getText = File.ReadAllText(path + "1.txt");
            Console.WriteLine(getText);
        }

        //補充1
        //寫入九九乘法表資料到一個文字檔到自己指定的文字檔。
        internal static void File_Extra_1()
        {
            string output_text = "";

            for (int i = 2; i<= 9; i++)
            {
                for (int j = 1; j<=9; j++)
                {
                    if(i == 9 & j == 9)
                    {
                        output_text += $"{i}x{j}={i * j}";
                    }
                    else
                    {
                        output_text += $"{i}x{j}={i * j}\n";
                    }
                        
                }
            }
            File.WriteAllText(path + "1.txt", output_text);
            Console.WriteLine("九九乘法表寫入檔案完成");
        }

        //補充2
        //讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。
        internal static void File_Extra_2()
        {
            string input_text = File.ReadAllText(path + "1.txt");
            string output_text = "";

            Console.WriteLine("讀取1.txt 顯示在畫面上");
            Console.WriteLine(input_text);

            Console.WriteLine("請輸入指定路徑");
            string target_path = Console.ReadLine();

            input_text = input_text.Replace('x', '_');
            input_text = input_text.Replace('=', '_');

            string[] text_by_line = input_text.Split('\n');
            int line_num = text_by_line.Length;

            for (int i = 0; i < line_num; i++)
            {
                
                string[] line = text_by_line[i].Split('_');
                if (line.Length == 3)
                {
                    string num1 = Int_to_Str(num: Convert.ToInt32(line[0]));
                    string num2 = Int_to_Str(Convert.ToInt32(line[1]));
                    int sum = Convert.ToInt32(line[2]);

                    if (sum >= 10)
                    {
                        int tens = sum / 10;
                        int remain = sum % 10;
                        if (tens == 1)
                        {
                            if (remain == 0)
                            {
                                output_text += $"{num1}x{num2}=拾\n";
                            }
                            else
                            {
                                output_text += $"{num1}x{num2}=拾{Int_to_Str(remain)}\n";
                            }
                        }
                        else
                        {
                            if (remain == 0)
                            {
                                output_text += $"{num1}x{num2}={Int_to_Str(tens)}拾\n";
                            }
                            else
                            {
                                output_text += $"{num1}x{num2}={Int_to_Str(tens)}拾{Int_to_Str(remain)}\n";
                            }
                        }
                    }
                    else
                    {
                        string total = Int_to_Str(sum);
                        output_text += $"{num1}x{num2}={total}\n";
                    }
                }
            }

            File.WriteAllText(target_path + "\\壹.txt", output_text);
            Console.WriteLine("將1.txt的阿拉伯數字轉為中文數字，並儲存完成");

        }

        //阿拉伯數字轉換中文數字methods
        internal static string Int_to_Str(int num)
        {
            string num_str="";

            switch (num)
            {
                case 1:
                    num_str = "壹";
                    break;
                case 2:
                    num_str = "貳";
                    break;
                case 3:
                    num_str = "參";
                    break;
                case 4:
                    num_str = "肆";
                    break;
                case 5:
                    num_str = "伍";
                    break;
                case 6:
                    num_str = "陸";
                    break;
                case 7:
                    num_str = "柒";
                    break;
                case 8:
                    num_str = "捌";
                    break;
                case 9:
                    num_str = "玖";
                    break;
            }

            return num_str;
        }

        //補充3
        //讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
        internal static void File_Extra_3()
        {
            Console.WriteLine("讀取fc4bb.csv");
            string[] content = File.ReadAllLines(path + "fc4bb.csv");
            string output = "<table>\n";
            int total_lines = content.Length;

            for (int i = 0; i < total_lines; i++)
            {
                string[] elements = content[i].Split(',');
                int element_num = elements.Length;
                string lineToHtml = "\t<tr>\n";

                //transform table title
                if (i == 0)
                {
                    for(int j = 0; j < element_num; j++)
                    {
                        lineToHtml += $"\t\t<th>{elements[j]}</th>\n";
                    }
                }
                //transform table content
                else
                {
                    for(int j = 0; j < element_num; j++)
                    {
                        lineToHtml += $"\t\t<td>{elements[j]}</td>\n";
                    }
                }

                lineToHtml += "\t</tr>\n";

                output += lineToHtml;
            }

            output += "</table>";

            Console.WriteLine("輸入HTML檔名");
            string fileName = Console.ReadLine();

            File.WriteAllText(path + fileName + ".html", output);

            Console.WriteLine("轉成HTML table完成");
        }

        //亂數
        //1
        //請隨機由0~99產生一個數字輸出。
        internal static void Exercise_Random_1()
        {
            Random rom = new Random();
            int i = rom.Next(0, 100);

            Console.WriteLine("請隨機由0~99產生一個數字輸出");
            Console.WriteLine($"隨機數字為{i}");
        }

        //2
        //請隨機由0~99產生10個數字輸出。
        internal static void Exercise_Random_2()
        {
            Random rand = new Random();

            Console.WriteLine("請隨機由0~99產生10個數字輸出");

            for (int i = 0; i< 10; i++)
            {
                Console.WriteLine($"第{i+1}個數字為{rand.Next(0,100)}");
            }
        }

        //3
        //隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。
        internal static void Exercise_Random_3()
        {
            string[] student_name = File.ReadAllLines(path + "Student.txt");
            int student_num = student_name.Length;

            Random rand = new Random();

            for (int i = 0; i < student_num; i++)
            {
                int score = rand.Next(0, 100);
                string content = $"{student_name[i]}，{score}\n";
                File.AppendAllText(path + "Student_Score.txt",content);
            }

            Console.WriteLine("寫入完成");
        }

        //補充題
        //補充1
        //請設計樂透開獎程式
        internal static void Random_extra_1()
        {
            Random rand = new Random();
            List<int> result = new List<int>();

            while(result.Count != 6)
            {
                int num = rand.Next(1, 50);
                if(result.Contains(num) == false)
                {
                    result.Add(num);
                }
            }

            Console.WriteLine("樂透開獎號碼為:");
            foreach(int i in result)
            {
                Console.Write($"{i} ");
            }
            Console.Write("\n");
        }

        internal static void Random_extra_2()
        {
            Random rand = new Random();
            string[] rNames = File.ReadAllLines(path + "Restaurant.txt");
            int idx = rand.Next(0, rNames.Length);

            Console.WriteLine($"今天中午吃{rNames[idx]}");
            
        }
    }
}
