namespace CSharpPrograms.Concepts.DataTypes
{
    public static class FloatingPoint
    {
        public static void Demo()
        {
            //Best suited for Scientific Calculations and supports upto 7 decimal digits. Suffix: F
            Console.WriteLine("Concept: Floating Point Data Type - float *Start*");
            float floatNumber = -50.50F;
            Console.WriteLine($"value: {floatNumber}");
            Console.WriteLine($"Minimum value allowed: {float.MinValue}"); // -3.4028235E+38
            Console.WriteLine($"Maximum value allowed: {float.MaxValue}"); // 3.4028235E+38
            Console.WriteLine("Concept: Floating Point Data Type - float *End*");
            Console.WriteLine("");
            Console.WriteLine("");

            //Best suited for Scientific Calculations and supports upto 15 decimal digits. Suffix: D
            Console.WriteLine("Concept: Floating Point Data Type - double *Start*");
            double doubleNumber = -50.50D;
            Console.WriteLine($"value: {doubleNumber}");
            Console.WriteLine($"Minimum value allowed: {double.MinValue}"); // -1.7976931348623157E+308
            Console.WriteLine($"Maximum value allowed: {double.MaxValue}"); // 1.7976931348623157E+308
            Console.WriteLine("Concept: Floating Point Data Type - double *End*");
            Console.WriteLine("");
            Console.WriteLine("");

            //Best suited for Financial Calculations and higher precision value.. Suffix: M
            // 10x slower than double
            Console.WriteLine("Concept: Floating Point Data Type - decimal *Start*");
            decimal decimalNumber = -50.50M;
            Console.WriteLine($"value: {decimalNumber}");
            Console.WriteLine($"Minimum value allowed: {decimal.MinValue}"); // -79228162514264337593543950335
            Console.WriteLine($"Maximum value allowed: {decimal.MaxValue}"); // 79228162514264337593543950335
            Console.WriteLine("Concept: Floating Point Data Type - decimal *End*");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Accuracy Check *Start*");
            float flValue = 0.1F;
            double doValue = 0.1D;
            decimal deValue = 0.1M;
            Console.WriteLine($"Float Calculation: {flValue+ flValue+ flValue + flValue 
                + flValue + flValue + flValue + flValue + flValue + flValue}");
            Console.WriteLine($"Double Calculation: {doValue + doValue + doValue + doValue
                 + doValue + doValue + doValue + doValue + doValue + doValue}");
            Console.WriteLine($"Decimal Calculation: {deValue + deValue + deValue + deValue
                + deValue + deValue + deValue + deValue + deValue + deValue}");
            Console.WriteLine("Accuracy Check *End*");
        }
    }
}
