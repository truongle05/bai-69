using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class FileUtility
{
	public static int CountLines(string filePath)
	{
		return File.ReadAllLines(filePath).Length;
	}

	public static int CountCharacters(string filePath, char character)
	{
		string content = File.ReadAllText(filePath);
		return Enumerable.Count<char>((IEnumerable<char>)content, (Func<char, bool>)((char c) => c == character));
	}

	public static int CountWords(string filePath)
	{
		string content = File.ReadAllText(filePath);
		string[] words = content.Split(new char[4] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
		return words.Length;
	}
}
