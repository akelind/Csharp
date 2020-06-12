using System;

namespace DebugTestDotNetRun
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
            Console.WriteLine("Sovrum");
            }
        }
    }
}

