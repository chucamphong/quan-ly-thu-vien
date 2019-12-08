using DataAccessLayer;
using Helper.Crypto;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UserEntity
    {
        public static Task<bool> Login(string email, string password)
        {
            string hashPassword = MD5.Hash(password);

            return Task.Run(() => UserData.FindByEmailAndPassword(email, hashPassword) != null);
        }
    }
}
