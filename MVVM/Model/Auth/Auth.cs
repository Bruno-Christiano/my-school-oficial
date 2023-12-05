using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_school.MVVM.Model.Auth
{
    class Auth
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string UserNameError { get; set; }
        public string UserPasswordError { get; set; }

    }
}
