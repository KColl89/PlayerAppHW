using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAppHW
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Player p1 = new();
            p1.Name = " Kendrick";
            p1.Email = "KDot@gmail.com";

            Console.WriteLine($"Player name: {p1.Name} id: {p1.ID} email {p1.Email}");
        }
    }
}

