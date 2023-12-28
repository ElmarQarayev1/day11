using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace day11;

class Program
{
    static void Main(string[] args)
    {
        //Verilmiş iki ədəd üzərində verilmiş
        // operator simvoluna əsasən riyazi əməliyyat aparıb nəticəsini console - da göstərən metod.
        Operator(23,2,'*');

        // Verilmiş yazıdaki verilmiş simvolların sayını qaytaran metod
        Console.WriteLine(CountChar("elmarqarayev",'e'));

        // Verilmiş yazıdaki sözlərin sayını qaytaran metod(söz dedikdə boşluqlarla ayrılmış bütün yazılar nəzərdə tutulur)
        Console.WriteLine(CounttWords("PB302 telebeleleri"));

        //Verilmişdədin rəqəmləri cəmini qaytaran metod
        Console.WriteLine(SumDigits(123564));

        //Verilmiş ədədi verilmiş qüvvətə yüksəldib nəticəsini qaytaran metod
        Console.WriteLine(PowerDigit(12,2));

        //Verilmiş ədədlər siyahısının bütün elementlərini müsbət şəkildə qaytaran metod.Misalçün metoda { 1,-4,9,-8}
        ////dəyərləri olan array göndərilsə metod bizə { 1,4,9,8}
        ////dəyərləri olan array qaytarmalıdır.
        int[] arr = new int[] { 1, 0, -4, -7, -7, 9, 7 };
        for (int i = 0; i < ChangePositive(arr).Length; i++)
        {
            Console.WriteLine(ChangePositive(arr)[i]);
        }

        ////Verilmiş yazını tərs formada qaytaran metod(Misalçün "salam" göndərilsə metoddan "malas" return ediləcək)
        Console.WriteLine(ReverseStr("elmar"));
        
        Console.ReadLine();
    }
    static void Operator(double first, double sec, char c)
    {
        switch (c)
        {
            case '+': Console.WriteLine($"ededlerin cemi:{first + sec}"); break;
            case '-': Console.WriteLine($"ededlerin ferqi:{first - sec}"); break;
            case '*': Console.WriteLine($"ededlerin hasili:{first * sec}"); break;
            case '/':
                if (sec != 0)
                {
                    Console.WriteLine($"ededlerin nisbeti:{first / sec}");
                }
                else
                {
                    Console.WriteLine(" 0 a bolmek olmaz!");
                }
                break;
            default:

                Console.WriteLine("simvolu duzgun daxil edin!");
                break;

        }
    }
    static int CountChar(string str,char c)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
            {
                count++;
            }
        }

        return count;
    }
    static int CounttWords(string str)
    {
        int count = 0;
        bool sozvarmi = false;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                if (sozvarmi)
                {
                    count++;
                    sozvarmi = false;
                }
            }
            else
            {
                sozvarmi = true;

            }

        }
        if (sozvarmi)
        {
            count++;
        }
        return count;

    }

    static int SumDigits(int n)
    {
        int digit;
        int sum = 0;
        while (n>0)
        {
             digit = n % 10;
             sum += digit;
            n = (n - digit)/ 10;
        }
        return sum;
        
    }
    static int PowerDigit(int n,int power)
    {
        int result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= n;
        }
        return result;
    }
    static int[] ChangePositive(int[] arr)
    {
        int count = arr.Length;
        int[] PostiveArr = new int[count];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            
            if (arr[i] > 0)
            {
                PostiveArr[index] = arr[i];
                index++;
            }
            else
            {
                PostiveArr[index] = -arr[i];
                index++;
            }
        }
        return PostiveArr; 

    }
    static string ReverseStr(string str)
    {
        string result="";
        for (int i = str.Length-1; i>=0; i--)
        {
            result += str[i];
        }
        return result;
    }
}



