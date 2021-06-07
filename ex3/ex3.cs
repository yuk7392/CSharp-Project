using System;
delegate void DelegateOne();
delegate void DelegateTwo(int i);



namespace ex3{

    class delegateClass
    {
        public void MethodA()
        {

            Console.WriteLine("In The DelegateClass.MethodA...");

        }

        public void MethodB(int i)
        {

            Console.WriteLine("DelegateCalss.MethodB, i=" + i);

        }


    }



    class ex3
    {
        public static void Main()
        {

            delegateClass obj = new delegateClass();
            DelegateOne d1 = new DelegateOne(obj.MethodA);
            DelegateTwo d2 = new DelegateTwo(obj.MethodB);
            d1();
            d2(10);


        }

    }
    }