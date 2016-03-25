using System.IO;
using System.Security.Cryptography;

namespace CSharpStandardLibrary.Hash
{
    public static class Md5Hash
    {
        public static byte[] GetHashFromFileName(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    return md5.ComputeHash(stream);
                }
            }
        }
    }
}