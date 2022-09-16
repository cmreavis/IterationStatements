using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void Thousands()
        {
            for (int oneK = 1000; oneK >= -1000; oneK--)
            {
                Console.WriteLine(oneK);
            }

        }
        public static void ByThrees()
        {
            for (int by3 = 3; by3 <= 999; by3 += 3)
            {
                Console.WriteLine(by3);
            }

        }
        public static bool EqualOrNot(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void EvenOrOdd(int numberGiven)
        {
            if (numberGiven % 2 == 0)
            {
                Console.WriteLine($"Even!");
            }
            else
            {
                Console.WriteLine($"Odd!");
            }
        }
        public static void PositiveNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"That number is positive!");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero is neither positive nor negative!");
            }
            else
            {
                Console.WriteLine($"That number is negative!");
            }
        }
        public static bool AbleToVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are of voting age!");
                return true;
            }
            else
            {
                Console.WriteLine($"You cannot vote yet! Give it {18 - age} years.");
                return false;
            }
        }
        public static bool BetweenTheseNums(int num)
        {
            if (num <= 10 && num >= -10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Multiply()
        {
            Console.WriteLine("Input a number you would like to see multiplication tables for.");

            var xNum = int.Parse(Console.ReadLine());
            for (int x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{xNum} * {x} = {xNum * x}.");
            }
        }   
        
            
    }
}
