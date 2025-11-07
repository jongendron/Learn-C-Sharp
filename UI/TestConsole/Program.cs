namespace TestConsole;

public class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        Dictionary<string, string?> argMap = new Dictionary<string, string?>();

        while (i < args.Length)
        {
            string? curArg = null;

            // Console.WriteLine($"Argument {i}: {args[i]}");    
            if (args[i] == "--output" | args[i] == "-o")
            {
                curArg = "outputFilePath";
            }
            else if (args[i] == "--input" | args[i] == "-i")
            {
                curArg = "inputFilePath";
            }

            if (curArg != null)
            {
                if (i + 1 >= args.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                if (!args[i + 1].StartsWith("-"))
                {
                    argMap.Add(curArg, args[i + 1]);
                    i++;

                }
            }
            i++;

        }

        foreach(string key in argMap.Keys)
        {
            Console.WriteLine($"{key}: {argMap[key]}");
        }
    }
}