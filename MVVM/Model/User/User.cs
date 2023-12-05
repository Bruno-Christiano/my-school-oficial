using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_school.MVVM.Model.User
{
    class User
    {
        public int Id { get; set; }
        public required  string UserName { get; set; }
        public required  string Password { get; set; }
        public string Email { get; set; }
        public  string Role { get; set; }
    }
}
