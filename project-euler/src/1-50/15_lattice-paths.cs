// Starting in the top left corner of a 2 * 2 grid, and only being able to move 
// to the right and down, there are exactly 6 routes to the bottom right corner.
// How many such routes are there through a 20 * 20 grid?

using System.Numerics;

class Lattice_Paths
{
    static BigInteger factorial(int n)
    {
        if (n == 0) return 1;

        BigInteger output = 1;
        int mult = 1;
        while (mult < n)
        {
            output *= ++mult;
        }
        return output;
    }

    public static void Run()
    {
        // I had no idea how to tackle this. I worked out nr of combinations
        // by drawing 3 and 4(!) grid out. I recognised the pattern but didnt 
        // know where from. Turns out its the center numbers in pascals 
        // triangle, which is also in the article below! It was one of the first
        // things I ever programmed in Java, a few years back. However I used a
        // combinatorics formula to calculate in this program.
        // https://stemhash.com/counting-lattice-paths/
        // nCk = n! / ((n-k)! * k!)

        // Print number of possible moves for grid sizes 1 - 20
        // for (int i = 1; i <= 20; ++i)
        // {
        //     int gridSize = i;
        //     int nrMoves = gridSize * 2;           
        //     BigInteger answer = factorial(nrMoves) / (factorial(nrMoves - gridSize) * factorial(gridSize));
        //     Console.WriteLine($"The number of possible moves in a {gridSize}^2 grid is = {answer}");
        // }

        int gridSize = 20;
        int nrMoves = gridSize * 2;
        BigInteger answer = factorial(nrMoves) / (factorial(nrMoves - gridSize) * factorial(gridSize));
        Console.WriteLine($"The number of possible moves in a {gridSize}^2 grid is = {answer}");

    }
}