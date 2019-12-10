using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Validation
{
    public class Validation
    {
        public static bool IsEmail(string email)
        {
            EmailAddressAttribute emailChecker = new EmailAddressAttribute();
            
            return emailChecker.IsValid(email);
        }
    }
}
