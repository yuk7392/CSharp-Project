using System;

namespace EX6_2
{

    interface IGenericInterface<T>
    {
        void SetValue(T x);
        String GetValueType();


    }

    class GenericClass<T> : IGenericInterface<T>
    {

        private T value;
        public void SetValue(T x)
        {

            value = x;

        }

        public String GetValueType()
        {

            return value.GetType().ToString();
        }

    }


    class ex
    {
        static void Main(string[] args)
        {
            GenericClass<Int32> gInteger = new GenericClass<Int32>();
            GenericClass<String> gString = new GenericClass<String>();


            gInteger.SetValue(10);
            gString.SetValue("TEXT");
            Console.WriteLine(gInteger.GetValueType());
            Console.WriteLine(gString.GetValueType());

        }
    }
}
