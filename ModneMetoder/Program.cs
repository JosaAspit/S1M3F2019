using System;

namespace ModneMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til mit spil");
            while (true)
            {
                int choice = Menu();

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Game();
                        break;
                    case 2:
                        Console.WriteLine("Dette er ikke implementeret, lær noget om streamreader og streamwriter først");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Dit menu valg er ikke gyldigt");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static bool Game()
        {
            //spil variabler
            string name;
            int score;
            bool isPlaying = true;
            int pX = 0;
            int pY = 0;

            string[,] gameMap = new string[2, 2];

            gameMap[0, 0] = "startlokalet";
            gameMap[1, 0] = "sydvest lokalet";
            gameMap[0, 1] = "nordøst lokalet";
            gameMap[1, 1] = "sydøst lokalet, tilykke du har vundet!!";

            Console.WriteLine("Spillet starter nu");
            Console.WriteLine("Skriv venligst dit navn: ");

            name = Console.ReadLine();
            name = ConfirmStringInput(name);

            while (isPlaying)
            {
                Console.WriteLine($"Du er i {gameMap[pY, pX]}, hvor vil du hen?");

                Console.WriteLine("1. gå vest");
                Console.WriteLine("2. gå øst");
                Console.WriteLine("3. gå nord");
                Console.WriteLine("4. gå syd");

                bool choosingDir = true;
                while (choosingDir)
                {
                    int choice = GetNumberBetween(1, 4);

                    int dirX = 0;
                    int dirY = 0;

                    switch (choice)
                    {
                        case 1:
                            dirX -= 1;
                            break;
                        case 2:
                            dirX += 1;
                            break;
                        case 3:
                            dirY -= 1;
                            break;
                        case 4:
                            dirY += 1;
                            break;
                        default:
                            break;
                    }

                    if (!(pX + dirX >= gameMap.GetLength(1) || pX + dirX < 0))
                    {
                        choosingDir = false;

                        pX += dirX;
                    } else
                    {
                        Console.WriteLine("Du går udenfor kortet!!");
                    }

                    if (!(pY + dirY >= gameMap.GetLength(0) || pY + dirY < 0))
                    {
                        choosingDir = false;

                        pY += dirY;
                    } else
                    {
                        Console.WriteLine("Du går udenfor kortet!!");
                    }
                }

            }

            return true;
        }

        static int Menu()
        {
            Console.WriteLine("1. Start spillet");
            Console.WriteLine("2. Gem spillet");
            Console.WriteLine("3. I want to get off Mr. Games wild ride");

            int choice = GetNumberBetween(1, 3);

            return choice;
        }

        static int GetNumberBetween(int a, int b)
        {
            int choice = 0;
            bool chosen = false;

            while (!chosen)
            {
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice >= a && choice <= b)
                    {
                        chosen = true;
                    }
                    else
                    {
                        Console.WriteLine($"Skriv et tal mellem {a} og {b}");
                    }
                }
                else
                {
                    Console.WriteLine("Skriv et tal");
                }
            }

            return choice;
        }

        static string ConfirmStringInput(string input)
        {
            Console.WriteLine($"du skrev \"{input}\" vil du acceptere det?");
            Console.WriteLine("1. ja");
            Console.WriteLine("2. nej");

            int choice = GetNumberBetween(1, 2);

            if (choice == 1)
            {
                return input;
            }
            else
            {
                return Console.ReadLine();
            }
        }
    }
}
