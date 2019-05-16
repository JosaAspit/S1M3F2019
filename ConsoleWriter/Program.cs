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
            Dictionary<string, string[]> letters = new Dictionary<string, string[]>();

            try
            {
                string path = @"C:\Users\josa\source\repos\S1M3F2019_Demos\ConsoleWriter\letters.png";
                int height = 5;
                int width = 5;
                string alphabet = "abcdefghijklmnopqrstuvwxyz!?,.';:=-)(<> 1234567890[]#\"/\\|^*_";

                if (args.Length == 1)
                {
                    path = args[0];
                }

                if (args.Length == 2)
                {
                    path = args[0];
                    alphabet = args[3];
                }

                if (args.Length == 4)
                {
                    path = args[0];
                    alphabet = args[3];
                    height = int.Parse(args[1]);
                    width = int.Parse(args[2]);
                }

                //change path, width and height
                letters = GetLettersFromFile(path, height, width, alphabet);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured, press enter to exit");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Environment.Exit(0);
            }

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

            try
            {
                using (StreamWriter writer = new StreamWriter("C:/output/words.txt"))
                {
                    foreach (var item in output)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Application exited with following code: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("press any key to exit");
                Console.ReadKey();
                Environment.Exit(0);
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static Dictionary<string, string[]> GetLettersFromFile(string path, int lHeight, int lWidth, string alphabet)
        {

            //Constants for letter height and width, change if letters.jpg changes
            int letterWidth = lHeight;
            int letterHeight = lWidth;

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
                            }
                            else
                            {
                                letterLines[h] += " ";
                            }
                        }
                        xPos++;
                    }

                    output.Add(@letter, letterLines);
                }
            }

            return output;
        }
    }
}
