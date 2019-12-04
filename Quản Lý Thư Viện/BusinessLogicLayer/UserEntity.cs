using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;

namespace BusinessLogicLayer
{
    public class UserEntity
    {
        public static bool Login(string email, string password)
        {
            string hashPassword;

            using (MD5 hash = MD5.Create())
            {
                hashPassword = GetMd5Hash(hash, password);
            }

            return UserData.Where(user => user.Email == email && user.Password == hashPassword).FirstOrDefault() != null;
        }

        private static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
