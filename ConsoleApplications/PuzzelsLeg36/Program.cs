using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
					
public class Program
{
	public static void Main()
	{
		
        StreamReader sr = new StreamReader("D:\\CSharp2020\\ConsoleApplications\\PuzzelsLeg36\\leq36.txt");
        string data = sr.ReadToEnd();      
        string[] words = data.Split(',');

		Console.WriteLine(string.Join(", "+"\n", Get4PuzzlePieces(words)));
        //Console.WriteLine("[{0}]"+"\n", string.Join(", ", Get4PuzzlePieces(words)));
	}
	
	public static string[] Get4PuzzlePieces(string[] words)
	{
		Regex rgx = new Regex("[^a-zA-Z]");
		List<string> _4PuzzlePiecesLetters = new List<string>();
		for (int i = 0; i < words.Length; i++)
		{
			string word = rgx.Replace(words[i]+"\n", "");
			if (!string.IsNullOrEmpty(word) && word.Length <=4 )
			{
				_4PuzzlePiecesLetters.Add(words[i]);
			}
			
		}
			
		return _4PuzzlePiecesLetters.ToArray();
	}
}