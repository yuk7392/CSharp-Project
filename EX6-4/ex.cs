using System;

namespace EX6_4
{


    class GenericType<T> where T : SystemException
    {

        private T value;
        public GenericType(T v)
        {

            value = v;

        }

        public override string ToString()
        {
            return "Type is " + value.GetType();
        }


    }



    class ex
    {
        static void Main(string[] args)
        {

            GenericType<NullReferenceException> gNullEx = new GenericType<NullReferenceException>(new NullReferenceException());
            GenericType<IndexOutOfRangeException> gIndexEx = new GenericType<IndexOutOfRangeException>(new IndexOutOfRangeException());
            /*    GenericType<String> gString = new GenericType<string>("Error"); 에러 */
            Console.WriteLine(gNullEx.ToString());
            Console.WriteLine(gIndexEx.ToString());

        }
    }
}
