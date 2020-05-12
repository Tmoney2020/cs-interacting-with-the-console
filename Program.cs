using System;

namespace cs_interacting_with_the_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining my variables 
            var myFullName = "Trent Costa";
            var coffeeCupsPerDay = "2";

            //Defined variable with datetime
            var todaysDate = DateTime.Now;

            Console.WriteLine($" Hi my name is {myFullName}, I drink {coffeeCupsPerDay} cups of coffee every morning. Today's date is {todaysDate}");

            Console.Write("What is your name?");
            var username = Console.ReadLine();
            if (username == "Alice")
            {
                Console.WriteLine("Welcome back Alice");
            }
            else
            {
                Console.WriteLine($"It is nice to meet you, {username}");
            }

            //Getting input from the user
            Console.Write("Please write a number.");
            var firstNumberAsString = Console.ReadLine();

            Console.Write("Please write a different number.");
            var secondNumberAsString = Console.ReadLine();

            //converting the string into a int
            double firstNumber = Double.Parse(firstNumberAsString);
            double secondNumber = Double.Parse(secondNumberAsString);

            //Using the newly created numbers to do math
            var sum = firstNumber + secondNumber;
            Console.WriteLine($"The sum of the two numbers is {sum}");

            var difference = secondNumber - firstNumber;
            Console.WriteLine($"The second number divided by the first number is {difference}");

            var product = firstNumber * secondNumber;
            Console.WriteLine($"The product of the two numbers is {product}");

            var quotient = secondNumber / firstNumber;
            Console.WriteLine($"The second number divided by the first number equals {quotient}");

            var remainder = $"{firstNumber % secondNumber}";
            Console.WriteLine($"The remainder of the first number divided by the second number is {remainder}");

            //Ending message
            Console.WriteLine($"Thank you for getting to the end of this code. To review, the sum of the two numbers is {sum}. The second number subtracted from the first number is {difference}. When we multiply the two numbers together we get {product}. When we divide the second number by the first number we get {quotient}. Finally, when we divide the first number by the second number we will get the remainder {remainder}");




        }
    }
}
