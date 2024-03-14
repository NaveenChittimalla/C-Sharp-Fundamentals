namespace CSharpPrograms.Concepts.DataTypes
{
    public static class Integer
    {
        public static void Demo()
        {
            Console.WriteLine("Concept: Numeric Data Type - short *Start*");
            short smallNumber = 123;
            Console.WriteLine($"value: {smallNumber}");
            Console.WriteLine($"Minimum value allowed: {short.MinValue}"); // -32768
            Console.WriteLine($"Maximum value allowed: {short.MaxValue}"); // 32767
            //short minShort = (short)Math.Pow(-2, 15);
            //short maxShort = (short)(Math.Pow(2, 15) - 1);
            //Console.WriteLine(minShort);
            //Console.WriteLine(maxShort);
            Console.WriteLine("Concept: Numeric Data Type - short *End*");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Concept: Numeric Data Type - int *Start*");
            int number = 12345;
            Console.WriteLine($"value: {number}");
            Console.WriteLine($"Minimum value allowed: {int.MinValue}"); // -2147483648
            Console.WriteLine($"Maximum value allowed: {int.MaxValue}"); // 2147483647
            //int min = (int)Math.Pow(-2, 31);
            //int max = (int)(Math.Pow(2, 31) - 1);
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            Console.WriteLine("Concept: Numeric Data Type - int *End*");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Concept: Numeric Data Type - long *Start*");
            long bigNumber = 123456789;
            Console.WriteLine($"value: {bigNumber}");
            Console.WriteLine($"Minimum value allowed: {long.MinValue}"); // -9223372036854775808
            Console.WriteLine($"Maximum value allowed: {long.MaxValue}"); // 9223372036854775807
            //long minLong = (long)Math.Pow(-2, 63);
            //long maxLong = (long)(Math.Pow(2, 63) - 1);
            //Console.WriteLine(minLong);
            //Console.WriteLine(maxLong);
            Console.WriteLine("Concept: Numeric Data Type - long *End*");


        }

    }
}
