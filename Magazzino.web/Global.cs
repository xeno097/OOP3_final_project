using Magazzino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazzino.web.Models
{
    public static class Global
    {
        static bool _logIn;
        static UserViewModel _user;

        public static bool LogIn
        {
            get
            {
                return _logIn;
            }

            set
            {
                _logIn = value;
            }
        }

        public static UserViewModel User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }
    }
}
