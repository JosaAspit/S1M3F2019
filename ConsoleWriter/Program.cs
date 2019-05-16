using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ConsoleWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> letters = GetLettersFromFile();



            string input = Console.ReadLine().ToLower();

            string[] output = new string[5];

            foreach (var item in input)
            {
                string letter = item.ToString();

                for (int i = 0; i < letters[letter].Length; i++)
                {
                    output[i] += letters[letter][i] + " ";
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static Dictionary<string, string[]> GetLettersFromFile()
        {
            //!!!!!CHANGE THIS PATH!!!!!
            string path = @"C:\Users\josa\source\repos\S1M3F2019_Demos\ConsoleWriter\letters.jpg";

            //Letters in the same order as the letters in letters.jpg
            string alphabet = "abcdefghijklmnopqrstuvwxyz ";

            //Constants for letter height and width, change if letters.jpg changes
            int letterWidth = 5;
            int letterHeight = 5;

            Dictionary<string, string[]> output = new Dictionary<string, string[]>();

            using (FileStream jpgStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (var img = new Bitmap(jpgStream))
            {
                int xPos = 0;

                for (int a = 0; a < alphabet.Length; a++)
                {
                    string letter = alphabet[a].ToString();
                    string[] letterLines = new string[letterHeight];

                    for (int w = 0; w < letterWidth; w++)
                    {
                        for (int h = 0; h < letterHeight; h++)
                        {
                            Color pixel = img.GetPixel(xPos, h);

                            if (pixel.R < 50)
                            {
                                letterLines[h] += letter.ToUpper();
                            } else
                            {
                                letterLines[h] += " ";
                            }
                        }
                        xPos++;
                    }

                    output.Add(letter, letterLines);
                }
            }

            return output;
        }
    }
}
