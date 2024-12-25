using System;
using System.Data.Common;
using System.Net;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace assignment_5
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            #region Q1
            //Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //Passing by Value: A copy of the actual value is passed to the method. Changes made to the parameter inside the method do not affect the original variable.
            //Passing by Reference: The memory address of the original variable is passed to the method. Changes made to the parameter inside the method affect the original variable.

            //static void PassingByValue(int x)
            //{
            //    x += 29; 
            //    Console.WriteLine($"Inside PassingByValue: {x}");
            //}

            //static void PassingByReference(ref int y)
            //{
            //    y += 28; 
            //    Console.WriteLine($"Inside PassingByReference: {y}");
            //}

            //int z = 19;

            //Console.WriteLine($"Before PassingByValue: {z}");
            //PassingByValue(z);
            //Console.WriteLine($"After PassingByValue: {z}");

            //Console.WriteLine("**********"); 

            //Console.WriteLine($"Before PassingByReference: {z}");
            //PassingByReference(ref z);
            //Console.WriteLine($"After PassingByReference: {z}");
            #endregion

            #region Q2
            //Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //Passing by Value (Reference Type) : the reference is reassigned inside the method, it does not affect the original reference outside the method.
            // Passing by Reference (Reference Types) : Reassigning the reference inside the method affects the original variable.



            #endregion

            #region Q3

            //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //static void SumSub(int x, int y, int a, int b, out int sum, out int sub)
            //{
            //    sum = x + y;
            //    sub = a - b;
            //}

            //Console.WriteLine("Enter the first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the third number:");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the fourth number:");
            //int num4 = int.Parse(Console.ReadLine());
            //int sum, sub;
            //SumSub(num1, num2, num3, num4, out sum, out sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            #endregion

            #region Q4
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7

            //static int SumOfDigits(int num)
            //{
            //    int sum = 0;

            //    while (num != 0)
            //    {
            //        sum += num % 10; 
            //        num /= 10;       
            //    }

            //    return sum;
            //}

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //int sum = SumOfDigits(number);

            //Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
            #endregion

            #region Q5
            //Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //static bool IsPrime(int num)
            //{
            //    if (num <= 1) return false; 
            //    if (num == 2) return true;  

            //    for (int i = 2; i <= Math.Sqrt(num); i++) 
            //    {
            //        if (num % i == 0) return false; 
            //    }

            //    return true; 
            //}
            //Console.Write("Enter a number to check if it is prime: ");
            //int number = int.Parse(Console.ReadLine());

            //bool result = IsPrime(number);

            //Console.WriteLine(result? $"{number} is a prime number.": $"{number} is not a prime number.");
            #endregion

            #region Q6
            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //static void MinMaxArray(int[] arr, out int min, out int max)
            //{
            //    min = arr[0];
            //    max = arr[0];

            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] < min) min = arr[i];
            //        if (arr[i] > max) max = arr[i];
            //    }
            //}
            //    int[] numbers = { 7, 37, 2, 76, 29 };

            //    int minNum, maxNum;

            //    MinMaxArray(numbers, out minNum, out maxNum);

            //    Console.WriteLine($"Minimum Value: {minNum}");
            //    Console.WriteLine($"Maximum Value: {maxNum}");
            #endregion

            #region Q7
            //Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //static long Factorial(int num)
            //{

            //    long result = 1;

            //    for (int i = 1; i <= num; i++)
            //    {
            //        result *= i;
            //    }

            //    return result;
            //}
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Factorial of {0} is: {1}", number, Factorial(number));
            #endregion

            #region Q8
            //Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            #endregion
        }

    }
}
