namespace MyConsoleHelper.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string value = MyConsoleHelperLibrary.ReadInput.ReadTextInput();
            //Console.WriteLine("Text Value:" + value);
            //int iValue = MyConsoleHelperLibrary.ReadInput.ReadIntegerInput();
            //Console.WriteLine("Integer Value:" + iValue);

            //string valueG = MyConsoleHelperLibrary.ReadInput.ReadInputValue<string>();
            //Console.WriteLine("G Text Value:" + valueG);
            //int iValueG = MyConsoleHelperLibrary.ReadInput.ReadInputValue<int>();
            //Console.WriteLine("G Integer Value:" + iValueG);

            string firstName = MyConsoleHelperLibrary.ReadInput.ReadInputValue<string>("Enter Firstname", "Invalid Firstname");
            Console.WriteLine("Age :" + firstName);
            int age = MyConsoleHelperLibrary.ReadInput.ReadInputValue<int>("Enter Age", "Invalid Age");
            Console.WriteLine("Age :" + age);
            age = MyConsoleHelperLibrary.ReadInput.ReadInputValue<int>("Enter Age"
                , "Age must be between 18 and 100"
                , (value) => value > 18 && value < 100);

            Console.WriteLine("age limit:" + age);

            Console.ReadLine();
        }
    }
}
