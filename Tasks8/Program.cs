using System;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task1
        ////Welcome();
        ////Niceday();


        //Task2
        ////Console.Write("Please input a name: ");
        ////string str = Console.ReadLine();
        ////welcome(str);
        ////Niceday();


        //Task3
        ////double x, y;
        ////Console.Write("Enter a number: ");
        ////x = double.Parse(Console.ReadLine());
        ////Console.Write("Enter another number: ");
        ////y = double.Parse(Console.ReadLine());
        ////Console.WriteLine("The multiply of two numbers is :" + " " + multiply(x, y));
        ////Console.WriteLine("The sum of two numbers is :" + " " + Sum(x, y));
        ////Console.WriteLine("The subtraction  of two numbers is :" + " " + Subtract(x, y));
        ////Console.WriteLine("The divide of two numbers is :" + " " + Divide(x, y));


        //Task4
        ////Arraysum();


        //Task5
        ////int x, y;
        ////Console.WriteLine("Enter a number: ");
        ////x = int.Parse(Console.ReadLine());
        ////Console.WriteLine("Enter a number: ");
        ////y = int.Parse(Console.ReadLine());
        ////swapint(x, y);


        //Task6
        ////int x, y;
        ////Console.WriteLine("Input Base number:  ");
        ////x = int.Parse(Console.ReadLine());
        ////Console.WriteLine("Input the Exponent: ");
        ////y = int.Parse(Console.ReadLine());
        ////Console.WriteLine($"So, the number {x} ^ (to the power) {y} = {Raisingint(x, y)}");


        //Task7
        ////Console.Write("Input number of Fibonacci Series : ");
        ////int x = int.Parse(Console.ReadLine());
        ////Console.WriteLine("The Fibonacci series of " + x + " numbers is: ");
        ////for (int i = 0; i < x; i++)
        ////{
        ////    Console.Write(Fibonacci(i) + "  ");
        ////}


        //Task8
        ////Console.Write("Input a number: ");
        ////int x = int.Parse(Console.ReadLine());
        ////if (Checkprime(x))
        ////{
        ////    Console.WriteLine($"{x} is a prime number");
        ////}
        ////else
        ////{
        ////    Console.WriteLine($"{x} is not a prime number");
        ////}


        //Task9
        ////SumofDigits();
        ////Console.ReadLine();
    }
    #region Task1
    public static void Welcome()
    {
        Console.WriteLine("Welcome Friends");
    }
    public static void Niceday()
    {
        Console.WriteLine("Have a nice day!");
    }
    #endregion

    #region Task2
    static void welcome(string name)
    {
        Console.Write("Welcome friend" + " " + name + "!");
        Console.WriteLine();
    }
    static void niceday()
    {
        Console.Write("Have a nice day!");
    }

    #endregion

    #region Task3

    static double multiply(double a, double b)
    {
        return a * b;
    }
    static double Sum(double a, double b)
    {
        return a + b;
    }
    static double Subtract(double a, double b)
    {
        return a - b;
    }
    static double Divide(double a, double b)
    {
        return a / b;
    }



    #endregion

    #region Task4
    public static void Arraysum()
    {
        int[] arr = new int[5];
        int sum = 0;
        Console.WriteLine("Enter elements of array");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"element - {i}: ");
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }
        Console.WriteLine("The sum of the elements of the array is: " + " " + sum);
    }

    #endregion

    #region Task5

    static void swapint(int a, int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"Now the 1st number is : {a} , and the 2nd number is : {b}");
    }

    #endregion

    #region Task6

    public static int Raisingint(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result = result * a;
        }
        return result;
    }


    #endregion

    #region Task7

    public static int Fibonacci(int a)
    {
        int num1 = 0;
        int num2 = 1;
        int sum = 0;

        for (int i = 0; i < a; i++)
        {
            num1 = num2;
            num2 = sum;
            sum = num1 + num2;
        }
        return sum;

    }
    #endregion

    #region Task8
    public static bool Checkprime(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    #endregion

    #region Task9

    public static void SumofDigits()
    {
        int x, y, sum = 0;
        Console.Write("Enter a number: ");
        x = int.Parse(Console.ReadLine());
        while (x > 0)
        {
            y = x % 10;
            sum = sum + y;
            x = x / 10;
        }
        Console.WriteLine(sum);
    }

    #endregion
}