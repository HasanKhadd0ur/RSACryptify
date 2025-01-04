using RSACryptify.Core.Abstraction;
using RSACryptify.Core.Services;
using RSACryptify.Core.utilities;
using System.Numerics;

namespace RSACryptify.Application
{
    public class KeysService : IKeysService
    {
        private readonly IRandomNumberService _randomNumberService;
        private readonly NumericalService _numericalService;

        // Constructor to inject the random number service.
        public KeysService(IRandomNumberService randomNumberService, NumericalService numericalservice)
        {
            _randomNumberService = randomNumberService;
            _numericalService = numericalservice;
        }

        public Key GeneratePrivateKey(BigInteger modulus)
        {
            var p = _randomNumberService.GeneratePrimeNumber(100, 500);
            var q = _randomNumberService.GeneratePrimeNumber(100, 500);
            while (p == q)
            {
                q = _randomNumberService.GeneratePrimeNumber(100, 500);
            }

            var n = p * q;
            var phi = (p - 1) * (q - 1);

            BigInteger e;
            do
            {
                e = _randomNumberService.GenerateRandomNumber(2, phi);
            } while (_numericalService.GCD(e, phi) != 1);

            var d =_numericalService.ModInverse(e, phi);

            return new Key { KeyExponent = d, Modulus = n };
        }

        public Key ExtractPublicKey(Key privateKey)
        {
            return new Key
            {
                KeyExponent = privateKey.KeyExponent,
                Modulus = privateKey.Modulus
            };
        }

    }


}
