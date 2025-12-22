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
            ch5_5_4();
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
                Console.Write($"讀入第{i+1}個數字");
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
                Console.WriteLine($"請輸入第{i + 1}個數字");

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

            Console.WriteLine("5-3.寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]≥0，令B[i]=1，否則令B[i]=0");

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

    }
}
