using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RSACryptify.Core.Abstraction
{
    public class KeyPair
    {
        public BigInteger PublicKeyExponent { get; set; } // Public key exponent (e)
        public BigInteger PrivateKeyExponent { get; set; } // Private key exponent (d)
        public BigInteger Modulus { get; set; } // Modulus (n)
    }

}

