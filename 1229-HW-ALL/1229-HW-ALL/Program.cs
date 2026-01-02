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
                "Function習題輸入Function-1,Function-2,...,Function-10");


            while (is_continue)
            {
                string exercise_num = Console.ReadLine();

                switch (exercise_num)
                {
                    case "6-1":
                        Console.WriteLine("6-1. 輸入姓名，輸出 Hi~輸入的姓名");
                        exerciseCH6.Exercise_1();
                        break;
                    case "6-2":
                        Console.WriteLine("6-2. 請輸入任何一個字，是否出現在"+
                            "”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡");
                        exerciseCH6.Exercise_2();
                        break;
                    case "6-3":
                        Console.WriteLine("6-3. 輸入一段字，輸出每個之間多一個-");
                        exerciseCH6.Exercise_3();
                        break;
                    case "6-4":
                        Console.WriteLine("6-4. 輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg");
                        exerciseCH6.Exercise_4();
                        break;
                    case "6-5":
                        Console.WriteLine("6-5. 輸入一個大於五個字的單字，" + 
                            "若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字");
                        exerciseCH6.Exercise_5();
                        break;
                    case "6-6":
                        Console.WriteLine("6-6. 輸入一段字，輸出把輸入的一段字裡面的我，改成小明");
                        exerciseCH6.Exercise_6();
                        break;
                    case "6-7":
                        Console.WriteLine("6-7. 輸入一串字，顯示輸入幾個字");
                        exerciseCH6.Exercise_7();
                        break;
                    case "6-extra-1":
                        Console.WriteLine("字串補充1: 連續輸入10組字，若沒輸入過，就顯示沒出現過，" +
                            "若輸入過，就顯示輸入過");
                        exerciseCH6.Extra_1();
                        break;
                    case "6-extra-2":
                        Console.WriteLine("字串補充2: 用字母大小寫來模擬波浪舞的動作後輸出");
                        exerciseCH6.Extra_2();
                        break;
                    case "6-extra-3":
                        Console.WriteLine("字串補充3: 輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分");
                        exerciseCH6.Extra_3();
                        break;
                    case "6-extra-4":
                        Console.WriteLine("字串補充4: 輸入的字，轉成HTML");
                        exerciseCH6.Extra_4();
                        break;
                    case "6-extra-5":
                        Console.WriteLine("字串補充5: 輸入5處數字，用空白隔開，輸出結果(總和)");
                        exerciseCH6.Extra_5();
                        break;
                    case "6-extra-6":
                        Console.WriteLine("字串補充6: 輸入一串文字，倒著輸出，例如輸入");
                        exerciseCH6.Extra_6();
                        break;
                    case "File-1":
                        Console.WriteLine("檔案-1. 寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。");
                        exerciseCH7.File_Exercise_1();
                        break;
                    case "File-2":
                        Console.WriteLine("檔案-2. 讀取1.txt 顯示在畫面上");
                        exerciseCH7.File_Exercise_2();
                        break;
                    case "File-extra-1":
                        Console.WriteLine("檔案補充-1. 寫入九九乘法表資料到一個文字檔");
                        exerciseCH7.File_Extra_1();
                        break;
                    case "File-extra-2":
                        Console.WriteLine("檔案補充-2. 讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，" + 
                            "轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。");
                        exerciseCH7.File_Extra_2();
                        break;
                    case "File-extra-3":
                        Console.WriteLine("檔案補充-3. 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，" + 
                            "並儲存到指定的HTML檔裡。");
                        exerciseCH7.File_Extra_3();
                        break;
                    case "Random-1":
                        Console.WriteLine("亂數-1. 請隨機由0~99產生一個數字輸出");
                        exerciseCH7.Random_Exercise_1();
                        break;
                    case "Random-2":
                        Console.WriteLine("亂數-2. 請隨機由0~99產生10個數字輸出");
                        exerciseCH7.Random_Exercise_2();
                        break;
                    case "Random-3":
                        Console.WriteLine("亂數-3. 隨機幫每位學員產生成績，並寫入文字檔" +
                            "(欄位之間用，分開，換行寫入下一筆)。");
                        exerciseCH7.Random_Exercise_3();
                        break;
                    case "Random-extra-1":
                        Console.WriteLine("亂數補充-1. 請設計樂透開獎程式");
                        exerciseCH7.Random_Extra_1();
                        break;
                    case "Rando-extra-2":
                        Console.WriteLine("亂數補充-2. 請在文字檔裡輸入所有午餐的店家，讀取文字檔，" +
                            "隨機抽出今天中午要吃哪一家");
                        exerciseCH7.Random_Extra_2();
                        break;
                    case "Random-extra-3":
                        Console.WriteLine("亂數補充-3. 請在文字檔裡輸入所有教室裡的學員名字，" +
                            "讀取文字檔，隨機抽出今天的值日生，抽過不能再被抽中，" + 
                            "直到全部學員都被抽過，才可以再被抽。");
                        exerciseCH7.Random_Extra_3();
                        break;
                    case "Date-1":
                        Console.WriteLine("日期-1. 顯示現在日期與時間");
                        exerciseCH7.DT_Exercise_1();
                        break;
                    case "Date-2":
                        Console.WriteLine("日期-2. 顯示再過30天為哪一天");
                        exerciseCH7.DT_Exercise_2();
                        break;
                    case "Date-3":
                        Console.WriteLine("日期-3. 顯示24小時前的年月日時分秒");
                        exerciseCH7.DT_Exercise_3();
                        break;
                    case "Date-4":
                        Console.WriteLine("日期-4. 取得目前是幾月");
                        exerciseCH7.DT_Exercise_4();
                        break;
                    case "Date-5":
                        Console.WriteLine("日期-5. 取得明年是否為閏年。(可以試試民國)");
                        exerciseCH7.DT_Exercise_5();
                        break;
                    case "Date-6":
                        Console.WriteLine("日期-6. 取得離2025年1月1日還有幾天");
                        exerciseCH7.DT_Exercise_6();
                        break;
                    case "Date-extra-1":
                        Console.WriteLine("日期補充-1. 星期一，猴子穿新衣，\n" +
                            "星期二，猴子肚子餓，\n" +
                            "星期三，猴子去爬山，\n" +
                            "星期四，猴子看電視，\n" +
                            "呈期五，猴子去跳舞，\n" +
                            "星期六，猴子去斗六，\n" +
                            "星期日，猴子過生日。\n" +
                            "請顯示今天猴子做甚麼事");
                        exerciseCH7.DT_Extra_1();
                        break;
                    case "Date-extra-2":
                        Console.WriteLine("日期補充-2. 輸入兩個日期，輸出兩個日期相差幾天。");
                        exerciseCH7.DT_Extra_2();
                        break;
                    case "Date-extra-3":
                        Console.WriteLine("日期補充-3. 隨機產生一個今年日期，然後依照下面的公式\n" +
                            "M=月 D=日 S=(M*2+D)%3\n" +
                            "得到S的值，再依照S的值從0到2分別給與普通、吉、大吉等三種不同的運勢\n" +
                            "輸出運勢");
                        exerciseCH7.DT_Extra_3();
                        break;
                    case "Function-1":
                        Console.WriteLine("Function-1. 寫一個function 可以把一般對話框的文字轉成HTML");
                        Console.WriteLine("請輸入文字");
                        string text = Console.ReadLine();
                        Console.WriteLine("請輸入HTML存入位置");
                        string path = Console.ReadLine();
                        exerciseFunction.toHTML(text, path);
                        break;
                    case "Function-2":
                        Console.WriteLine("Function-2. 寫一個function，回傳輸入的值是否數字");
                        bool is_num = exerciseFunction.isNum(exerciseFunction.getInput());
                        if (is_num)
                        {
                            Console.WriteLine("輸入的值是數字");
                        }
                        else
                        {
                            Console.WriteLine("輸入的值不是數字");
                        }
                            break;
                    case "Function-3":
                        Console.WriteLine("Function-3. 寫一個function，回傳輸入的值是否符合E-mail格式");
                        bool is_email = exerciseFunction.isEmail(exerciseFunction.getInput());
                        if (is_email)
                        {
                            Console.WriteLine("輸入的值符合Email格式");
                        }
                        else
                        {
                            Console.WriteLine("輸入的值不符合Email格式");
                        }
                            break;
                    case "Function-4":
                        Console.WriteLine("Function-4. 寫一個function，回傳輸入的值是否符合手機格式");
                        bool is_mobile = exerciseFunction.isMobile(exerciseFunction.getInput());

                        if (is_mobile)
                        {
                            Console.WriteLine("輸入的值符合手機格式");
                        }
                        else
                        {
                            Console.WriteLine("輸入的值不符合手機格式");
                        }
                            break;
                    case "Function-5":
                        Console.WriteLine("Function-5. 寫一個function，回傳輸入的值是否符合身分證字號格式");
                        bool is_id_card = exerciseFunction.isIDCard(exerciseFunction.getInput());

                        if (is_id_card)
                        {
                            Console.WriteLine("輸入的值符合身分證字號格式");
                        }
                        else
                        {
                            Console.WriteLine("輸入的值不符合身分證字號格式");
                        }
                            break;
                    case "Function-6":
                        Console.WriteLine("Function-6. 寫一個function，若輸入的文字大於N個，" +
                            "則超過的字不要，變成點點點");
                        Console.WriteLine("輸入N");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("輸入文字");
                        string input_f6 = Console.ReadLine();
                        Console.WriteLine("輸出結果為" + exerciseFunction.textIgnore(input_f6,n));
                        break;
                    case "Function-7":
                        Console.WriteLine("Function-7. 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式");
                        Console.WriteLine("輸入日期(格式: 年/月/日 或 年-月-日)");
                        string input_f7 = Console.ReadLine();
                        if (input_f7.Contains("/"))
                        {
                            Console.WriteLine(exerciseFunction.dateToTaiwanCal(input_f7,'/'));
                        }
                        else if (input_f7.Contains("-"))
                        {
                            Console.WriteLine(exerciseFunction.dateToTaiwanCal(input_f7,'-'));
                        }
                        else
                        {
                            Console.WriteLine("日期格式輸入錯誤，結束執行Function-7");
                        }

                            break;
                    case "Function-8":
                        Console.WriteLine("Function-8. 寫一個function，輸入一個日期，" +
                            "把該日期轉成民國XX年XX月XX日 星期X");
                        Console.WriteLine("輸入日期(格式: 年/月/日 或 年-月-日)");
                        string input_f8 = Console.ReadLine();
                        if (input_f8.Contains("/"))
                        {
                            Console.WriteLine(exerciseFunction.dateToTaiwanCalwWeekDay(input_f8, '/'));
                        }
                        else if (input_f8.Contains("-"))
                        {
                            Console.WriteLine(exerciseFunction.dateToTaiwanCalwWeekDay(input_f8, '-'));
                        }
                        else
                        {
                            Console.WriteLine("日期格式輸入錯誤，結束執行Function-8");
                        }
                            break;
                    case "Function-9":
                        Console.WriteLine("Function-9. 寫一個function，回傳輸入的年是否閏年");
                        bool is_leap = exerciseFunction.isLeap(exerciseFunction.getInput());
                        if (is_leap)
                        {
                            Console.WriteLine("輸入的年是閏年");
                        }
                        else
                        {
                            Console.WriteLine("輸入的年不是閏年");
                        }
                            break;
                    case "Function-10":
                        Console.WriteLine("Function-10. 寫一個function，輸入手機號碼，回傳今天運勢");
                        double luck_num = exerciseFunction.getLuck(exerciseFunction.getInput());

                        if (luck_num == 0)
                        {
                            Console.WriteLine("輸入的值不符合手機格式");
                        }
                        else
                        {
                            Console.WriteLine($"今日運勢數字為{luck_num}");
                        }
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
