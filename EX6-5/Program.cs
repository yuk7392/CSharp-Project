#define CSHARP
using System;
using System.Diagnostics;

namespace EX6_5
{

    class Program
    {

        [Conditional("CSHARP")]
        public static void CSharpMethod()
        {

            Console.WriteLine("In the CSharp Method...");

        }
        [Conditional("JAVA")]
        public static void JavaMethod()
        {

            Console.WriteLine("In the Java Method...");

        }
        static void Main(string[] args)
        {
            Program.CSharpMethod();
            Program.JavaMethod();
        }
    }
}
