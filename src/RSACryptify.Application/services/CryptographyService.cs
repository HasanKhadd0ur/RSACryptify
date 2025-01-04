using System;
using System.Linq;
using System.Numerics;
using System.Text;
using RSACryptify.Core.Abstraction;
using RSACryptify.Core.Services;

public class CryptographyService : ICryptographyService
{
    public string Encrypt(string plainText, Key publicKey)
    {
        var plainBytes = Encoding.UTF8.GetBytes(plainText);
        var cipherBytes = plainBytes.Select(b => BigInteger.ModPow(b, publicKey.KeyExponent, publicKey.Modulus)).ToArray();
        return Convert.ToBase64String(cipherBytes.SelectMany(b => b.ToByteArray()).ToArray());
    }

    public string Decrypt(string cipherText, Key privateKey)
    {
        var cipherBytes = Convert.FromBase64String(cipherText);
        var plainBytes = cipherBytes.Select(b => BigInteger.ModPow(b, privateKey.KeyExponent, privateKey.Modulus)).ToArray();
        return Encoding.UTF8.GetString(plainBytes.SelectMany(b => b.ToByteArray()).ToArray());
    }
}
