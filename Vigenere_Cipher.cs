using System;

namespace VigenereCipher
{
	class Program
	{
		private static int Mod(int a, int b)
		{
			return (a % b + b) % b;
		}

		private static string Cipher(string input, string key, bool encipher)
		{
			for (int i = 0; i < key.Length; ++i)
				if (!char.IsLetter(key[i]))
					return null; // Error

			string output = string.Empty;
			int x = 0;

			for (int i = 0; i < input.Length; ++i)
			{
				if (char.IsLetter(input[i]))
				{
					bool cIsUpper = char.IsUpper(input[i]);
					char offset = cIsUpper ? 'A' : 'a';
					int keyIndex = (i - x) % key.Length;
					int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
					k = encipher ? k : -k;
					char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
					output += ch;
				}
				else
				{
					output += input[i];
					x++;
				}
			}

			return output;
		}

		public static string Encipher(string input, string key)
		{
			return Cipher(input, key, true);
		}

		public static string Decipher(string input, string key)
		{
			return Cipher(input, key, false);

		}
		static void Main()
		{
			string text = "Hello, World!";
			string cipherText = Encipher(text, "thisisakey");
			Console.WriteLine(cipherText);
			string plainText = Decipher(cipherText, "thisisakey");
			Console.WriteLine(plainText);
		}

	}
}
