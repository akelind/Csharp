using System;
using System.Collections.Generic;
namespace ClasesAndObjects
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Memory.Memorytest();
            Grades.CalcAvragegrade();
        }
        
    }
    public class Grades
    {
            public static void CalcAvragegrade()
            {
                List<double> dnumbers = new List<double>();
                dnumbers.Add(33.34);
                dnumbers.Add(33.35);
                dnumbers.Add(33.36);

                double dsum = 0.0;    
                foreach (var dnumber in dnumbers)
                
                {
                    dsum += dnumber;    
                    System.Console.WriteLine($"Numbers in the list:{dnumber}" );
                    System.Console.WriteLine($"Sum of all numbers:{dsum} \n");
                }
                   //System.Console.WriteLine(); 

            } 
    }


    /*public class Memory
    {
        public static void Memorytest()
            {
                System.Console.WriteLine("I remeber how to make classes but what about objects, maybe of a car?");
            }
    }
    */
}
