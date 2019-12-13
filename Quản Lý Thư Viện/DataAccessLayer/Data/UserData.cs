using System.Linq;
using DataTransferObject;

namespace DataAccessLayer.Data
{
    public sealed class UserData
    {
        private static readonly LibraryManagementSystemContext Context = new LibraryManagementSystemContext();

        /// <summary>
        /// Tìm kiếm địa chỉ email và mật khẩu trong cơ sỡ dữ liệu
        /// </summary>
        /// <param name="email">Địa chỉ email</param>
        /// <param name="password">Mật khẩu</param>
        /// <returns>Thông tin người dùng nếu tìm thấy, ngược lại trả về null</returns>
        public static User FindByEmailAndPassword(string email, string password)
        {
            return Context.Users.AsNoTracking().SingleOrDefault(user => user.Email.Equals(email) &&
                                                         user.Password.Equals(password));
        }

        public static int Count()
        {
            return Context.Users.AsNoTracking().Count();
        }
    }
}
