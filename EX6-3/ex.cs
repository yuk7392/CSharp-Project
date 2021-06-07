using System;

namespace EX6_3
{

    class ex
    {

        static void Swap<DataType>(ref DataType a, ref DataType b)
        {
            DataType temp;
            temp = a;a = b;b = temp;


        }

        static void Main(string[] args)
        {
            int a = 1, b = 2; double c = 1.5, d = 2.5;

            Console.WriteLine("Before a = {0}, b = {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After a = {0}, b = {1}", a, b);
            Console.WriteLine("Before c = {0}, d = {1}", c, d);
            Swap<double>(ref c, ref d);
            Console.WriteLine("After c = {0}, d = {1}", c, d);


        }
    }
}
