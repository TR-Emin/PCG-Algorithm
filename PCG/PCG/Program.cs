using System;
using System.IO;

namespace PCG
{
    class Program
    {
        static void Main(string[] args)
        {
            //PCG algoritması ile 1 milyon anahtar üretilmesi
            PcgRandom prnd = new PcgRandom();
            int[] binaryArray = new int[1000000];

            for (int i = 0; i < 1000000; i++)
            {                
                int rangedNumber = prnd.Next(100, 300); // from 100-300
                binaryArray[i] = ToBinary(rangedNumber);
                Console.WriteLine( rangedNumber );
            }

            using (StreamWriter outputFile = new StreamWriter(Path.Combine("Type the directory-path where the txt will be created", "WriteLines.txt")))
            {
                foreach (int line in binaryArray)
                    outputFile.WriteLine(line);
            }          
        }

        static int ToBinary(int rangedNumber)
        {
            //int decimalNumber = 15;
            int remainder;
            string binary = string.Empty;

            while (rangedNumber > 0)
            {
                remainder = rangedNumber % 2;
                rangedNumber /= 2;
                binary = remainder.ToString() + binary;
            }
            int binaryInt = Convert.ToInt32(binary);
            return binaryInt;
        }
    }
}
