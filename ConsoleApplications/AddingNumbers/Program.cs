using System;
using System.Collections.Generic;

namespace FirstSetupGithub
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double Fx= 33.33;
            double Fy= 33.33;
            var rd=Fx+Fy;
           Console.WriteLine("Som of all float numbers are: " + rd);
            */

            /*
            var numbers = new double[3];
            numbers [0] = 33.66;
            numbers [1] = 33.66;
            numbers [2] = 33.66;

            var rda= numbers[0];
            rda = rda + numbers[1];
            rda = rda + numbers[2];

            System.Console.WriteLine(rda);
            */

            /*
            var arrnum = new[]{33.99,33.99,33.99};
            var rarrnum = 0.0;
            foreach (var ddn in arrnum)
            {
                 rarrnum +=ddn;   
            }
            System.Console.WriteLine(rarrnum);
            */

            var dnumbers = new List<double>(){5.1,6.3,12.6};
            dnumbers.Add(11.7);
            double dresult = 0.0;
            
            /*
            // Shows the list numbers and sums them up i each CW statement.    
            foreach (var item in dnumbers)
            {
                dresult +=item;
                System.Console.WriteLine("Printing out the list of items(doubles): /n "+ item);
                System.Console.WriteLine("Printing out the sum of the list of items(doubles): /n "+ dresult);
            }
            */

            // Calculate the avrage grade of the above numbers    
            foreach (var dnumber in dnumbers)
            {
              
                dresult +=dnumber;
                 
            }
            dresult = dresult / dnumbers.Count;
             
            System.Console.WriteLine("Printing out the avrage number of the list of items(doubles): /n "+ dresult);
        }
    }
}
