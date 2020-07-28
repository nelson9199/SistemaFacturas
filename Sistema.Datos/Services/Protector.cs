using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Sistema.Datos.Services
{
    public class Protector : IProtector
    {
        public string SaltAndHashPassword(string password, string salt)
        {
            var sha = SHA256.Create();
            var saltedPassword = password + salt;
            return Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword)));
        }
    }
}

