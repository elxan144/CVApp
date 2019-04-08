using RegisterLogin.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLogin.CORE
{
    class Validator
    {

        ArrayList errors = new ArrayList();


        public  bool IsValid( UserModel userMODEL )
        {
            bool isValid = true;

            if (String.IsNullOrEmpty(userMODEL.email))
            {
                errors.Add("Email is empty!");
                isValid = false;
            }
            if (String.IsNullOrEmpty(userMODEL.name))
            {
                errors.Add("Name is empty!");
                isValid = false;
            }
            if (String.IsNullOrEmpty(userMODEL.password))
            {
                errors.Add("password is empty!");
                isValid = false;
            }
            if (String.IsNullOrEmpty(userMODEL.surname))
            {
                errors.Add("surname is empty!");
                isValid = false;
            }
            if (String.IsNullOrEmpty(userMODEL.ConfirmPassword))
            {
                errors.Add("ConfirmPassword is empty!");
                isValid = false;
            }
            if(userMODEL.password != userMODEL.ConfirmPassword)
            {
                errors.Add("Password is not same with ConfirmPassword!");
                isValid = false;
            }
            return isValid;
        }


        public string GetError()
        {
            string result = "";
            foreach (String item in errors)
            {
                result += item + "\n";
            }
            return result;
        }
    }
}
