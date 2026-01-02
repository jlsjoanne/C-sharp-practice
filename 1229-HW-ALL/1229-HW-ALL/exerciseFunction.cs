using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace _1229_HW_ALL
{
    internal class exerciseFunction
    {

        //使用者輸入值function, 用於題目2~5 + 7~10
        internal static string getInput()
        {
            Console.WriteLine("請輸入值");
            return Console.ReadLine();
        }


        //Function題目
        //題目一
        //寫一個function 可以把一般對話框的文字轉成HTML
        static internal void toHTML(string input, string path)
        {
            string html = "<html>\n" +"" +
                "<head>\n" +
                "\t<title>Document</title>\n" +
                "</head>\n" +
                "<body>\n";

            html += (input + "\n" + "</body>\n" + "</html>");

            File.WriteAllText(path,html);
        }

        //題目二
        //寫一個function，回傳輸入的值是否數字
        

        internal static bool isNum(string input)
        {
            double num;
            bool is_num = double.TryParse(input, out num);

            return is_num;
        }

        //題目三
        //寫一個function，回傳輸入的值是否符合E-mail格式

        internal static bool isEmail(string input)
        {
            string email_syntax = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            bool is_email = Regex.IsMatch(input, email_syntax);
            return is_email;
        }

        //4
        //寫一個function，回傳輸入的值是否符合手機格式

        internal static bool isMobile(string input)
        {
            string mobile_regex = @"09\d{2}(\d{6}|-\d{3}-\d{3})";
            bool is_mobile = Regex.IsMatch(input, mobile_regex);

            return is_mobile;

        }

        //5
        //寫一個function，回傳輸入的值是否符合身分證字號格式

        internal static void Exercise_5()
        {
            Console.WriteLine("請輸入值");
            string input = Console.ReadLine
        }
    }
}
