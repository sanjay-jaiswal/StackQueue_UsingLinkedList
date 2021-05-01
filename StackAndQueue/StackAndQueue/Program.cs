using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Welcome To Stack And Queue Program Using Linked List=====================");

            Stack stackOBJ = new Stack();

            //Pushing(adding) elements one by one.
            //Top elements will be 50.
            stackOBJ.Push(70);
            stackOBJ.Push(30);
            stackOBJ.Push(56);

            //Displaying stack.
            stackOBJ.DisplayStackElements();

            Console.WriteLine();
            stackOBJ.Peek();
            stackOBJ.Pop();
            stackOBJ.IsEmpty();
            stackOBJ.DisplayStackElements();

        }
    }
}
