using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject.Models;
using Helper.Crypto;

namespace BusinessLogicLayer
{
    public class UserEntity
    {
        public static bool Login(string @email, string password)
        {
            string hashPassword = MD5.Hash(password);

            return UserData.FindByEmailAndPassword(@email, hashPassword) is User;
        }
    }
}
