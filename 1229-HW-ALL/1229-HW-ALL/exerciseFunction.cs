using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;

namespace _1229_HW_ALL
{
    internal class exerciseFunction
    {

        //使用者輸入值function, 用於題目2~5 + 9~10
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

            File.WriteAllText(path + "\\output.html",html);
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

            return Regex.IsMatch(input, email_syntax);
        }

        //題目四
        //寫一個function，回傳輸入的值是否符合手機格式
        internal static bool isMobile(string input)
        {
            string mobile_regex = @"09\d{2}(\d{6}|-\d{3}-\d{3})";

            return Regex.IsMatch(input, mobile_regex);

        }

        //題目五
        //寫一個function，回傳輸入的值是否符合身分證字號格式
        internal static bool isIDCard(string input)
        {
            string idcard_regex = @"^[A-Z][12]\d{8}$";

            return Regex.IsMatch(input, idcard_regex);
        }

        //題目六
        //寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
        internal static string textIgnore(string input, int n)
        {
            return input.Substring(0, n) + "...";
        }

        //題目七
        //寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式
        internal static string dateToTaiwanCal(string input, char split_sym)
        {
            string[] input_seg = input.Split(split_sym);
            if (input_seg.Length != 3)
            {
                return "日期格式輸入錯誤，結束執行Function-7";
            }

            DateTime date = new DateTime(Convert.ToInt32(input_seg[0]),
                Convert.ToInt32(input_seg[1]), Convert.ToInt32(input_seg[2]));

            TaiwanCalendar taiwancal = new TaiwanCalendar();
            int t_y = taiwancal.GetYear(date);
            int t_m = date.Month;
            int t_d = date.Day;

            return $"民國{t_y}年{t_m}月{t_d}日";
        }

        //題目八
        //寫一個function，輸入一個日期，把該日期轉成民國XX年XX月XX日 星期X
        internal static string dateToTaiwanCalwWeekDay(string input, char split_sym)
        {
            

            string[] input_seg = input.Split(split_sym);
            if (input_seg.Length != 3)
            {
                return "日期格式輸入錯誤，結束執行Function-8";
            }

            string tw_date = dateToTaiwanCal(input, split_sym);
            DateTime date = new DateTime(Convert.ToInt32(input_seg[0]),
                Convert.ToInt32(input_seg[1]), Convert.ToInt32(input_seg[2]));

            return tw_date + $" 星期{dayOfWeekToCh((int)date.DayOfWeek)}";


        }

        internal static string dayOfWeekToCh(int day_of_week)
        {
            string day="";

            switch (day_of_week)
            {
                case 1:
                    day = "一";
                    break;
                case 2:
                    day = "二";
                    break;
                case 3:
                    day = "三";
                    break;
                case 4:
                    day = "四";
                    break;
                case 5:
                    day = "五";
                    break;
                case 6:
                    day = "六";
                    break;
                case 7:
                    day = "日";
                    break;
            }

            return day;
        }

        //題目九
        //寫一個function，回傳輸入的年是否閏年
        internal static bool isLeap(string input)
        {
            return DateTime.IsLeapYear(Convert.ToInt32(input));
        }

        //題目十
        //寫一個function，輸入手機號碼，回傳今天運勢
        internal static string getLuck(string input)
        {
            if (!isMobile(input))
            {
                return "不是手機號碼";
            }
            double last_4_digit = Convert.ToDouble(input.Substring(6));
            int luck_num = Convert.ToInt32((last_4_digit / 80 - (int)last_4_digit / 80) * 80);

            return getFortune(luck_num);

        }

        internal static string getFortune(int luck_num)
        {
            Dictionary<int, string> fortuneDict = new Dictionary<int, string>();
            string[] fortuneFile = File.ReadAllLines(@"C:\Users\jlsjo\Documents\RocketCamp\C-sharp-practice\sample-file\fortune.csv");
            foreach (string row in fortuneFile)
            {
                string[] fortune = row.Split(',');
                string fortuneText = fortune[1] + "\t" + fortune[2];
                fortuneDict.Add(Convert.ToInt32(fortune[0]),fortuneText);
            }

            string getText;
            bool ifGetVal = fortuneDict.TryGetValue(luck_num, out getText);

            return getText;

        }
    }
}
