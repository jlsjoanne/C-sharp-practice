using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_22_HW_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exercise_no;
            
            Console.WriteLine("輸入習題編號 5-1,5-2,....,5-7");
            exercise_no = Console.ReadLine();

            switch (exercise_no)
            {
                case "5-1":
                    ch5_5_1();
                    break;
                case "5-2":
                    ch5_5_2();
                    break;
                case "5-3":
                    ch5_5_3();
                    break;
                case "5-4":
                    ch5_5_4();
                    break;
                case "5-5":
                    ch5_5_5();
                    break;
                case "5-6":
                    ch5_5_6();
                    break;
                case "5-7":
                    ch5_5_7();
                    break;
                default:
                    Console.WriteLine("輸入錯誤");
                    break;
            }

            Console.ReadKey();

        }

        //ch5
        //5_1
        static void ch5_5_1()
        {
            int[] arr = new int[10];

            Console.WriteLine("5-1.寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，如A[i]>5，則令A[i]=A[i]-5，否則A[i]=A[i]+5");


            for (int i= 0;i < arr.Length; i++)
            {
                Console.WriteLine($"輸入第{i+1}個數字");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] > 5)
                {
                    arr[i] -= 5;
                }
                else
                {
                    arr[i] += 5;
                }
            }

            Console.Write("計算結果為: ");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

        }

        //5-2
        static void ch5_5_2()
        {
            int[] arr = new int[10];

            Console.WriteLine("5-2.寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i]=A[i]+i");
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"輸入第{i + 1}個數字");

                if (i == 0)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine()) + arr[i - 1];
                }
            }

            Console.WriteLine("結果為:");
            for (int i = 0; i < arr.Length; i ++)
            {
                Console.WriteLine($"A{i} = {arr[i]}");
            }
        }

        //5-3
        static void ch5_5_3()
        {
            //create variables
            int[] A = new int[10];
            int[] B = new int[10];

            Console.WriteLine("5-3.寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]>=0，令B[i]=1，否則令B[i]=0");

            //input number
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"輸入第{i + 1}個數字");
                A[i] = Convert.ToInt32(Console.ReadLine());

                if (A[i] >= 0)
                {
                    B[i] = 1;
                }
                else
                {
                    B[i] = 0;
                }
            }

            Console.WriteLine("結果為");
            Console.WriteLine("i\tA[i]\tB[i]");

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"{i}\t{A[i]}\t{B[i]}");
            }

        }

        //5-4
        static void ch5_5_4()
        {
            int[,] A = new int[3, 5];
            int[] row_sum = new int[3];
            int[] col_sum = new int[5];

            Console.WriteLine("5-4.寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和");

            //input number and calculate row sum
            for(int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"輸入第{i*5 + j + 1}個數字");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum += A[i,j];
                }
                row_sum[i] = sum;
            }

            //calculate col sum
            for (int j=0; j < 5; j++)
            {
                int sum = 0;
                
                for(int i = 0; i < 3; i++)
                {
                    sum += A[i, j];
                }
                col_sum[j] = sum;
            }

            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"第{i + 1}列和為: {row_sum[i]}");
            }
            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine($"第{j + 1}行的和為: {col_sum[j]}");
            }
        }

        //5-5
        static void ch5_5_5()
        {
            int[,] A = new int[3, 5];
            int[] row_min = new int[3];
            int[] col_min = new int[5];

            Console.WriteLine("5-5.寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值");

            for (int i = 0; i < 3; i++)
            {
                int min = int.MaxValue;

                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"輸入第{i*5 + j + 1}個數字");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (A[i,j] < min)
                    {
                        min = A[i, j];
                    }
                }
                row_min[i] = min;
            }

            for(int j =0;j < 5; j++)
            {
                int min = int.MaxValue;
                for(int i = 0; i< 3; i++)
                {
                    if (A[i,j] < min)
                    {
                        min = A[i, j];
                    }
                }
                col_min[j] = min;
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"第{i + 1}列最小值為{row_min[i]}");
            }
            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine($"第{j + 1}行最小值為{col_min[j]}");
            }
        }

        //5-6
        static void ch5_5_6()
        {
            int[] a = new int[5];
            int[] b = new int[5];

            Console.WriteLine("5-6.寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai+bi，i=1到i=5");
            

            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine($"輸入a{i + 1}");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"輸入b{i + 1}");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"a{i + 1} + b{i + 1} = {a[i] + b[i]}");
            }

        }

        //5-7
        static void ch5_5_7()
        {
            int x = int.MinValue, y = int.MinValue;
            int[] a = new int[5];
            int[] b = new int[5];

            Console.WriteLine("5-7.寫一程式，輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者");

            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine($"輸入a{i + 1}");
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] > x)
                {
                    x = a[i];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"輸入b{i + 1}");
                b[i] = Convert.ToInt32(Console.ReadLine());
                if (b[i] > y)
                {
                    y = b[i];
                }
            }

            if(x < y)
            {
                Console.WriteLine($"x較小, x = {x}");
            }
            else if(y < x)
            {
                Console.WriteLine($"y較小, y = {y}");
            }
            else
            {
                Console.WriteLine($"x=y={x}");
            }
        }

    }
}
