using System.ComponentModel.DataAnnotations;

namespace Core.Validation
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
