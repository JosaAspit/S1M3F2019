using System;

namespace LoopLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int table = 10;
            int i = 1;
            while (i <= table)
            {
                int j = 1;
                while (j <= table)
                {
                    if (j <= i)
                    {
                        Console.Write("# ");
                    } else
                    {
                        Console.Write("  ");
                    }

                    j++;
                }
                Console.WriteLine();
                i++;
            }

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write((i*j).ToString().PadRight(4));
            //    }
            //    Console.WriteLine();
            //}




            //Random rnd = new Random();

            //Console.WriteLine(rnd.Next(0,100));

            //for (int i = 0; i < 10; i++) //x antal gange
            //{
            //    Console.WriteLine("HeJ mEd DiG");
            //}

            //Console.ReadKey();
            //while (true) //gør noget indtil et kriterie ikke længere er opfyldt
            //{

            //}

            //int input = 0;
            //while (input < 1 || input > 10)
            //{
            //    Console.WriteLine("skriv et tal mellem 1 og 10 for at lukke konsollen");
            //    input = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Velkommen til en lille demonstration af løkker :) ");


            ////for-, while-, foreach-, do-while-løkker

            ////for løkke, den tæller op til et tal, og stopper når den når grænsen
            //Console.WriteLine("for loop");
            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine(j);
            //}


            //Console.WriteLine("while loop");
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("wat " + i);
            //    i++;
            //}

            //Console.WriteLine("Do-while loop");
            //int k = 0;
            //do
            //{
            //    Console.WriteLine("loopdeloop " + k);
            //    k++;
            //} while (k < 10);


            //int[] myArrOfInts = new[] { 10, 24, 5, 234, 543, 26, 52, 234, 5, 431, 4, 254, 32543, 21};
            //foreach (var num in myArrOfInts)
            //{
            //    Console.WriteLine("My number is: " + num);
            //}

            //for (int l = 0; l < myArrOfInts.Length; l++)
            //{
            //    Console.WriteLine(myArrOfInts[l]);
            //}

            Console.ReadLine();
        }
    }
}
