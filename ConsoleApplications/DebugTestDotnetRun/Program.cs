using System;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0 )
            {                
            Console.WriteLine($"Var{args [0]}");
            }
            else
            {
            Console.WriteLine("Kvällsmiddag");
            }
        }
    }
}

