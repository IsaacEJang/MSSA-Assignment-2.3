using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Assignment 2.3");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            ///* 1. Write a console application to create a text file and save your basic details like name, age, 
            // * address ( use dummy data). Read the details from same file and print on console.
            //*/

            // name
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine().ToUpper();

            // age
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // address
            Console.Write("Enter your street address: ");
            string address = Console.ReadLine();

            // path
            string path = @"C:\MSSA\Files\" + userName.ToLower() + ".txt";

            // create file and writes in file
            File.AppendAllText(path, $"{userName} is {age} and lives at {address}");

            using (StreamReader reader = new StreamReader(path)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(line);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                }
            }



            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();

            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 2---------------\n");
            Console.ForegroundColor = ConsoleColor.White;


        /*
        2. Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.

           Use the format specifiers to display currency, % symbol.
        */

        Pt2StartPoint:

            Console.WriteLine("\nI can cacluate your tip!");
            Console.Write("\nEnter the bill total: $");
            decimal bill = decimal.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\nHere are common tip ammounts:\n" +
                $"\n18%:${(bill / 100 * 18):F2} ---------- Grand Total:${(bill / 100 * 118):F2}" +
                $"\n20%:${(bill / 100 * 20):F2} ---------- Grand Total:${(bill / 100 * 120):F2}" +
                $"\n22%:${(bill / 100 * 22):F2} ---------- Grand Total:${(bill / 100 * 122):F2}\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"Enter any tip percent (%) you would like to leave: ");
            decimal tip = decimal.Parse(Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nYour {tip}% tip is ${(bill / 100 * tip):F2} " +
                $"and your Grand Total is ${((bill / 100) * (100 + tip)):F2}\n");
            Console.ForegroundColor = ConsoleColor.White;

            //loop to Pt2StartPoint
            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto Pt2StartPoint;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }

            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");

            Console.ReadKey();
        }
    }
}
