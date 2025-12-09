using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1208_HW_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            string if_cont_exe = "Y";


            while (if_cont_exe == "Y")
            {
                //declare variable inside while
                string practice_num;

                Console.WriteLine("請輸入習題編號\n" +
                "第一章習題請輸入1-1,1-2,...,1-8\n" +
                "第二章習題請輸入2-1,2-2,...,2-7\n" +
                "第二章補充習題請輸入extra-1,extra-2,extra-3,extra-4");

                practice_num = Console.ReadLine();


                //switch (practice_num)
                //{
                //    case "1-1":
                //        CH1_1();
                //        break;
                //    case "1-2":
                //        CH1_2();
                //        break;
                //    case "1-3":
                //        CH1_3();
                //        break;
                //    case "1-4":
                //        CH1_4();
                //        break;
                //    case "1-5":
                //        CH1_5();
                //        break;
                //    case "1-6":
                //        CH1_6();
                //        break;
                //    case "1-7":
                //        CH1_7();
                //        break;
                //    case "1-8":
                //        CH1_8();
                //        break;
                //    case "2-1":
                //        CH2_1();
                //        break;
                //    case "2-2":
                //        CH2_2();
                //        break;
                //    case "2-3":
                //        CH2_3();
                //        break;
                //    case "2-4":
                //        CH2_4();
                //        break;
                //    case "2-5":
                //        CH2_5();
                //        break;
                //    case "2-6":
                //        CH2_6();
                //        break;
                //    case "2-7":
                //        CH2_7();
                //        break;
                //    case "extra-1":
                //        CH2_extra_1();
                //        break;
                //    case "extra-2":
                //        CH2_extra_2();
                //        break;
                //    case "extra-3":
                //        CH2_extra_3();
                //        break;
                //    case "extra-4":
                //        CH2_extra_4();
                //        break;
                //    default:
                //        Console.WriteLine("輸入錯誤值");
                //        break;
                //}

                Console.WriteLine("是否繼續輸入(Y/N)");
                if_cont_exe = Console.ReadLine();
                if (if_cont_exe == "N")
                {
                    Console.WriteLine("結束程式");
                }
                else if (if_cont_exe != "Y")
                {
                    Console.WriteLine("輸入錯誤值 結束程式");
                }
            }

            Console.ReadKey();


        }

        ////習題

        ////CH1
        ////1-1
        //static void CH1_1()
        //{
        //    //declare variables
        //    double a, b, c, d;
        //    double result;

        //    //input a,b,c,d
        //    Console.WriteLine("input a");
        //    a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input b");
        //    b = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input c");
        //    c = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input d");
        //    d = Convert.ToDouble(Console.ReadLine());

        //    //calculate result
        //    result = (a + b) / (c - d) * 2;

        //    //show result
        //    Console.WriteLine($"The Result of (a+b)/(c-d) * 2 is {result}");
        //}

        ////1-2
        //static void CH1_2()
        //{
        //    //declare variables
        //    double a1, a2, b1, b2, c1, c2;
        //    double x, y;
        //    Console.WriteLine("Input a1");
        //    a1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Input a2");
        //    a2 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Input b1");
        //    b1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Input b2");
        //    b2 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Input c1");
        //    c1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Input c2");
        //    c2 = Convert.ToDouble(Console.ReadLine());

        //    //calculate x and y
        //    x = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
        //    y = (c1 * a2 - c2 * a1) / (b1 * a2 - a1 * b2);

        //    //show result
        //    Console.WriteLine($"x is {x}\ny is {y}");
        //}

        ////1-3
        //static void CH1_3()
        //{
        //    //declare variables
        //    double a, b, y;

        //    //input a,b
        //    Console.WriteLine("Input a");
        //    a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Input b");
        //    b = Convert.ToDouble(Console.ReadLine());


        //    //calculate y
        //    y = (Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2));

        //    //show result
        //    Console.WriteLine($"y is {y}");
        //}

        ////1-4
        //static void CH1_4()
        //{
        //    //declare variables
        //    double a, b, y;

        //    //input a,b
        //    Console.WriteLine("Input a");
        //    a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Input b");
        //    b = Convert.ToDouble(Console.ReadLine());

        //    //calculate y
        //    y = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        //    //show result
        //    Console.WriteLine($"y is {y}");
        //}

        ////1-5
        //static void CH1_5()
        //{
        //    //declare variables
        //    double a, b, c, y;

        //    //input a,b,c
        //    Console.WriteLine("input a");
        //    a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input b");
        //    b = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input c");
        //    c = Convert.ToDouble(Console.ReadLine());

        //    //calculate y
        //    y = a - (b + c) * (3 * a - c);

        //    //show result
        //    Console.WriteLine($"y is {y}");
        //}

        ////1-6
        //static void CH1_6()
        //{
        //    //declare variables
        //    double x;

        //    //input value
        //    Console.WriteLine("input value");
        //    x = Convert.ToDouble(Console.ReadLine());

        //    //show result
        //    Console.WriteLine($"The absolute value of input is {Math.Abs(x)}");
        //}

        ////1-7
        //static void CH1_7()
        //{
        //    //declare variable
        //    int year;

        //    //input year
        //    Console.WriteLine("輸入西元年");
        //    year = Convert.ToInt32(Console.ReadLine());

        //    //Calculate and show 民國年
        //    if (year > 1911)
        //    {
        //        Console.WriteLine($"西元{year}年 = 民國{year - 1911}年");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"西元{year}年 = 民國前{1912 - year}年");
        //    }
        //}

        ////1-8
        //static void CH1_8()
        //{
        //    //declare variables
        //    double height, weight, BMI;

        //    //input height and weight
        //    Console.WriteLine("請輸入身高(cm)");
        //    height = Convert.ToDouble(Console.ReadLine()) / 100;
        //    Console.WriteLine("請輸入體重(kg)");
        //    weight = Convert.ToDouble(Console.ReadLine());

        //    //calculate BMI
        //    BMI = weight / Math.Pow(height, 2);

        //    //show result
        //    Console.WriteLine($"BMI is {BMI}");
        //}

        ////CH2

        ////2-1
        //static void CH2_1()
        //{
        //    //declare variables
        //    double x, y;

        //    //input x,y
        //    Console.WriteLine("input x");
        //    x = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input y");
        //    y = Convert.ToDouble(Console.ReadLine());

        //    //compare
        //    if (x >= y)
        //    {
        //        Console.WriteLine($"result is {x}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"result us {y}");
        //    }
        //}

        ////2-2
        //static void CH2_2()
        //{
        //    //declare variables
        //    double x, y;
        //    int z;

        //    //input x and y
        //    Console.WriteLine("input x");
        //    x = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input y");
        //    y = Convert.ToDouble(Console.ReadLine());

        //    //get z
        //    if (x > 0 & y > 0)
        //    {
        //        z = 1;
        //    }
        //    else if (x < 0 & y < 0)
        //    {
        //        z = -1;
        //    }
        //    else
        //    {
        //        z = 0;
        //    }

        //    //show result
        //    Console.WriteLine($"z is {z}");
        //}

        ////2-3
        //static void CH2_3()
        //{
        //    //declare variables
        //    double x, y, u, v, z;

        //    //input x,y,u,v
        //    Console.WriteLine("input x");
        //    x = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input y");
        //    y = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input u");
        //    u = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input v");
        //    v = Convert.ToDouble(Console.ReadLine());

        //    //compare and get z
        //    if ((x + y) > (u + v))
        //    {
        //        z = x + y;
        //    }
        //    else
        //    {
        //        z = u + v;
        //    }

        //    Console.WriteLine($"z is {z}");
        //}

        ////2-4
        //static void CH2_4()
        //{
        //    //declare variables
        //    double x, y, u, v, z;

        //    //input x,y,u,v
        //    Console.WriteLine("input x");
        //    x = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input y");
        //    y = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input u");
        //    u = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input v");
        //    v = Convert.ToDouble(Console.ReadLine());

        //    //compare and get z

        //    if ((x + y) / (u + v) >= 2)
        //    {
        //        z = x + y;
        //    }
        //    else
        //    {
        //        z = u + v;
        //    }

        //    //show result
        //    Console.WriteLine($"z is {z}");
        //}

        ////2-5
        //static void CH2_5()
        //{
        //    //declare variables
        //    double x, y, z;

        //    //input x,y
        //    Console.WriteLine("input x");
        //    x = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input y");
        //    y = Convert.ToDouble(Console.ReadLine());

        //    //compare and get z

        //    if (x >= y)
        //    {
        //        z = Math.Pow(x, 2);
        //    }
        //    else
        //    {
        //        z = Math.Pow(y, 2);
        //    }

        //    //show result
        //    Console.WriteLine($"z is {z}");
        //}

        ////2-6
        //static void CH2_6()
        //{
        //    //declare variables
        //    double income, rate, difference, tax;

        //    //input income
        //    Console.WriteLine("Input Income");
        //    income = Convert.ToDouble(Console.ReadLine());

        //    if (income > 4090000)
        //    {
        //        rate = 0.4;
        //        difference = 721100;
        //    }
        //    else if (income > 2180000)
        //    {
        //        rate = 0.3;
        //        difference = 312100;
        //    }
        //    else if (income > 1090000)
        //    {
        //        rate = 0.21;
        //        difference = 115900;
        //    }
        //    else if (income > 410000)
        //    {
        //        rate = 0.13;
        //        difference = 28700;
        //    }
        //    else
        //    {
        //        rate = 0.06;
        //        difference = 0;
        //    }

        //    tax = (income * rate) - difference;

        //    //output tax
        //    Console.WriteLine($"tax is {tax}");
        //}

        ////2-7
        //static void CH2_7()
        //{
        //    //declare variables
        //    double x, y;

        //    //input x,y
        //    Console.WriteLine("input x");
        //    x = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("input y");
        //    y = Convert.ToDouble(Console.ReadLine());

        //    //check position
        //    if (x > 0)
        //    {
        //        if (y > 0)
        //        {
        //            Console.WriteLine("1st quadrant\n");
        //        }
        //        else if (y == 0)
        //        {
        //            Console.WriteLine("X-axis\n");
        //        }
        //        else
        //        {
        //            Console.WriteLine("4th quadrant");
        //        }
        //    }
        //    else if (x == 0)
        //    {
        //        if (y == 0)
        //        {
        //            Console.WriteLine("Origin\n");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Y-axis\n");
        //        }
        //    }
        //    else
        //    {
        //        if (y > 0)
        //        {
        //            Console.WriteLine("2nd quadrant\n");
        //        }
        //        else if (y == 0)
        //        {
        //            Console.WriteLine("X-axis\n");
        //        }
        //        else
        //        {
        //            Console.WriteLine("3th quadrant\n");
        //        }
        //    }
        //}

        ////補充習題

        ////補1
        //static void CH2_extra_1()
        //{
        //    //declare variables
        //    int correct_num, score = 0, remain = 0;

        //    //input score
        //    Console.WriteLine("請輸入答對題數");
        //    correct_num = Convert.ToInt32(Console.ReadLine());

        //    //calculate
        //    if (correct_num < 0)
        //    {
        //        Console.WriteLine("Wrong Input!");
        //        Console.ReadKey();
        //    }
        //    else if (correct_num <= 10)
        //    {
        //        score = correct_num * 6;
        //    }
        //    else if (correct_num <= 20)
        //    {
        //        remain = correct_num - 10;
        //        score = 10 * 6 + remain * 2;
        //    }
        //    else if (correct_num <= 40)
        //    {
        //        remain = correct_num - 20;
        //        score = 10 * 6 + 10 * 2 + remain;
        //    }
        //    else
        //    {
        //        score = 100;
        //    }

        //    Console.WriteLine($"分數為{score}");
        //}

        ////補2
        //static void CH2_extra_2()
        //{
        //    //declare variables
        //    double height, weight, BMI;

        //    //input height, weight
        //    Console.WriteLine("請輸入身高(cm)");
        //    height = Convert.ToDouble(Console.ReadLine()) / 100;
        //    Console.WriteLine("請輸入體重(kg)");
        //    weight = Convert.ToDouble(Console.ReadLine());

        //    //calculate BMI
        //    BMI = weight / Math.Pow(height, 2);

        //    //get result
        //    if (BMI < 18.5)
        //    {
        //        Console.WriteLine($"BMI = {BMI} 體重過輕");
        //    }
        //    else if (BMI < 24)
        //    {
        //        Console.WriteLine($"BMI = {BMI} 體重正常");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"BMI = {BMI} 體重過重");
        //    }
        //}

        ////補3
        //static void CH2_extra_3()
        //{
        //    //declare variables
        //    double a, b, c, temp = 0;

        //    //input number
        //    Console.WriteLine("輸入第1個數字");
        //    a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("輸入第2個數字");
        //    b = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("輸入第3個數字");
        //    c = Convert.ToDouble(Console.ReadLine());

        //    //compare
        //    if (a < b)
        //    {
        //        temp = a;
        //        a = b;
        //        b = temp;
        //        if (b < c)
        //        {
        //            temp = b;
        //            b = c;
        //            c = temp;
        //            if (a < b)
        //            {
        //                temp = a;
        //                a = b;
        //                b = temp;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if(b < c)
        //        {
        //            temp = b;
        //            b = c;
        //            c = temp;
        //            if(a < b)
        //            {
        //                temp = a;
        //                a = b;
        //                b = temp;
        //            }
        //        }
        //    }

        //    //output sorted result

        //    Console.WriteLine($"From Max to Min: {a},{b},{c}");
        //}

        ////補4
        //static void CH2_extra_4()
        //{
        //    //declare variables
        //    double profit, bonus, extra = 0;

        //    //input profit
        //    Console.WriteLine("輸入當月利潤");
        //    profit = Convert.ToDouble(Console.ReadLine());

        //    //calculate bonus
        //    if (profit <= 100000)
        //    {
        //        bonus = profit * 0.1;
        //    }
        //    else if (profit <= 200000)
        //    {
        //        extra = profit - 100000;
        //        bonus = 100000 * 0.1 + extra * 0.075;
        //    }
        //    else if (profit <= 400000)
        //    {
        //        extra = profit - 200000;
        //        bonus = 100000 * (0.1 + 0.075) + extra * 0.05;
        //    }
        //    else if (profit <= 600000)
        //    {
        //        extra = profit - 400000;
        //        bonus = 100000 * (0.1 + 0.075) + 200000 * 0.05 + extra * 0.03;
        //    }
        //    else if (profit <= 1000000)
        //    {
        //        extra = profit - 600000;
        //        bonus = 100000 * (0.1 + 0.075) + 200000 * (0.05 + 0.03) + extra * 0.015;
        //    }
        //    else
        //    {
        //        extra = profit - 1000000;
        //        bonus = 100000 * (0.1 + 0.075) + 200000 * (0.05 + 0.03) + 400000 * 0.015 + extra * 0.01;
        //    }

        //    //output bonus
        //    Console.WriteLine($"發放獎金總數為{bonus}");
        //}
    }
}
