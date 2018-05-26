using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Week_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("!!lucky Numbers Lottery Game!!");
            Console.WriteLine();

            string exitRes = "yes";
            Console.WriteLine("Do you want to play?");
            exitRes = Console.ReadLine().ToLower();
            while(exitRes.Equals("yes"))
            {
                
            Console.WriteLine("What is your minimum range number?");
            int minRange = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("What is your maximum range number?");
            int maxRange = int.Parse(Console.ReadLine());

                Random range = new Random();
                range.Next(minRange, maxRange);

             //Test   Console.WriteLine(minRange);
             //Test   Console.WriteLine(maxRange);

            Console.WriteLine("Please Pick Your 6 Winning Numbers");
            int[] userLuckyNum = new int[6];
                for (int i = 0; i < userLuckyNum.Length; i++)
                {
                    Console.WriteLine("Enter a Number");
                    userLuckyNum[i] = int.Parse(Console.ReadLine());

                    
                }
           
            
                 Console.WriteLine(userLuckyNum[6]);

            }

            Console.WriteLine("Thanks for playing");
           

            
        }
    }
}
 