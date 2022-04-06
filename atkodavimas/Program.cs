using System;

namespace EncryptionDecryptionUsingSymmetricKey
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "sdsasdawefasdfg90809as8df90a8sdf";

            Console.WriteLine("Įveskite užkoduota eilutę:");
            var encryptedString = Console.ReadLine();
            var decryptedString = AesOperation.DecryptString(key, encryptedString);
            Console.WriteLine($"Iššifruota eilutė = {decryptedString}");

            Console.ReadKey();
        }
    }
}