using System;
using System.Drawing;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack theStack = new Stack(4);
            theStack.push("Star Wars");
            theStack.push("Jaws");
            theStack.push("Jaws 2");
            theStack.push("Titanic");
            theStack.push("Rocky");

            Console.WriteLine("=================\nAbout to Peek:");
            Console.WriteLine("'" + theStack.peek() + "'" + " is at the top of the stack");

            Console.WriteLine("=================\nThe Stack Contains:\n");
            while (!theStack.isEmpty())
            {
                string movie = theStack.pop();
                Console.WriteLine(movie);
            }
        }
    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void push(string movie)
        {
            if (isFull())
            {
                Console.WriteLine("The stack is full");
            }
            else
            {
                top++;
                stackArray[top] = movie;
            }
        }

        public string pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("There is nothing to pop");
                return "";
            } else
            {
                int index = top;
                top--;
                return stackArray[index];
            }
        }

        public string peek()
        {
            return stackArray[top];
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }
    }
}
