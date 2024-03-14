//using System;

namespace CSharpPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * general 
                 EvenOddNumberChecker() evenOddCheckerProgram = new EvenOddNumberChecker();
             * using var
                 var evenOddCheckerProgram = new EvenOddNumberChecker();
             * using Target Type Object Creation
                 EvenOddNumberChecker evenOddCheckerProgram = new();
             */
            EvenOddNumberChecker evenOddCheckerProgram = new();
            evenOddCheckerProgram.Run();

            //Concepts.DataTypes.Integer.Demo();
            //Concepts.DataTypes.FloatingPoint.Demo();


            //Console.WriteLine("Hello, World!");
        }
    }
}
