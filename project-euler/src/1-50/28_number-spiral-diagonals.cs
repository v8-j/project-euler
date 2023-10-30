// Starting with the number 1 and moving to the right in a clockwise direction a
// 5 by 5 spiral is formed as follows:
// 21 22 23 24 25
// 20 7  8  9  10
// 19 6  1  2  11
// 18 5  4  3  12
// 17 16 15 14 13
// It can be verified that the sum of the numbers on the diagonals is 101.
// What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral 
// formed in the same way?

class Number_Sprial_Diagonals
{
    public static void Run()
    {
        // Create table
        int tabSize = 1001;
        int[][] table = new int[tabSize][];
        for (int i = 0; i < tabSize; ++i)
            table[i] = new int[tabSize];

        // Populate table, spiraling out from the middle
        int cur = 1;                    // current value to write in table
        int max = tabSize * tabSize;    // maximum number (exit condition)
        int steps = 1;                  // steps to move before change direction
        int x, y;                       // current cell in the table
        x = y = tabSize / 2;            // initially the centre of table
        table[y][x] = cur;
        while (true)
        {
            // go right
            for (int i = 0; i < steps && cur < max; ++i)
                table[y][++x] = ++cur;

            // The last step is always rightwards, so check for exit here. Note 
            // that the for previous for loop checks if we are less than max
            if (cur == max)
                break;

            // go down
            for (int i = 0; i < steps; ++i)
                table[++y][x] = ++cur;

            // increment number of steps for each direction
            ++steps;

            // go left
            for (int i = 0; i < steps; ++i)
                table[y][--x] = ++cur;

            // go up
            for (int i = 0; i < steps; ++i)
                table[--y][x] = ++cur;

            // increment number of steps for each direction
            ++steps;
        }

        // Print table
        // for (y = 0; y < tabSize; ++y)
        // {
        //     for (x = 0; x < tabSize; ++x)
        //         Console.Write(table[y][x] + "\t");
        //     Console.WriteLine();
        // }

        // Find sum of diagonals
        int sum = -1; // Negate 1 since counting each diagonal counts the 1 twice
        for (int n = 0; n < tabSize; ++n)
        {
            sum += table[n][n];               // Top left to bottom right
            sum += table[n][tabSize - 1 - n]; // Top right to bottom left
        }

        Console.WriteLine("The sum of the diagonals on a spiral grid "
        + $"{tabSize}x{tabSize} in size is {sum}");

    }
}