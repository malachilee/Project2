using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
          //Malachi Lee
namespace Project_Week_Two
{         
    class Program
    {
        static void Main(string[] args)
        {
            double jackpot = 500000;
            Console.WriteLine("!!lucky Numbers Lottery Game!!");
            Console.WriteLine( "Max Jackpot is $500,000");
            Console.WriteLine();

            string exitRes = "yes";
            Console.WriteLine("Do you want to play?");
            exitRes = Console.ReadLine().ToLower();
            while(exitRes.Equals("yes"))
            {
            Console.WriteLine();    
            Console.WriteLine("What is your minimum range number?");
            int minRange = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("What is your maximum range number?");
            int maxRange = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please Pick Your 6 Winning Numbers");
            Console.WriteLine();

            int userPick = 0;
            int[] userLuckyNum = new int[6];

                for (int i = 0; i < userLuckyNum.Length; i++)
                {
                    Console.WriteLine("Enter a Number");
                    userPick = int.Parse(Console.ReadLine());
                    userLuckyNum[i] = userPick;
                    while((userPick < minRange) || (userPick > maxRange))
                    {
                        Console.WriteLine("Re-enter a Number Within Your Picked Range of " + minRange + "-" + maxRange + ".");
                        userPick = int.Parse(Console.ReadLine());
                    }
                 //Test   Console.WriteLine(userPick);
                }
                int winNum = 0;
                Random ranNums = new Random();
                int[] lottery = new int[6];

                for (int i = 0; i < lottery.Length; i++)
                {
                    winNum = ranNums.Next(minRange, maxRange++);
                    lottery[i] = winNum;
                Console.WriteLine("Lucky Number: " + winNum);

                }

               int matchNum = 0;
               for(int i = 0; i < userLuckyNum.Length; i++)
                {for(int j = 0; j < lottery.Length; j++)
                    {if (userLuckyNum[i] == lottery[j])
                        {  matchNum++; }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("You matched " + matchNum + " Lucky Numbers");
                Console.WriteLine();

                if(matchNum.Equals(0)) { Console.WriteLine("Sorry, better Luck next time. Lets play again."); }
                if(matchNum.Equals(1)) { Console.WriteLine("You Won $" + jackpot * 0.06 + "! Lets play again."); }
                if(matchNum.Equals(2)) { Console.WriteLine("You Won $" + jackpot * 0.10 + "! Lets play again."); }
                if(matchNum.Equals(3)) { Console.WriteLine("You Won $" + jackpot * 0.38 + "! Lets play again."); }
                if(matchNum.Equals(4)) { Console.WriteLine("You Won $" + jackpot * 0.60 + "! Lets play again."); }
                if(matchNum.Equals(5)) { Console.WriteLine("You Won $" + jackpot * 0.80 + "! lets play again."); }
                if(matchNum.Equals(6)) { Console.WriteLine("You must have cheated, you Won $" + jackpot + "! Lets play again."); }
            }

            Console.WriteLine("Thanks for playing!");
           

            
        }
    }
}
 