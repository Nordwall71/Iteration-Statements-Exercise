namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            
          
            Threes();
            Thousand();
            Equal();
            Even();
            Negative();
            Voter();
            ThisNumber();
            Multiply();
        }

        public static void Thousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

           
        }

        public static void Equal()
        {
            var firstNumber = 4;
            var secondNumber = 5;

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("They are equal.");
            }
            else
            {
                Console.WriteLine("Not equal!");
            }
        }

        public static void Even()
        {
            var theNumber = 5;

            if (theNumber % 2 == 0)
            {
                Console.WriteLine($" {theNumber} is even");
            }

            else
            {
                Console.WriteLine($"{theNumber} is odd");
            }
        }

        public static void Negative()
        {
            var thisNumber = -555;

            if (thisNumber < 0)
            {
                Console.WriteLine($"{thisNumber} is a negative number");
            }
            else
            {
                Console.WriteLine($"{thisNumber} is a posotive number.");
            }
        }
        
        public static void Voter()
        {
            
            Console.WriteLine("State your age");
            var answer = int.Parse(Console.ReadLine());

            if (answer <= 17)
            {
                Console.WriteLine("You're a bit too young to vote.");
            }
            else 
            {
                Console.WriteLine("You're good to go!");
            }

                
        }

        public static void ThisNumber()

        {
            int userGuess;
            do
            {
                Console.WriteLine("Guess a number within the range I'm thinking of...");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess < -10)

                {
                    Console.WriteLine($"Try going higher, {userGuess} is not in the range.");
                }

                else if (userGuess > 10)
                {
                    Console.WriteLine($"The number {userGuess} is too high, try again");
                }

                else
                {
                    Console.WriteLine($"{userGuess} is within the range, nice job!");
                }

            }
            while (userGuess < -10 || userGuess > 10);
        }


        public static void Multiply()
        {
            Console.WriteLine("Input a number between 1 and 12");
            int thisNumber = int.Parse(Console.ReadLine());

            for (int i = 3; i < 99; i++)
            {
                Console.WriteLine($"{thisNumber} x {i} = {thisNumber*i}");
            }
                
                
        }
        


            

        


           


        
            
        
        
        
                
                

            


        
                
            
        


    }
}
