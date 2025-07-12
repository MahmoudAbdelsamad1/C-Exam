using System.ComponentModel;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetPrimeNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 0, 11, 12));

            // Question 1: 
            //Write a program that asks the user to enter their age and nationality.If the age is 18 or above
            //and nationality is "Egyptian", print "Eligible to vote", otherwise print "Not eligible".
            //int age = 0;
            //Console.WriteLine("pls enter your age ");
            //int.TryParse(Console.ReadLine(), out age);

            //Console.WriteLine("pls enter your nationality ");
            ////string? nationality = Console.ReadLine();

            //if (age >= 18 && nationality == "Egyptian")
            //{
            //    Console.WriteLine("Eligible to vote");
            //}
            //else {

            //    Console.WriteLine("Not eligible");
            //}




            // Question 2: 
            //Create a calculator function that takes two numbers and an operator (+, -, *, /) as input.Use a
            //switch statement to perform the operation and return the result.Handle division by zero. 
        }


        static void CalculatorFunc(int num1, int num2, string operatorS)
        {
            int result = 0;
            switch (operatorS)
            {

                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 <= 0) return;
                    result = num1 + num2;
                    break;


            }
            Console.WriteLine($"resul of {num1} {operatorS} {num2} = {result}");


        }


        // Question 3:
        //Write a method that takes an integer n and prints the multiplication table from 1 to n.Each row
        //should show the result of multiplying the current number by 1 through 10. 

        static void MultiplicationTable(int num)
        {

            for (int i = 1; i <= num; i++)
            {

                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($" {i} * {j} = {i * j} ");
                }
                Console.WriteLine("--------------------------------------------------");
            }



            //Question 4: 
            //Write a program that accepts an array of integers and counts how many of them are prim numbers.

            
        }

        static int GetPrimeNumbers(params int[] array)
        {
            int countOfPrimeNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int flag = 0;
                if (array[i] == 0 || array[i] == 1) continue;

                for (int j = 2; j < array[i]; j++)
                {
                    if (array[i] % j == 0)
                        flag = 1;

                }
                if (flag == 0)
                {
                    countOfPrimeNumbers++;
                }

            }
            return countOfPrimeNumbers;
        }





        // Question 5:
        // Ask the user to input 10 integers and store them in an array. Find and print the maximum value and its index.
        static void FindMaxAndIndex()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                string input = Console.ReadLine();
                int num = 0;
                int.TryParse(input, out num);
                numbers[i] = num;
            }

            int max = numbers[0];
            int index = 0;

            for (int i = 1; i < 10; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    index = i;
                }
            }

            Console.WriteLine("Maximum value is: " + max + " at index: " + index);
        }





        // Question 6:
        // Create a function that checks whether a given word is a palindrome (ignore casing)
        static bool IsPalindrome(string word)
        {
            int length = 0;
            while (true)
            {
                if (length >= word.Length) break;
                length++;
            }

            for (int i = 0; i < length / 2; i++)
            {
                char c1 = word[i];
                char c2 = word[length - 1 - i];

                // Convert to lowercase manually
                if (c1 >= 'A' && c1 <= 'Z') c1 = (char)(c1 + 32);
                if (c2 >= 'A' && c2 <= 'Z') c2 = (char)(c2 + 32);

                if (c1 != c2)
                    return false;
            }
            return true;
        }




        // Question 7:
        // Function to divide two nullable integers and return result or null
        static int? SafeDivide(int? a, int? b)
        {
            if (a.HasValue && b.HasValue && b.Value != 0)
            {
                return a.Value / b.Value;
            }
            return null;
        }






        // Question 8:
        // Create a function that accepts an array of integers and returns the sum of all even numbers
        static int SumEvenNumbers(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }





        // Question 9:
        // Read scores for 5 students and assign grades using switch with ranges
        static void GradeStudents()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter score for student " + (i + 1) + ": ");
                string input = Console.ReadLine();
                int score = 0;
                int.TryParse(input, out score);

                string grade = "";
                switch (score / 10)
                {
                    case 10:
                    case 9:
                        grade = "A";
                        break;
                    case 8:
                        grade = "B";
                        break;
                    case 7:
                        grade = "C";
                        break;
                    case 6:
                        grade = "D";
                        break;
                    default:
                        grade = "F";
                        break;
                }

                Console.WriteLine("Student " + (i + 1) + " grade: " + grade);
            }
        }





        // Question 10:
        // Function to return average of non-null scores, return null if all are null
        static double? AverageNonNull(int?[] scores)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i].HasValue)
                {
                    sum += scores[i].Value;
                    count++;
                }
            }
            if (count == 0)
                return null;
            return (double)sum / count;
        }

    }
}
