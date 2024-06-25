using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
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
        using (StreamReader sr = new StreamReader(path))
        {
            while (sr.ReadLine() != null) 
            {
                string content = sr.ReadToEnd();
                // Dela upp strängen i ord med hjälp av mellanslag, tabbar och nya rader som separatorer
                string[] words = content.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                wordCount = words.Length;
            }
        }
        return $"{wordCount} {path}";
    }
}