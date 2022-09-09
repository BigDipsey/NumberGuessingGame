

using System;

namespace LA1300;

class Program
{
    public static void Main(string[] args)
    {
        bool validator = true;
        string playAgain = "y";
        int timesGuessed = 0;
        Console.WriteLine("Welcome to the Numberguessing game");

        while (playAgain == "y")
        {
            Console.WriteLine("Guess a number from 1-100");
            int randomnumber = new Random().Next(1, 100);



            while (validator)
            {
                try
                {

                    int userguess = Convert.ToInt32(Console.ReadLine());
                    if (randomnumber == userguess)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congratulations u guessed right");
                        if (timesGuessed <= 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Score " +timesGuessed);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Score " + timesGuessed);
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        timesGuessed++;
                        validator = false;
                    }
                    else if (userguess > 100 || userguess < 1)
                    {
                        Console.WriteLine("Ur number is not in the Range");
                        timesGuessed++;
                    }
                    else if (randomnumber < userguess)
                    {
                        Console.WriteLine("Ur Number is to high");
                        timesGuessed++;
                    }
                    else if (randomnumber > userguess)
                    {
                        Console.WriteLine("Ur Number is to Low");
                        timesGuessed++;
                    }
                }
                catch
                {
                    Console.WriteLine("Only use Numbers!");
                }
            }




            char repeat = 'y';
            while (repeat == 'y')
            {
                try
                {
                    Console.WriteLine("Do u want to play again? [y/n]");
                    playAgain = Console.ReadLine();
                    if (playAgain == "y")
                    {
                        repeat = 'n';
                        validator = true;
                    }
                    else if (playAgain == "n")
                    {
                        repeat = 'n';
                    }
                    else
                    {
                        throw new Exception();
                    }


                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Input");
                    Console.ForegroundColor = ConsoleColor.White;
                    playAgain = "y";
                }



            }

        }


        
    }
}



