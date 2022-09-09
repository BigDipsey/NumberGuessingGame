

//namespace LA1300
//{
//    internal class Class1
//    {
//        static bool validator = true;
//        static string playagain = "y";
//        static int timesGuessed = 0;
//        public static void Random()
//        {
//            while (playagain == "y")
//            {
//                Console.WriteLine("Welcome to the Numberguessing game guess a number from 1-100")
//                int randomnumber = new Random().Next(1, 100);
//                Console.WriteLine(randomnumber);


//                while (validator)
//                {
//                    try
//                    {

//                        int userguess = Convert.ToInt32(Console.ReadLine());
//                        if (randomnumber == userguess)
//                        {
//                            Console.WriteLine("Congratulations u guessed right");
//                            timesGuessed++;
//                            validator = false;
//                        }
//                        else if (userguess > 100 || userguess < 1)
//                        {
//                            Console.WriteLine("Ur number is not in the Range");
//                            timesGuessed++;
//                        }
//                        else if (randomnumber < userguess)
//                        {
//                            Console.WriteLine("Ur Number is to high");
//                            timesGuessed++;
//                        }
//                        else if (randomnumber > userguess)
//                        {
//                            Console.WriteLine("Ur Number is to Low");
//                            timesGuessed++;
//                        }
//                    }
//                    catch
//                    {
//                        Console.WriteLine("Only use Numbers!");
//                    }
//                }
//                Console.WriteLine(timesGuessed);

//do
//{
//    Console.WriteLine("Do u want to play again? [y/n]");
//    playagain = Console.ReadLine();
//    if (playagain == "y")
//    {
//        validator = true;
//        Console.Clear();
//    }

//} while (playagain != "y" || playagain != "n");





//            }
//        }
//    }
//}

