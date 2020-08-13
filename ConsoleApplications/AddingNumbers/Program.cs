using System;
using System.Collections.Generic;

namespace FirstSetupGithub
{
    class Program
    {
        /* //Return the Sum of Two Numbers
        public static (int,int,int) Sum(int a,int b,int c) 
    {
       
        a = 3+2;
        b = -3+-6;
        c = 7+3;      
        return (a,b,c);    
    }
    */
    
    //Convert Minutes into Seconds
    public static (int,int,int) Mintosec(int fMin,int trMin,int twMin) 
    {
        fMin =5*60;    
        trMin=3*60;
        twMin=2*60;
        
        return (fMin,trMin,twMin);    
    }
    
        public static void Main(string[] args)
        {
            // 5min * 60 sek = 300
            // 3min * 60 sek = 180
            // 2min * 60 sek = 120
            
            //int total_minToSec = 5;    
            //int minutes = total_minToSec * 60;
            
            int fMin=0,trMin=0,twMin=0;
            System.Console.WriteLine(Mintosec(fMin,trMin,twMin));


        /*
        //Return the Sum of Two Numbers   
            int a = 0;
            int b = 0;
            int c = 0;
            System.Console.WriteLine(Sum(a,b,c));
        */

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
            /*    
            var dnumbers = new List<double>(){5.1,6.3,12.6};
            dnumbers.Add(11.7);
            double dresult = 0.0;
            */

            /*
            // Shows the list numbers and sums them up i each CW statement.    
            foreach (var item in dnumbers)
            {
                dresult +=item;
                System.Console.WriteLine("Printing out the list of items(doubles): /n "+ item);
                System.Console.WriteLine("Printing out the sum of the list of items(doubles): /n "+ dresult);
            }
            */
            /*
            // Calculate the avrage grade of the above numbers    
            foreach (var dnumber in dnumbers)
            {
                dresult +=dnumber;    
            }
            dresult = dresult / dnumbers.Count;
            System.Console.WriteLine($"Printing out the avrage number of the list of items(doubles) is: {dresult}");
        */
            
        }

    }
}
