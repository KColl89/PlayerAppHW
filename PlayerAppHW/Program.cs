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
            char ch;
            
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

            Console.WriteLine("Would you like to view player info? Y for yes and N for no");
            ch = Convert.ToChar(Console.ReadLine());

            switch (char.ToLower(ch))
            {
                case 'y':
                    for (int i = 0; i < amount; i++)
                    {
                        Console.WriteLine($"Player name: {player[i].Name} id: {player[i].ID} email: {player[i].Email}");
                    }
                    break;
                case 'n':
                    Console.WriteLine("Ok,Goodbye");
                    break;
                default:
                    Console.WriteLine("Bad input, exiting programing");
                    break;


            }




        }
    }

 
}

