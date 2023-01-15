/*
 * https://www.codechef.com/problems/FLIPCARDS
 * C:\Users\Karm\Documents\Dev\CodeChef\641-FLIPCARDS\Problem.pdf
 * file:///C:/Users/Karm/Documents/Dev/CodeChef/641-FLIPCARDS/Problem.pdf
 * 
*/

using System;

public class CC0641_FlipCards
{
    public static void Run()
    {
        //Console.WriteLine("Testing... MATH641");
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int[] z = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine(Math.Min(z[0] - z[1], z[1]));
        }
    }
}