using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select encryption algorithm: 1. AES  2. DES  3. Caesar Cipher");
            int choice = int.Parse(Console.ReadLine());

            Encryption encryption = new Encryption();

            switch (choice)
            {
                case 1:
                    encryption.SetEncryptionMethod(new AesEncryptionMethod());
                    break;
                case 2:
                    encryption.SetEncryptionMethod(new DesEncryptionMethod());
                    break;
                case 3:
                    Console.Write("Enter Caeser Cypher shift value: ");
                    int shift = int.Parse(Console.ReadLine());
                    encryption.SetEncryptionMethod(new CaeserCypherMethod(shift));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            //E:\\Study Materials\\Academics\\Fifth Semester\\Design Pattern\\LabTask1\\input.txt
            Console.Write("Enter the file path: ");
            try
            {
                string filePath = Console.ReadLine();
                string fileContents = File.ReadAllText(filePath);

                Console.WriteLine();
                Console.WriteLine("File Contents:");

                Console.WriteLine();
                Console.WriteLine("**********");
                Console.WriteLine(fileContents);
                Console.WriteLine("**********");
                Console.WriteLine();

                Console.ReadKey();

                string encrypted = encryption.Encrypt(fileContents);
                File.WriteAllText(filePath + ".enc", encrypted);
                Console.WriteLine("Encrypted file saved.");
                Console.ReadKey();

                string decrypted = encryption.Decrypt(encrypted);
                File.WriteAllText(filePath + ".dec", decrypted);
                Console.WriteLine("Decrypted file saved for validation.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
        }
            
    }
}
