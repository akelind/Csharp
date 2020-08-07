using System;
using System.IO;
using System.Data;

namespace PuzzelsLeg36
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            String line;
try
{
    //Pass the file path and file name to the StreamReader constructor
    //StreamReader sr = new StreamReader("C:\\test\\Sample.txt");
    StreamReader sr = new StreamReader("D:\\CSharp2020\\ConsoleApplications\\PuzzelsLeg36\\leq36.txt");
     string data = sr.ReadToEnd();      
      //sr.Close();
 
      string[] values = data.Split(',');
 
      for (int i = 0; i < values.Length; i++)
      {
        //MessageBox.Show(values[i]);
        System.Console.WriteLine((values[i]));
      }
    
    //Read the first line of text
    line = sr.ReadLine();
    //Continue to read until you reach end of file
    while (line != null)
    {
        //write the lie to console window
        Console.WriteLine(line);
        //Read the next line
        line = sr.ReadLine();
    }
    //close the file
    sr.Close();
    Console.ReadLine();
}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}


        }
    }
}