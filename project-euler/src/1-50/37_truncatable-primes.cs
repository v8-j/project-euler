// The number 3797 has an interesting property. Being prime itself, it is 
// possible to continuously remove digits from left to right, and remain prime
// at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left
// 3797, 379, 37, and 3.
// Find the sum of the only eleven primes that are both truncatable from left to
// right and right to left.
// NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.

class Truncatable_Primes
{
        static bool IsPrime(long[] primes, int n)
    {
        if (n < 2)
            return false;
        if (n == 2)
            return true;
        if (n % 2 == 0)
            return false;

        for (int i = 0; i < primes.Length; ++i)
        {
            if (primes[i] == n)
                return true;

            if (primes[i] > n)
                break;
        }
        return false;
    }

    public static void Run()
    {
        // calculate the first 'nrPrimes' prime numbers.
        int nrPrimes = 100_000;
        long [] primes = new long[nrPrimes];
        primes[0] = 2;

        for (int i = 3, n = 1; n < nrPrimes; i += 2)
        {
            bool isPrime = true;

            for (int j = 0; j < n; ++j)
            {
                if (i % primes[j] == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primes[n++] = i;
            }
        }

        int count = 0; // once we reach 11 we can finish
        long total = 0;
        

        for (int i = 4; count < 11; ++i) // start at 5th (i=4) prime number = 11
        {
            long prime = primes[i];
            string s = prime.ToString();

            bool truncLeft = true;
            for (int j = 1; j< s.Length; ++j)
            {
                string sub = s.Substring(j);
                int n = int.Parse(sub);
                if(!IsPrime(primes, n)) {
                    truncLeft = false;
                    break;
                }
            }

            if (!truncLeft)
                continue;

            bool truncRight = true;
            for (int j = s.Length - 1; j > 0; --j)
            {
                string sub = s.Substring(0, j);
                int n = int.Parse(sub);
                if (!IsPrime(primes, n)) {
                    truncRight = false;
                    break;
                }
            }

            if (!truncRight)
                continue;

            //Console.WriteLine($"Bi-directional truncatable prime {prime}");
            total += prime;
            count++;

        }

        Console.WriteLine(
            $"The sum of bi-directionally truncatable primes is {total}");
    }
}
