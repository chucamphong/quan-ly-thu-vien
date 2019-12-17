using System.Security.Authentication;
using System.Threading.Tasks;
using Core.Crypto;
using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public sealed class UserService : Service<User>, IUserService
    {
        /// <summary>
        /// Kiểm tra tài khoản và mật khẩu.
        /// </summary>
        /// <param name="email">Địa chỉ email.</param>
        /// <param name="password">Mật khẩu.</param>
        /// <exception cref="AuthenticationException">Tài khoản hoặc mật khẩu không đúng.</exception>
        /// <returns>Thông tin người dùng.</returns>
        public async Task<User> Login(string email, string password)
        {
            string hashPassword = MD5.Hash(password);

            using (var userData = this.CreateInstance() as UserData)
            {
                User user = await Task.Run(() => userData.FindByEmailAndPassword(email, hashPassword));

                if (user is null)
                {
                    throw new AuthenticationException("Tài khoản hoặc mật khẩu không đúng.");
                }

                return user;
            }
        }

        protected override BaseData<User> CreateInstance()
        {
            return new UserData();
        }
    }
}
