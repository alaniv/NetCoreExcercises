using System;
using static System.Console;
using System.Security.Cryptography;
namespace RandomizingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("How big do you want the key (in bytes): ");
            string size = ReadLine();
            byte[] key = GetRandomKeyOrIV(int.Parse(size));
            WriteLine($"Key as byte array:");
            for (int b = 0; b < key.Length; b++)
            {
                Write($"{key[b]:x2} ");
                if (((b + 1) % 16) == 0) WriteLine();
            }
            WriteLine();
        }

        public static byte[] GetRandomKeyOrIV(int size)
        {
            var r = RandomNumberGenerator.Create();
            var data = new byte[size];
            r.GetNonZeroBytes(data);
            // data is an array now filled with
            // cryptographically strong random bytes
            return data;
        }
    }
}
