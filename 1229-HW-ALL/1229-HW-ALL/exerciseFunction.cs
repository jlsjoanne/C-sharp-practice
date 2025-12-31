using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _1229_HW_ALL
{
    internal class exerciseFunction
    {

        //Function題目
        //題目一
        //寫一個function 可以把一般對話框的文字轉成HTML

        //題目二
        //寫一個function，回傳輸入的值是否數字
        internal static bool Exercise_2(string input)
        {
            int num;
            bool is_int = int.TryParse(input, out num);

            return is_int;

        }

        //題目三
        //寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
        internal static bool Exercise_3(string input)
        {
            string email_syntax = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";

            bool is_email = Regex.IsMatch(input, email_syntax);

            return is_email;
        }
    }
}
