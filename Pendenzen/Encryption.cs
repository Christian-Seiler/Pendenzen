﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace Pendenzen
{
    public class Encryption
    {
        public string encrypt(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException("plainText");

            //encrypt data
            var data = Encoding.ASCII.GetBytes(plainText);
            data = new SHA256Managed().ComputeHash(data);
            return Encoding.ASCII.GetString(data);
        }

        public string decrypt(string cipher)
        {
            if (cipher == null) throw new ArgumentNullException("cipher");

            //parse base64 string
            var data = Convert.FromBase64String(cipher);

            //decrypt data
            var decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(decrypted);
        }
    }
}