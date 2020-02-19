using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1-10 to find the prime number in that position: ");

            bool isValid = int.TryParse(Console.ReadLine(), out int userInput);
            while (!isValid)
            {
                Console.Write("That is not a valid entry. Please enter an integer between 1 and 10: ");
                isValid = int.TryParse(Console.ReadLine(), out userInput);
            }
            
            while (userInput > 10 || userInput < 1)
            {
                Console.Write("That is not a valid entry. Please enter an integer between 1 and 10: ");
                int.TryParse(Console.ReadLine(), out userInput);
            }

            Console.WriteLine($"The prime number at position {userInput} is {PrimeNumber.GetPrime(userInput)}");
        }
    }


}
