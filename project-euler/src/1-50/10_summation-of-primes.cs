// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
// Find the sum of all the primes below two million.

// Again borrowing my garbo prime calculation, except rather than finding the
// first n primes, finding all primes with a value less than n
class Summation_of_Primes
{
        public static void Run()
    {
        int maxPrime = 2_000_000; // Upper threshold

        List<long> primes = new List<long>();
        primes.Add(2);

        // i+=2 since no point eval even numbers
        for (int i = 3; ; i += 2) 
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
                // think this is better here rather than checking i every iteration
                if (i >= maxPrime) 
                    break;

                primes.Add(i);
                
            }

        }

        long total = 0;
        for (int i = 0; i < primes.Count; ++i)
        {
            total += primes[i];
        }
        
        Console.WriteLine(
            $"The sum of all primes less than {maxPrime} is {total}"
            );
    }
}