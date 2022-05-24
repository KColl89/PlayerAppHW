using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PlayerAppHW
{
    public class Player : IPLayer
    {
        
        
        public static Regex EmailRegax = new Regex("^[0-9a-zA-Z]+" + "[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([a-zA-z]{2,3})(0,1)", RegexOptions.Compiled);        
        private readonly Guid _id = Guid.NewGuid();
        private string _name = "";
        private string _email = "";
        
        public Guid ID { get { return _id; } }

        public Guid Id => throw new NotImplementedException();

        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = ValidateEmail(value); } }

        public static string ValidateEmail(string check)
        {
            if (!EmailRegax.IsMatch(check))
                            
            Console.WriteLine("Enter a valid email: ");
            check = Console.ReadLine();

            return check;
        }

        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
  

    

}
