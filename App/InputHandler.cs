public class InputHandler
{
    public static (List<int>, int) ParseInput(string[] args)
    {
        /*
            ***********************************************
            * This method expects exactly one argument     *
            * in the format: dotnet run "<array> | i"        *
            ***********************************************
        */
        if (args.Length == 0)
        {
            throw new ArgumentException("No command line arguments passed.");
        }
        var rawInput = args[0];
        var parts = rawInput.Split('|');
        if (parts.Length < 2)
        {
           throw new ArgumentException("Input string must contain '|' separator.");
        }
        var times = parts[0].Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x.Trim()))
                            .ToList();
        var w = int.Parse(parts[1].Trim());
        return (times, w);
    }
}