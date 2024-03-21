using System.Data;

namespace MyConsoleHelperLibrary
{
    public static class ReadInput
    {
        /*
        * Usage:
            string value = MyConsoleHelperLibrary.ReadInput.ReadTextInput();
            string firstName = MyConsoleHelperLibrary.ReadInput.ReadTextInput("Enter FirstName");
            string firstName = MyConsoleHelperLibrary.ReadInput.ReadTextInput("Enter FirstName","Invalid FirstName.");
        */
        public static string ReadTextInput(string prompt = null, string inValidMessage = null)
        {
            string inputedValue = string.Empty;
            bool isValid;
            prompt = prompt ?? "Enter input value";
            inValidMessage = inValidMessage ?? "Invalid input. Please enter valid text.";
            do
            {
                Console.Write($"{prompt}:");
                inputedValue = Console.ReadLine();
                isValid = !string.IsNullOrEmpty(inputedValue)
                    && !string.IsNullOrWhiteSpace(inputedValue)
                    && inputedValue.Trim() != string.Empty;
                if (!isValid)
                {
                    Console.WriteLine(inValidMessage);
                }
            } while (!isValid);

            return inputedValue;
        }

        /*
        * Usage:
            int iValueG = MyConsoleHelperLibrary.ReadInput.ReadIntegerInput();
            int age = MyConsoleHelperLibrary.ReadInput.ReadTextInput("Enter Age");
            int age = MyConsoleHelperLibrary.ReadInput.ReadTextInput("Enter Age","Invalid Age.");
        */
        public static int ReadIntegerInput(
            string prompt = null,
            string inValidMessage = null)
        {
            int value;
            bool isValid;
            prompt = prompt ?? "Enter input value";
            inValidMessage = inValidMessage ?? "Invalid input. Please enter valid integer.";
            do
            {
                Console.Write($"{prompt}:");
                string inputedValue = Console.ReadLine();
                isValid = int.TryParse(inputedValue, out value);
                if (!isValid)
                {
                    Console.WriteLine(inValidMessage);
                }
            } while (!isValid);

            return value;
        }

        /*
         * Usage:
             string value = MyConsoleHelperLibrary.ReadInput.ReadInputValue<string>();
             int value = MyConsoleHelperLibrary.ReadInput.ReadInputValue<int>();
             int value = MyConsoleHelperLibrary.ReadInput.ReadInputValue<int>("Enter Age");
             int value = MyConsoleHelperLibrary.ReadInput.ReadInputValue<int>("Enter Age", "Invalid Age");
             int value = MyConsoleHelperLibrary.ReadInput.ReadInputValue<int>("Enter Age",
                           "Age must be between 18 and 100", (value) => value > 18 && value < 100);
         */
        public static T ReadInputValue<T>(
            string prompt = null,
            string invalidMessage = null,
            Predicate<T> validationFn = null)
        {
            T value = default;
            bool isValid = false;
            bool isValidValidationFn = false;
            prompt ??= $"Enter input value ({typeof(T).Name})";
            invalidMessage ??= $"Invalid input. Please enter valid {typeof(T).Name} value.";
            validationFn ??= v => true;

            do
            {
                Console.Write($"{prompt}:");
                string inputedValue = Console.ReadLine();
                switch (typeof(T).Name)
                {
                    case nameof(String):
                        isValid = !string.IsNullOrEmpty(inputedValue)
                                    && !string.IsNullOrWhiteSpace(inputedValue)
                                    && inputedValue.Trim() != string.Empty;
                        value = (T)(object)inputedValue;
                        break;
                    case nameof(Int16):
                        isValid = short.TryParse(inputedValue, out short shortValue);
                        value = (T)(object)shortValue;
                        break;
                    case nameof(Int32):
                        isValid = int.TryParse(inputedValue, out int intValue);
                        value = (T)(object)intValue;
                        break;
                    case nameof(Int64):
                        isValid = long.TryParse(inputedValue, out long longValue);
                        value = (T)(object)longValue;
                        break;
                    case nameof(Decimal):
                        isValid = decimal.TryParse(inputedValue, out decimal decimalValue);
                        value = (T)(object)decimalValue;
                        break;
                    case nameof(Double):
                        isValid = double.TryParse(inputedValue, out double doubleValue);
                        value = (T)(object)doubleValue;
                        break;
                    case nameof(Single): //Float
                        isValid = float.TryParse(inputedValue, out float floatValue);
                        value = (T)(object)floatValue;
                        break;
                    default:
                        Console.WriteLine($"{typeof(T).Name} not supported" );
                        break;
                }
                isValidValidationFn = validationFn(value);
                if (!isValid || !isValidValidationFn)
                {
                    Console.WriteLine(invalidMessage);
                }
            } while (!isValid || !isValidValidationFn);
            return value;
        }
    }
}
