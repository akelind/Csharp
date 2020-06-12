using System;

namespace DebugTestDotNetRun
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0 )
            {                
            Console.WriteLine($"Var{args [0]}"); /*"args": ["Dags","Mat"],* = Man kan skriva in detta i jason filen, i launch filen*/ 
            }
            else
            {
            Console.WriteLine("Sovrum");
            }
        }
    }
}

