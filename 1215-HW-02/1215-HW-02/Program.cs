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
            bonus_2();
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
            double sum = 0;

            Console.WriteLine("3-6.寫一程式，輸入N個數字，求其所有正數之平方的加總");
            Console.WriteLine("請輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"輸入第{i+1}個數字");
                
                double input = Convert.ToDouble(Console.ReadLine());

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

        //CH3 補充1
        static void ch3_extra_1()
        {
            var prime_test = new List<int> {5, 7, 11, 13 };
            int test_len = prime_test.Count;
            var prime_num = new List<int>();

            Console.WriteLine("1.判斷101-200之間有多少個質數，並輸出所有質數");

            for (int i = 101; i < 201; i++)
            {
                bool is_prime = true;
                if (i % 2 == 0 | i%3 == 0)
                {
                    continue;
                }
                for(int j = 0; j< test_len; j++)
                {
                    if (i % prime_test[j] == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }
                if( is_prime == true)
                {
                    prime_num.Add(i);
                }
            }

            Console.Write("101-200之間的質數有:");
            for (int i = 0; i < prime_num.Count; i++)
            {
                if (i == prime_num.Count - 1)
                {
                    Console.Write($"{prime_num[i]}\n");
                }
                else
                {
                    Console.Write($"{prime_num[i]},");
                }
            }
        }

        //補充2
        static void ch3_extra_2()
        {
            int input;
            var prime_factor = new List<int>();

            Console.WriteLine("2.輸入一個數，輸出其質因數");
            Console.WriteLine("請輸入數字");
            input = Convert.ToInt32(Console.ReadLine());
            int original_num = input;

            for (int i = 2; i <= input; i++)
            {
                if(input % i == 0 && input > 0)
                {
                    prime_factor.Add(i);
                }
                while(input % i ==0 && input > 0)
                {
                    input = input / i;
                }
            }


            Console.Write($"{original_num}的質因數為:");
            for(int i = 0; i < prime_factor.Count; i++)
            {
                if (i == prime_factor.Count - 1)
                {
                    Console.Write($"{prime_factor[i]}\n");
                }
                else
                {
                    Console.Write($"{prime_factor[i]},");
                }
            }
        }

        //補充3
        static void ch3_extra_3()
        {
            int count = 0;

            Console.WriteLine("3.求100到300中可以被3與7整除的個數");

            for (int i = 100; i < 301; i++)
            {
                if (i%3==0 & i % 7 == 0)
                {
                    count += 1;
                }
            }

            Console.WriteLine($"100到300中可以被3與7整除的個數有{count}個");
        }

        //ch3作業改while寫法

        //3-1
        static void ch3_3_1_while()
        {
            int min = int.MaxValue;
            int idx = 0;

            Console.WriteLine("3-1.用while寫一程式，輸入10個整數，求其最小值");

            while (idx < 10)
            {
                Console.WriteLine($"輸入第{idx+1}個數字");
                int input = Convert.ToInt32(Console.ReadLine());
                if(input < min)
                {
                    min = input;
                }
                idx += 1;
            }

            Console.WriteLine($"最小值為{min}");
        }

        //3-2
        static void ch3_3_2_while()
        {
            int n;
            int idx = 0;
            int min = int.MaxValue;

            Console.WriteLine("3-2.寫一程式，輸入N個整數，求其最小值");
            Console.WriteLine("請輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            while (idx < n)
            {
                Console.WriteLine($"請輸入第{idx + 1}個數字");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input < min)
                {
                    min = input;
                }

                idx += 1;
            }

            Console.WriteLine($"最小值為{min}");
        }

        //3-3
        static void ch3_3_3_while()
        {
            var over_12 = new List<int>();
            int idx = 0;

            Console.WriteLine("3-3.寫一程式，輸入10個整數，列出其中所有大於12的數字");

            while( idx < 10)
            {
                Console.WriteLine($"輸入第{idx + 1}個數");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input > 12)
                {
                    over_12.Add(input);
                }

                idx += 1;
            }

            Console.Write("大於12的數字為:");
            over_12.ForEach(i => Console.Write($"{i} "));
        }

        //3-4
        static void ch3_3_4_while()
        {
            int sum = 0;
            int idx = 0;

            Console.WriteLine("3-4.寫一程式，輸入10個整數，列出其中所有大於12的數字的總和");

            while (idx < 10)
            {
                Console.WriteLine($"輸入第{idx + 1}個數字");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input > 12)
                {
                    sum += input;
                }

                idx += 1;
            }

            Console.WriteLine($"大於12的數字的總和為{sum}");
        }

        //3-5
        static void ch3_3_5_while()
        {
            int n;
            int max = int.MinValue;
            int idx = 0;

            Console.WriteLine("3-5.寫一程式，輸入N個數字，求其所有奇數中的最大值");
            Console.WriteLine("請輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            while (idx < n)
            {
                Console.WriteLine($"請輸入第{idx + 1}個數字");
                int input = Convert.ToInt32(Console.ReadLine());

                if (Math.Abs(input % 2) == 1 & input > max)
                {
                    max = input;
                }

                idx += 1;
            }

            if (max > int.MinValue)
            {
                Console.WriteLine($"所有奇數中的最大值為{max}");
            }
            else
            {
                Console.WriteLine("輸入值無奇數");
            }
        }

        //3-6
        static void ch3_3_6_while()
        {
            int n;
            int idx = 0;
            double sum = 0;

            Console.WriteLine("3-6.寫一程式，輸入N個數字，求其所有正數之平方的加總");
            Console.WriteLine("輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            while (idx < n)
            {
                Console.WriteLine($"請輸入第{idx+1}個值");
                double input = Convert.ToDouble(Console.ReadLine());

                if (input > 0)
                {
                    sum += input * input;
                }

                idx += 1;
            }

            Console.WriteLine($"所有正數平方的總和為{sum}");
        }

        //3-7
        static void ch3_3_7_while()
        {
            int n;
            int idx = 0;
            var old_list = new List<double>();
            var new_list = new List<double>();


            Console.WriteLine("3-7.寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數");
            Console.WriteLine("輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            while(idx < n)
            {
                Console.WriteLine($"輸入第{idx + 1}個數");
                double input = Convert.ToDouble(Console.ReadLine());

                old_list.Add(input);
                new_list.Add(Math.Abs(input));

                idx += 1;
            }

            Console.Write("原輸入數字為:");
            old_list.ForEach(i => Console.Write($"{i} "));
            Console.Write("\n負數轉為正數後為:");
            new_list.ForEach(i => Console.Write($"{i} "));
        }

        //ch3 補充習題改while

        //1
        static void ch3_extra_1_while()
        {
            var prime_test = new List<int> { 5, 7, 11, 13 };
            int test_len = prime_test.Count;
            var prime_num = new List<int>();

            int num = 101;

            Console.WriteLine("1.判斷101-200之間有多少個質數，並輸出所有質數");

            while (num <= 200)
            {
                int j = 0;
                bool is_prime = true;

                if (num %2 == 0 | num % 3 == 0)
                {
                    num += 1;
                    continue;
                }
                while(j < test_len)
                {
                    if(num % prime_test[j] == 0)
                    {
                        is_prime = false;
                        j += 1;
                        break;
                    }
                    j += 1;
                }

                if(is_prime == true)
                {
                    prime_num.Add(num);
                }

                num += 1;
            }

            Console.Write("101-200間的所有質數為:");
            int idx = 0;
            while (idx < prime_num.Count)
            {
                if (idx == prime_num.Count - 1)
                {
                    Console.Write($"{prime_num[idx]}\n");
                }
                else
                {
                    Console.Write($"{prime_num[idx]},");
                }

                idx += 1;
            }
        }

        //2
        static void ch3_extra_2_while()
        {
            int input;
            int start = 2;
            int original;
            var prime_factor = new List<int>();

            Console.WriteLine("2.輸入一個數，輸出其質因數");
            Console.WriteLine("輸入數字");
            input = Convert.ToInt32(Console.ReadLine());
            original = input;

            while(start <= input)
            {
                if (input % start == 0 & input > 0)
                {
                    prime_factor.Add(start);
                }
                while(input % start == 0 & input > 0)
                {
                    input = input / start;
                }
                start += 1;
            }

            Console.Write($"{original}的質因數為:");
            int idx = 0;
            while (idx < prime_factor.Count)
            {
                if(idx == prime_factor.Count - 1)
                {
                    Console.Write($"{prime_factor[idx]}\n");
                }
                else
                {
                    Console.Write($"{prime_factor[idx]},");
                }

                idx += 1;
            }

        }

        //3
        static void ch3_extra_3_while()
        {
            int count = 0;
            int num = 100;

            Console.WriteLine("3.求100到300中可以被3與7整除的個數");

            while (num <= 300)
            {
                if (num %3 == 0 & num % 7 == 0)
                {
                    count += 1;
                }

                num += 1;
            }

            Console.WriteLine($"100到300可以被3與7整除的個數為{count}");
        }

        //ch4

        //4-1
        static void ch4_4_1()
        {
            int n;
            double max = double.MinValue;
            int idx = 0;

            Console.WriteLine("4-1.利用while寫一程式求N個數字的最大值");
            Console.WriteLine("輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            while (idx < n)
            {
                Console.WriteLine($"輸入第{idx + 1}個數字");
                double input = Convert.ToDouble(Console.ReadLine());

                if (input > max)
                {
                    max = input;
                }

                idx += 1;
            }

            Console.WriteLine($"最大值為{max}");
        }

        //4-2
        static void ch4_4_2()
        {
            int n, idx = 0;
            double start, interval, sum=0;

            Console.WriteLine("4-2.利用while寫一程式求一個等差級數數字的和，一共有N個數字");
            Console.WriteLine("輸入N");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入最小起始值");
            start = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入間格差");
            interval = Convert.ToDouble(Console.ReadLine());

            while (idx < n)
            {
                sum += start;
                start += interval;

                idx += 1;
            }

            Console.WriteLine($"等差級數數字的和為{sum}");
        }

        static void ch4_4_3()
        {
            int n, idx = 0;
            double sum = 0;

            Console.WriteLine("4-3.利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和。");
            Console.WriteLine("輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            while (idx < n)
            {
                Console.WriteLine($"輸入第{idx + 1}個數");
                double input = Convert.ToDouble(Console.ReadLine());

                if( input < 13)
                {
                    sum += input;
                }

                idx += 1;
            }

            Console.WriteLine($"小於13的數字的和為{sum}");
        }

        //4-4
        static void ch4_4_4()
        {
            int n, idx=0;

            Console.WriteLine("4-4.利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字");
            Console.WriteLine("輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            while ( idx < n)
            {
                Console.WriteLine($"輸入第{idx + 1}個數字");
                double input = Convert.ToDouble(Console.ReadLine());

                if (input > 7 & input < 10)
                {
                    Console.WriteLine($"第一個大於7且小於10的數為{input}");
                    return;
                }

                idx += 1;
            }

            Console.WriteLine("沒有輸入大於7且小於10的數字");
        }

        //4-5
        static void ch4_4_5()
        {
            int idx = 0;

            Console.WriteLine("4-5.利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai>bi，即停止，並列印出ai及bi。");

            while (idx < 5)
            {
                double a, b;

                Console.WriteLine($"輸入a{idx + 1}");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"輸入b{idx + 1}");
                b = Convert.ToDouble(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine($"找到第一個a > b: a{idx+1} = {a}, b{idx + 1}= {b}");
                    return;
                }

                idx += 1;
            }

            Console.WriteLine("沒有任何ai > bi");
        }

        //ch4 補充題目
        
        //1
        static void ch4_extra_1()
        {
            int idx = 0, time;

            Console.WriteLine("1.Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。");
            Console.WriteLine("輸入時間(分鐘)");
            time = Convert.ToInt32(Console.ReadLine());

            int count = time / 5;

            while( idx <= count)
            {
                Console.WriteLine($"第{idx * 5}分鐘吃第{idx+1}個漢堡");
                idx += 1;
            }
        }

        //2
        static void ch4_extra_2()
        {
            int idx = 0, cost = 560;

            Console.WriteLine("2.小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。");

            while (cost > 0)
            {
                idx += 1;
                cost -= 4;
                if (idx % 12 == 0)
                {
                    cost -= 1;
                }

                //Console.WriteLine($"第{idx}個月 小明還有{cost}萬貸款");

                
            }

            Console.WriteLine($"小明貸款需要{idx}個月還清");
        }

        //3
        static void ch4_extra_3()
        {
            var rand = new Random();

            int random_num = rand.Next();

            Console.WriteLine("3.系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，猜錯時，要提示是比較大還是比較小。");
            Console.WriteLine("輸入一個數字");
            int guess = Convert.ToInt32(Console.ReadLine());

            while(guess != random_num)
            {
                if (guess > random_num)
                {
                    Console.WriteLine("隨機數字比較小");
                }
                else if (guess < random_num)
                {
                    Console.WriteLine("隨機數字比較大");
                }

                Console.WriteLine("再猜一次，請再輸入一個數字");
                guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"猜中!隨機數字為{random_num}");


        }

        //Bonus題

        //bonus 1
        static void bonus_1()
        {
            int n;
            string icon;

            Console.WriteLine("客製化的聖誕樹");
            Console.WriteLine("請問要建立多高的聖誕樹");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入聖誕樹要顯示的符號");
            icon = Console.ReadLine();
            Console.WriteLine("開始建立聖誕樹.....");

            for (int i = 0; i < n; i++)
            {

                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < (2 * i + 1); j++)
                {
                    Console.Write($"{icon}");
                }

                Console.WriteLine();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        Console.Write($"{icon}\n");
                    }
                    else
                    {
                        Console.Write($"{icon}");
                    }
                    
                }
                
            }

            Console.WriteLine("聖誕樹建立完成.....");
            Console.WriteLine("請按任意鍵繼續");
            Console.ReadKey();

        }

        //bonus 2
        static void bonus_2()
        {
            int n;
            Console.WriteLine("用遞迴(Recursion)方式寫出費波那契數列：輸入整數N，輸出fibonacci(N) [費氏數列的第N個數]");
            Console.WriteLine("輸入N");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"費式數列的第{n}個數為{Fibonacci(n)}");
        }

        static int Fibonacci(int n)
        {
            if (n == 0 | n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n-1) + Fibonacci(n - 2);
            }
        }
    }
}