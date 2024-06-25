using System;
using System.Collections.Generic;
using System.Linq;
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
}