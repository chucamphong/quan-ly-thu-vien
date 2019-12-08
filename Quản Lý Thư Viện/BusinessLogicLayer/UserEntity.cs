using DataAccessLayer;
using Helper.Crypto;

namespace BusinessLogicLayer
{
    public class UserEntity
    {
        public static bool Login(string email, string password)
        {
            string hashPassword = MD5.Hash(password);

            return UserData.FindByEmailAndPassword(email, hashPassword) != null;
        }
    }
}
