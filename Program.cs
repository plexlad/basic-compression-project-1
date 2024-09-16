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
    public string Compress(string original)
    {
        return original;
    }

    public string Decompress(string original)
    {
        return original;
    }
}

public interface IBitStringCompressor
{
    string Compress(string original);
    string Decompress(string compressed);
}