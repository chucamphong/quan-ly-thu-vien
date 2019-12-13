using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public sealed class Auth
    {
        public static User User { get; set; }
        
        public static bool LoggedIn
        {
            get => User != null;
        }
    }
}
