using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string passwordHash = "123456";
            //password:
            //Console.WriteLine("Enter the password");
            //string password =  Console.ReadLine();

            //if (password == passwordHash) 
            //{
            //    Console.WriteLine("Access granted");
            //}
            //else
            //{
            //    Console.WriteLine("Access denied");
            //    goto password;
            //}

            //Console.Write("Exam1: ");
            //double exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Exam2: ");
            //double exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Exam3: ");
            //double exam3 = double.Parse(Console.ReadLine());

            //double average = (exam1 + exam2 + exam3) / 3;
            //bool status;
            //if (average >= 50)
            //{
            //    status = true;
            //}
            //else
            //{
            //    status = false;
            //}
            //Console.WriteLine("Average: " + average + " Passed: " + status);

            //    string userNameHash = "admin";
            //    string passwordHash = "123456";
            //password:
            //    Console.WriteLine("Enter the username");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("Enter the password");
            //    string password = Console.ReadLine();

            //    if (userName == userNameHash &&  password == passwordHash)
            //    {
            //        Console.WriteLine("Access granted");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Access denied");
            //        goto password;
            //    }

            //int num1, num2;
            //Console.WriteLine("Enter the numbers");
            //num1 = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());

            //if (num1 != num2)
            //{
            //    Console.WriteLine(num1 + " is not equaal to " + num2);
            //}
            //else
            //{
            //    Console.WriteLine(num1 + " is equal to " + num2);
            //}

            //Console.WriteLine("Chosee an operation \nAddition:+\nExtraction:-\nDivision:/\nMultiply:*");
            //char operation = char.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the numbers");
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //double result = 0;

            //if (operation == '+')
            //{
            //    result = num1 + num2;
            //}
            //else if (operation == '-')
            //{
            //    result = num1 - num2;
            //}
            //else if (operation == '/')
            //{
            //    result = num1 / num2;
            //}
            //else if (operation == '*')
            //{
            //    result = num1 * num2;
            //}
            //else
            //{
            //    Console.WriteLine($"Undefined operation {operation}");
            //}
            //Console.WriteLine($"Result: {result}");

            Console.WriteLine("Chosee an operation \nAddition:+\nExtraction:-\nDivision:/\nMultiply:*");
            char operation = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                default:
                    Console.WriteLine($"Undefined operation {operation}");
                    break;
            }
            Console.WriteLine($"Result: {result}");
        }
    }
}
