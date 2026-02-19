using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    /*
        ***********************************************
        * This is the driver code. Don't change it!!! *
        ***********************************************

        Format of the 'args' <array> | i"
        Example: dotnet run "30, 10, 20 | 60"

        The code evaluator will execute this code using the command:
        dotnet run "30, 10, 20 | 60"
    */

    static void Main(string[] args)
    {
        try
        {
            var (times, w) = InputHandler.ParseInput(args);
            Handle(times, w);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private static void Handle(List<int> arr, int i)
    {
        /*
            ***********************************************
            * Your main logic implementation starts here! *
            ***********************************************

            'inputs' is a List<string> that contains:
            - times string at index 0
            - W string at index 1

            You can parse these into specific types as needed.
        */
        // Print integer i
        Console.WriteLine("i: " + i);

        // Print full list
        Console.WriteLine("arr: " + string.Join(", ", arr));
        // TODO: Add your core logic here
        Console.WriteLine("No feasible order group.");
    }
}
