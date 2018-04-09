using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("testing gihub in VS #1");
            Console.WriteLine("testing gihub in VS #2");
            Console.WriteLine("testing gihub in VS #n");
            Console.WriteLine("another line created to branch1 locally in VS");
            Console.WriteLine("new line added online");
        }
    }
}
