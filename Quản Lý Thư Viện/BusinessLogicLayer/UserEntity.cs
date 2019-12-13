using DataAccessLayer.Data;
using DataTransferObject;
using Core.Crypto;
using System.Threading.Tasks;
using System.Security.Authentication;

namespace BusinessLogicLayer
{
    public class UserEntity
    {
        /// <summary>
        /// Kiểm tra tài khoản và mật khẩu
        /// </summary>
        /// <param name="email">Địa chỉ email</param>
        /// <param name="password">Mật khẩu</param>
        /// <exception cref="AuthenticationException">Tài khoản hoặc mật khẩu không đúng</exception>
        /// <returns>Thông tin người dùng</returns>
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
