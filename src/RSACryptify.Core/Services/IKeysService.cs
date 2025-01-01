using RSACryptify.Core.Abstraction;
using System.Numerics;

namespace RSACryptify.Core.Services
{
    public interface IKeysService
    {
        Key GeneratePrivateKey(BigInteger Modulus);
        Key ExtractPublicKey(Key privateKey); // Extracts the public key from the private key.
    }



}

