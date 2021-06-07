using System;

namespace ex4_13
{
    class Stack
    {
        private int[] stack;
        int sp = -1;
        public Stack(int size)
        {
            stack = new int[size];

        }

        public void Push(int data)
        {
            for (int i = 0; i < stack.Length; i++) { 
            if (stack[i] == 0)
            {
                sp = i;
                stack[sp] = data;
                    break;
            }
           }
            Console.WriteLine("Array[{0}] is set to {1}.", sp,data);
        }

        public int Pop() {
            stack[sp] = 0;
            return sp;
            sp--;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Stack obj = new Stack(100);
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            Console.WriteLine("Array[{0}] is replaced to 0.(Pop)", obj.Pop());

        }
    }
}
