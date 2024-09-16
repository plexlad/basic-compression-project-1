//Group Project 1 - Compression
//Brock, Sergio, and Harry
//Starting 9/15
using System;

public class Compression
{
    public static void Main()
    {
        Console.WriteLine("hello guys, time to write some compression!!!");
        int[] j = MakeBinaryArray(50);
        Console.WriteLine();
        for (int a = 0; a < j.Length; a++)
        {
            Console.Write(j[a]);
        }
    }

    public static int[] MakeBinaryArray(int size)
    {
        Random rnd = new Random();
        int[] j = new int[size];
        for (int a = 0; a < size; a++)
        {
            j[a] = rnd.Next(0, 2);
        }
        return j;
    }

    //Harry's idea for compression!!! Super rough draft, but the idea is just take two or three
    //combinations of 1's and 0's and represent them somehow
    public static int[] HarryCompression(int[] b)
    {
        int[] a = b;
        return a;
    }

    public static int[] HarryDeCompression(int[] b)
    {
        int[] a = b;
        return a;
    }
}

public class BrockCompression: IBitStringCompressor
{
    Utility util = new Utility(true);

    public string Compress(string original)
    {
        return original;
    }

    public string Decompress(string original)
    {
        return original;
    }

    // Using lowest factor function allows us to
    // use chunks of the code that don't allow for data loss
    List<int> LargestFactor(int number)
    {
        // Iterate from 1 to the square root of the number
        // If number mod i is 0, return the factor
        // Stolen from Stack Overflow

        List<int> output = new() {1};
        int max = (int)Math.Sqrt(number);

        // Start at 2 to see
        for (int factor = 2; factor <= max; factor++)
        {
            if (number % factor == 0)
            {
                output.Add()
            }
        }

        // Closest error exception
        return largest;
    }

    // Turns the binary string into ASCII symbols for neater compression 
    string ConvertToSymbols(string input)
    {
        var factorList = LargestFactor(input.Length);
        // Chooses a length that is in the middle to create a size to work with
        int chunkSize = factorList[factorList.Count / 2];

        util.DebugMessage("This is cool");

        return input; // Does not work for now
    }
}

class Utility
{
    bool Debug { get; set; }
    // This class allows us to activate and deactivate debug messages
    public Utility(bool debug)
    {
        Debug = debug;
    }

    // Prints a message if in debug mode
    public void DebugMessage(string message)
    {
        if (Debug)
        {
            Console.WriteLine(message);
        }
    }
}

public interface IBitStringCompressor
{
    // Assumes input and output of '0' and '1'
    string Compress(string original);
    string Decompress(string compressed);
}