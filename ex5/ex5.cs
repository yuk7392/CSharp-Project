using System;
public delegate void MyEventHandler();

namespace ex5
{

    class Button
    {
        public event MyEventHandler Push;
        public void OhPush()
        {

            if (Push != null) Push();

        }



    }

    class EventHandlerClass
    {

        public void MyMethod()
        {

            Console.WriteLine("In the EventHandlerClass.MyMethod...");

        }

    }

    class ex5
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            EventHandlerClass obj = new EventHandlerClass();
            button.Push += new MyEventHandler(obj.MyMethod);
            button.OhPush();
        }
    }
}
