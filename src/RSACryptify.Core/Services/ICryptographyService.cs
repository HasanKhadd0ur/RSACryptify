using RSACryptify.Core.Abstraction;
using System;

namespace RSACryptify.Core.Services
{
    public interface ICryptographyService
    {
        public string Encrypt(string plainText, Key publickKey);
        public string Decrypt(string cipherText, Key privateKey);

    }
}
