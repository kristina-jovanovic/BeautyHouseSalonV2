using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class HashFunction
    {
        int saltLength = 32;
        public byte[] GenerateSalt()
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[saltLength];
                randomNumberGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        public string HashDataWithRounds(byte[] password, byte[] salt, int rounds)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(password, salt, rounds))
            {
                return Convert.ToBase64String(rfc2898.GetBytes(32));
            }
        }

        public static string HashPassword(string password, byte[] salt)
        {
            int numberOfIterations = 99;
            HashFunction hashFunction = new HashFunction();

            string hashedPassword = hashFunction.HashDataWithRounds(Encoding.UTF8.GetBytes(password), salt, numberOfIterations);
            //Debug.WriteLine("----PASS:" + hashedPassword);

            return hashedPassword;
        }

        public static byte[] GenerateCode()
        {
            HashFunction hashFunction = new HashFunction();
            byte[] salt = hashFunction.GenerateSalt();
            return salt;
        }

    }
}
