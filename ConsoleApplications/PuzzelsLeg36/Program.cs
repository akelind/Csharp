using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
					
public class Program
{
	public static void Main()
	{
		
    StreamReader sr = new StreamReader("D:\\CSharp2020\\ConsoleApplications\\PuzzelsLeg36\\leqn20.txt");
    string data = sr.ReadToEnd();      
    string[] words = data.Split(',');

  	Console.WriteLine(string.Join(", "+"\n",Get4PuzzlePieces(words)));

	}
	
	public static string[]Get4PuzzlePieces(string[] words)
	{
     	Regex rgx = new Regex("[^a-zA-Z0-9]");
		List<string> _4PuzzleLetters = new List<string>();
		  
        
		for (int i = 0; i < words.Length; i++)
		{
			string checkingletters = rgx.Replace(words[i]+"\n", "");
			

            if (!string.IsNullOrEmpty(checkingletters) && checkingletters.Length >=4 && checkingletters.Length <=4)
			{	
			    	  _4PuzzleLetters.Add(words[i]); 		
			}
					            
            if (checkingletters.Length !=4)
            {
                System.Console.WriteLine("Wrong amout of letters in the file. Check the file. No solution is found.");
                break;               
            }			
		}
        return _4PuzzleLetters.ToArray();          
	}
}