using System;

namespace myGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] level = new string[3] { "EASY", "MEDIUM", "HARD" };
            Random rnd = new Random ();
            int easy = rnd.Next (1, 11);
            int medium = rnd.Next (1, 21);
            int hard = rnd.Next (1, 51);
            int playerguess;
            
            Console.WriteLine ("[{0}]", string.Join (" ", level));
            Console.Write ("Select Your Level: ");
            string player = Console.ReadLine();
            
                for(int i = 1; i < 7; i++){
                if(player == level[0]){
                    Console.Write("Pick a number from 1 - 10: ");
                    playerguess = int.Parse(Console.ReadLine());
                    if(playerguess == easy){Console.WriteLine("You Got It Right");}
                    else if(playerguess != easy){Console.WriteLine("That was Wrong");}
                    else{Console.WriteLine("GAME OVER");}
                  


                }
           

            }

       
            



        }
    }
}
