namespace ccwc;

internal class Program
{
    static void Main()
    {
        do
        {
            var lineInput = Console.ReadLine();

            lineInput.ToLower();

            if (lineInput.Contains("ccwc"))
            {
                var extractedfilename = lineInput.Remove(0, 8);
                var fileinfo = new FileInfo(extractedfilename);
                if (fileinfo.Exists)
                {
                    if (lineInput.Contains("-c"))
                    {

                        var fileBytes = fileinfo.Length;
                        Console.WriteLine($"{fileBytes} {extractedfilename}");
                    }
                    if (lineInput.Contains("-l"))
                    {
                        Console.WriteLine(CLIMethods.CountLines(extractedfilename));
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }
            }
        } while (true);
    }
}
