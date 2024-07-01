using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ccwc;

internal class CLIMethods
{
    public static string CountLines(string path)
    {
        int count = 0;
        using (StreamReader sr = new StreamReader(path))
        {
            while (sr.ReadLine() != null)
            {
                count++;
            }
        }
        return $"{count} {path}";
    }

    internal static readonly char[] separator = [' ', '\t', '\r', '\n'];

    public static string CountWords(string path)
    {
        int wordCount = 0;
        using (StreamReader reader = new StreamReader(path))
        {
            string content = reader.ReadToEnd();
            // Använd en regex för att matcha ord och räkna dem
            wordCount = Regex.Matches(content, @"\b\w+\b").Count;
        }
        return $"{wordCount} {path}";
    }
}