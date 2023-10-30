// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143?

using System.ComponentModel;
using System.Globalization;

class Largest_prime_factor
{

    public static void Run()
    {
        long target = 600851475143;

        int nrPrimes = 10000; // calculate the first 'nrPrimes' prime numbers.

        List<int> primes = new List<int>();
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

        // Now we have the first 10000 primes, lets hope one of these are the largest

        long largest = -1;

        for (int i = 0; i < nrPrimes; ++i)
        {
            if (target % primes[i] == 0)
            {
                largest = primes[i];
            }
        }
        
        Console.WriteLine($"The largest prime factor of {target} is {largest}");



    }
}