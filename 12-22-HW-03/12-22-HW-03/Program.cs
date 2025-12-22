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

            Console.Write("Array output is: ");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
