using System;
using System.Security.Cryptography;
using System.Text;


namespace Pendenzen
{
    class Encryption
    {
        public string Encrypt(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException("plainText");

            //encrypt data
            byte[] data = Encoding.ASCII.GetBytes(plainText);
            data = new SHA256Managed().ComputeHash(data);
            return Encoding.ASCII.GetString(data);
        }

        public string Decrypt(string cipher)
        {
            if (cipher == null) throw new ArgumentNullException("cipher");

            //parse base64 string
            byte[] data = Convert.FromBase64String(cipher);

            //decrypt data
            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(decrypted);
        }
    }
}
