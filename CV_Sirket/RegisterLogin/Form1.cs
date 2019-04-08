using RegisterLogin.CORE;
using RegisterLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            labelUser.Text = "";

            UserModel usermodel = new UserModel(txbx_name.Text,
                                                txbx_surname.Text,
                                                txbx_email.Text,
                                                txbx_password.Text,
                                                txbx_ConfirmPassword.Text);

            Validator valid = new Validator();


            User USER = usermodel.ConvertUser();


            if (valid.IsValid(usermodel))
            {
                UserDB.users.Add(USER);
                foreach (User item in UserDB.users)
                {
                    labelUser.Text += item.name + " " + item.surname + "\n";
                }
            }
            else
            { 
                labelUser.Text += valid.GetError() + "\n"; 
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            LoginUser loguser = new LoginUser();

            loguser.email = login_txbx_email.Text;
            loguser.password = Login_txbx_password.Text;

            foreach(User item in UserDB.users)
            {
                if (item.email == loguser.email)
                {
                    loguser.surname = item.surname;
                    loguser.name = item.name;
                }
            }

            LoginUserDB.logusers.Add(loguser);


            if (loguser.email == "admin" && loguser.password == "admin123")
            {
                Sirket srk = new Sirket();
                srk.Show();
            }
            else
            {
                if (UserDB.LoginCheck(loguser))
                {
                    MessageBox.Show("duzdur!");

                    Vakansiyalar vkk = new Vakansiyalar();

                    vkk.Show();

                    vkk.lbl_NameEmailReg.Text = loguser.surname + " " + loguser.name;

                    
                }
                else
                {
                    MessageBox.Show("sefdir!");
                }
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
