using DesignPatterns.Library.Strategy;
using System;
using System.Reflection;

namespace DesignPatterns.Testing.ConsoleOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Strategy Design

            // string l_LetterText = CreateLetter.GenerateCustomLetter("../../../../../DesignPatterns.Library/Strategy/Letter.txt", Company.Bar);
            // Console.Write(l_LetterText);

            #endregion

            Console.ReadLine();
        }
    }
}
