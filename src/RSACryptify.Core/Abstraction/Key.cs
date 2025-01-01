using System.Numerics;

namespace RSACryptify.Core.Abstraction
{
    public class Key
    {
        public BigInteger KeyExponent { get; set; } // Private key exponent (d)
        public BigInteger Modulus { get; set; } // Modulus (n)

    }
}
