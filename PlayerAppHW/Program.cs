using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PlayerAppHW
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int amount = 0;
           
            
            //Prompts the user for the number of players to be created.
            Console.WriteLine("How many players would you like to create? :");
            amount = Convert.ToInt32(Console.ReadLine());


            Player[] player = new Player[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Enter player name and email:");
                player[i] = new Player();
                player[i].Name = Console.ReadLine();
                player[i].Email = Console.ReadLine();
                
            }

           for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Player name: {player[i].Name} id: {player[i].ID} email: {player[i].Email}");
            }

            /*
            Player p1 = new();
            p1.Name = " Kendrick";
            p1.Email = "KDot@gmail.com";
                 
            Console.WriteLine($"Player name: {p1.Name} id: {p1.ID} email {p1.Email}");
            */


        }
    }
}

