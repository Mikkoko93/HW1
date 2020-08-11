using System;

namespace Homework1
{
    class Program
    {
        public static int ii { get; set; }
        static void Main(string[] args)
        {
            int currentAge;

            Console.WriteLine("What is your year of birth?");
            checkParse(Console.ReadLine());
            currentAge = DateTime.Now.Year - ii;

            if(currentAge < 18 )
            {
                Console.WriteLine("You are not old enough to use this application");
            }
            else
            {
                Console.WriteLine("Welcome to the application");

                Console.WriteLine("What was done to the VHS cassette after finishing a movie?");
                Console.WriteLine("1. The cassette was blown into.");
                Console.WriteLine("2. The cassette was flipped to reveal the rest of the content.");
                Console.WriteLine("3. The cassette was rewinded to begin at the start.");

                checkParse(Console.ReadLine());


                switch (ii)
                {
                    case 1:
                        Console.WriteLine("Nice try Kiddo");
                        break;
                    case 2:
                        Console.WriteLine("Nice try Kiddo");
                        break;
                    case 3:
                        Console.WriteLine("Welcome to the Application");
                        break;
                }
            }

        }

        public static void checkParse(string input)
        {
            
            try
            {

                // declaring Int32 variable 
                int val;

                // getting parsed value 
                val = Int32.Parse(input);
                    ii = val;
                Console.WriteLine("'{0}' parsed as {1}", input, val);
            }

            catch (FormatException)
            {
                Console.WriteLine("Can't Parsed '{0}'", input);
            }
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
