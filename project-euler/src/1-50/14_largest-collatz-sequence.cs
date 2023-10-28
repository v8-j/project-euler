// The following iterative sequence is defined for the set of positive integers:
// n -> n/2 (n is even)
// n -> 3n + 1 (n is odd)
// Using the rule above and starting with 13, we generate the following sequence:
// 13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1.
// It can be seen that this sequence (starting at 13 and finishing at 1) 
// contains 10 terms. Although it has not been proved yet (Collatz Problem), it 
// is thought that all starting numbers finish at 1.
// Which starting number, under one million, produces the longest chain?
// Once the chain starts the terms are allowed to go above one million.

class Largest_Collatz_Sequence
{
    public static void Run()
    {
        int longestChain = 0;
        long longestChainNumber = 0;
        int max = 1_000_000;

        for (int i = 2; i < max; ++i)
        {
            long currentNr = i;
            int chain = 0;
            
            while (currentNr != 1)
            {
                if (currentNr % 2 == 0)
                    currentNr /= 2;
                else
                    currentNr = (currentNr * 3) + 1;
                
                ++chain;
            }
            
            if (chain > longestChain)
            {
                longestChain = chain;
                longestChainNumber = i;
            }
        }

        Console.WriteLine($"The starting number with the longest chain of "
        + $"{longestChain} is {longestChainNumber}"
        );
    }
}