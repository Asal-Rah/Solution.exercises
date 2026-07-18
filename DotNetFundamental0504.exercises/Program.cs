using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFundamental0504.exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

             void EvenOrOdd(int number)
            {
                if ( number % 2 == 0)
                {
                    Console.WriteLine("The number " + number.ToString() + " is even!");

                }
                else
                {
                    Console.WriteLine("The number " + number.ToString() + " is odd!");
                }
            }

            void IsPrime(int number)
            {
                if ( number < 2 )
                {
                    Console.WriteLine("Not Prime!!"); 
                }
                if (number == 2)
                {
                    Console.WriteLine("Prime!!!");
                }
                if ((number > 2 ) && (number % 2 == 0))
                {
                    Console.WriteLine("Not Prime!!");

                }
                else
                { for (int i = 3; i * i <= number; i = i + 2)
                    {
                        if (number % i == 0)
                        {
                            Console.WriteLine("Not Prime!!");
                            break;

                        }
                    }

                }
            }

            void IsDivisibleByFive(int number)
            {
                if ( number % 5 == 0)
                {
                    Console.WriteLine("The number " + number.ToString() + " is divisible by 5!!");
                }
                else
                {
                    Console.WriteLine("The number " + number.ToString() + " is NOT divisible by 5!!");

                }
            }
            void IsDivisible( int firstNum, int secondNum)
            {
                int max = Math.Max(firstNum, secondNum);
                int min = Math.Min(firstNum, secondNum);
                if (max % min == 0 )
                {
                    Console.WriteLine("The given numbers are divisible by each other!!");
                }
                else
                {
                    Console.WriteLine("The given numbers are NOT divisible by each other!!");

                }
            }

            void GetMean(int[] arr)
            {
                int sum = 0 ;
                int n = arr.Length;
                for (int i = 0; i < n; i++)
                {
                    sum += arr[i];               
                }
                int mean = sum / n ;
                Console.WriteLine("Mean of the given set of numbers is : " + mean);
                
            }

            void GetMedian(int[] arr)
            {
                Array.Sort(arr);
                int n = arr.Length;
                if ( n % 2 == 0 )
                {
                    float median = (arr[(n / 2)-1] + arr[(n / 2)]) / 2;
                    Console.WriteLine("The Median of the given set of numbers is : " + median);

                }
                else
                {
                    int median = arr[(n-1) / 2];
                    Console.WriteLine("The Median of the given set of numbers is : " + median);

                }

            }


            Console.WriteLine("Please Enter the method you want to apply : \n " +
                "To check if a number is prime enter : IsPrime\n" +
                "To check if a number is even enter : EvenOrOdd\n" +
                "To check if a number is divisible by 5 enter : IsDivisibleByFive\n" +
                "To check if two numbers are divisible by each other enter : IsDivisible\n" +
                "To get the mean of a set of numbers enter : GetMean\n" +
                "To get the median of a set of numbers enter : GetMedian\n");
            string action = Console.ReadLine();
            Console.WriteLine("Now enter your inputs please. Lists must be comma-seperated.");
            string input = Console.ReadLine();
            if (input.Contains(','))
            {
                int[] arr = input.Split(',').Select(int.Parse).ToArray();
                if (action == "IsDivisible")
                {
                    IsDivisible(arr[0], arr[1]);
                }
                else if (action == "GetMean")
                {
                    GetMean(arr);
                }
                else if (action == "GetMedian")
                {
                    GetMedian(arr);
                }
                else
                {
                    Console.WriteLine("The chosen action is not among the defined ones!");
                }
            }
            else
            {
                int number = int.Parse(input);
                if (action == "IsPrime")
                {
                    IsPrime(number);
                }
                else if (action == "EvenOrOdd")
                {
                    EvenOrOdd(number);
                }
                else if (action == "IsDivisibleByFive")
                {
                    IsDivisibleByFive(number);
                }
                else
                {
                    Console.WriteLine("The chosen action is not among the defined ones!");
                }

            }

            Console.ReadKey();



        }
    }
}
