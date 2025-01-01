using System.Numerics;

namespace RSACryptify.Core.utilities
{
    public interface IRandomNumberService
    {
        BigInteger GeneratePrimeNumber(BigInteger min, BigInteger max); // Generates a random prime number within the range.
        BigInteger GenerateRandomNumber(BigInteger min, BigInteger max); // Generates a random number within the range.
    }
}
