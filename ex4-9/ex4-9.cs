using System;
delegate String delegateOne(int i);

class delegateTest
{

    public string MethodA(int i)
    {
        return string.Format("int value = {0}",i);

    }


}

namespace ex4_9
{
    class Program
    {
        static void Main(string[] args)
        {

            delegateTest obj = new delegateTest();
            delegateOne d1 = new delegateOne(obj.MethodA);

            String s = d1(10);
            Console.WriteLine(s);


        }
    }
}
