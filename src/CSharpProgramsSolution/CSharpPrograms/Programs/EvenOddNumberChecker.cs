namespace CSharpPrograms
{
    public enum EvenOrOdd
    {
        Even,
        Odd
    }

    public class EvenOddNumberChecker
    {
        public EvenOrOdd IsEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return EvenOrOdd.Even;
            }
            return EvenOrOdd.Odd;
        }

        public void CheckNumber()
        {
            string enteredValue = string.Empty;
            int numberValue;
            bool isValid = false;

            do
            {
                Console.WriteLine("");
                Console.Write("Enter Number: ");
                enteredValue = Console.ReadLine();
                isValid = int.TryParse(enteredValue, out numberValue)
                    && numberValue != 0;
                if (!isValid)
                {
                    Console.WriteLine("Invalid Number. Please enter valid number");
                }
            }
            while (!isValid);

            var result = IsEvenOrOdd(numberValue);
            if (result == EvenOrOdd.Even)
            {
                Console.WriteLine("The entered number " + enteredValue + " is an even number");
            }
            else
            {
                Console.WriteLine("The entered number " + enteredValue + " is an odd number");
            }

            //Console.WriteLine("The entered number " + enteredValue + " is an " +
            //    //(result == EvenOrOdd.Even ? "even" : "odd")
            //    result.ToString()
            //    + " number");

            //Console.WriteLine($"The entered number {enteredValue} is an {result.ToString()} number");

        }

        public void ReadChoice()
        {
            Console.WriteLine("");
            Console.WriteLine("Press 1: to enter number");
            Console.WriteLine("Press any other character to exit program");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CheckNumber();
                    ReadChoice();
                    break;
                default:
                    Console.WriteLine("Even Odd Number Checker program exited successfully...");
                    Environment.Exit(0);
                    break;
            }
        }

        public void Run()
        {
            Console.WriteLine("Even Or Odd Number Checker");
            ReadChoice();
        }
    }
}
