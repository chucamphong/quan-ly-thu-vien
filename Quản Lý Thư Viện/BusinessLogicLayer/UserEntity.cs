using DataAccessLayer;
using Helper.Crypto;
using System.Threading.Tasks;
using System.Security.Authentication;
using DataTransferObject.Models;

namespace BusinessLogicLayer
{
    public class UserEntity
    {
        public static async Task<User> Login(string email, string password)
        {
            string hashPassword = MD5.Hash(password);

            User user = await Task.Run(() => UserData.FindByEmailAndPassword(email, hashPassword));

            if (user is null)
            {
                throw new AuthenticationException("Tài khoản hoặc mật khẩu không đúng.");
            }

            return user;
        }
    }
}
