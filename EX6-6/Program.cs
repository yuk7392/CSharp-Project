using System;

namespace EX6_6
{

    class Program
    {
        [Obsolete("경고, Obsolete Method입니다.")]
        public static void OldMethod()
        {

            Console.WriteLine("In the Old Method...");

        }

        public static void NormalMethod()
        {

            Console.WriteLine("In the Normal Method...");

        }


        static void Main(string[] args)
        {
            Program.OldMethod();
            Program.NormalMethod();
        }
    }
}
