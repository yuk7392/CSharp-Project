using System;

namespace EX6_8
{

    public class MyAttrAttribute : Attribute
    {
        public MyAttrAttribute(String message)
        {

            this.message = message;

        }

        private String message;
        public String Message
        {

            get { return message;  }

        }


    }

    [MyAttr("This is Attribute test.")]
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Program);

            object[] arr = type.GetCustomAttributes(typeof(MyAttrAttribute), true);
            if (arr.Length == 0) Console.WriteLine("This class has no custom attrs.");
            else
            {

                MyAttrAttribute ma = (MyAttrAttribute)arr[0];
                Console.WriteLine(ma.Message);

            }


        }
    }
}
