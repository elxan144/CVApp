using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLogin.Model
{
    class UserModel
    {
        public string name;
        public string surname;
        public string email;
        public string password;
        public string ConfirmPassword;


        public UserModel(string name, string surname, string email, string password, string ConfirmPassword)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.ConfirmPassword = ConfirmPassword;
        }

        public User ConvertUser()
        {
            User user = new User();

            user.name = this.name;
            user.surname = this.surname;
            user.email = this.email;
            user.password = this.password;

            return user;
        }

    }
}
