using RSACryptify.Core.utilities;
using System;
using System.Numerics;

namespace RSACryptify.Application
{
    public class RandomNumberService : IRandomNumberService
    {
        private readonly Random _random = new Random();

        public BigInteger GeneratePrimeNumber(BigInteger min, BigInteger max)
        {
            while (true)
            {
                var candidate = GenerateRandomNumber(min, max);
                if (IsPrime(candidate)) return candidate;
            }
        }

        public BigInteger GenerateRandomNumber(BigInteger min, BigInteger max)
        {
            return new BigInteger(_random.Next((int)min, (int)max));
        }

        private bool IsPrime(BigInteger number)
        {
            if (number < 2) return false;
            for (BigInteger i = 2; i <= BigInteger.Pow(number, 1 / 2); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
