// 2520 is the smallest number that can be divided by each of the numbers from
// 1 to 10 without any remainder.
// What is the smallest positive number that is evenly divisible by all of the
// numbers from 1 to 20? 

// This is a bad solution, but i'm bad at math so

class Smallest_Multiple 
{
    public static void Run()
    {
        bool found = false;
        int value = 2520; // Might as well start here if we bruting it

        // Brute force method <3
        while (!found)
        {
            value += 2; // The upper reaches of my math knowledge and understanding. 
            // for obvious (even to me) reasons we dont need to check 1-10
            for (int j = 11; j <= 20; ++j)
            {
                if (value % j != 0)
                    break;

                if (j == 20)
                    found = true;
            }
        }

        Console.WriteLine(
            $"The lowest common multiple of numbers 1-20 is {value}"
            );
        
    }
}
