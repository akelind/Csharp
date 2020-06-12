using System;

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

            
            var arrnum = new[]{33.99,33.99,33.99};
            var rarrnum = 0.0;
            foreach (var ddn in arrnum)
            {
                 rarrnum +=ddn;   
            }
            System.Console.WriteLine(rarrnum);
            
            
        }
    }
}
