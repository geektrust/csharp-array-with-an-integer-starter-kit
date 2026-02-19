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
        var parts = rawInput.Trim().Split([" | "], StringSplitOptions.None);

        if (parts.Length < 2)
        {
            return ([], 0);
        }
        var arrStr = parts[0];
        var i = int.Parse(parts[1].Trim());
        var arr = arrStr.Split([','], StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x.Trim()))
                            .ToList();
        return (arr, i);
    }
}
