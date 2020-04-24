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
            bool check = false;

            Console.WriteLine ("[{0}]", string.Join (" ", level));
            Console.Write ("Select Your Level: ");
            string player = Console.ReadLine ();
//for easy level
            for (int i = 1; i < 7; i++) {
                if (player == level[0]) {
                    Console.Write ("Pick a number from 1 - 10: ");
                    playerguess = int.Parse (Console.ReadLine ());
                    if (playerguess == easy) { check = true; Console.WriteLine ("You Got It Right"); break; }
                    else if(playerguess != easy){Console.WriteLine("That was Wrong");}
                    }
                    }
//for medium level                    
           for(int i = 1; i < 5; i++){
                if(player == level[1]){
                    Console.Write("Pick a number from 1 - 21:");
                    playerguess= int.Parse(Console.ReadLine());
                    if (playerguess == medium){check = true; Console.WriteLine("You Got It Right");break;}
                    else if(playerguess != medium){Console.WriteLine("That Was Wrong");}
                    }
                    }
  
//for hard level
           for(int i = 1; i < 4; i++){
                if(player == level[2]){
                    Console.Write("Pick a number from 1 - 51:");
                    playerguess= int.Parse(Console.ReadLine());
                    if (playerguess == hard){check = true; Console.WriteLine("You Got It Right");break;}
                    else if(playerguess != hard){Console.WriteLine("That Was Wrong");}
                    }
                    }




            if (!check){Console.WriteLine("GAME OVER");}


        



        }
    }
}

