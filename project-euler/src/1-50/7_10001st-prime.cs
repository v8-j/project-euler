// By listing the first six prime numbers: 2, 3, 5, 7, 11$, and 13, we can see 
// that the 6th prime is 13.
// What is the $10\,001$st prime number?

// I needed to calculate prime numbers in a previous challenge, so I just copied
// my code from there. I'll revisit this if I ever get better at math.

class _10001st_Prime
{
    public static void Run()
    {
        int nrPrimes = 10001; // calculate the first 'nrPrimes' prime numbers.

        List<long> primes = new List<long>();
        primes.Add(2);

        // i+=2 since no point eval even numbers
        for (int i = 3, n = 1; n <= nrPrimes; i += 2) 
        {
            bool isPrime = true; // assume number is prime

            for (int j = 0; j < primes.Count; ++j)
            {
                // if i is divisible by any of the primes, it must not be a prime it self!
                if (i % primes[j] == 0)     
                {                           
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primes.Add(i);
                ++n;
            }

        }

        long _10001stPrime = primes[10_000];

        Console.WriteLine($"The 10001st prime number is {_10001stPrime}");

    }
}
