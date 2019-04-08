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
    public partial class SendCV : Form
    {
        public SendCV()
        {
            InitializeComponent();
        }

       

        private void SendCV_Load(object sender, EventArgs e)
        {
            foreach (LoginUser item in LoginUserDB.logusers)
            {

                lbl_SendCVName.Text = item.name;
                lbl_SendCVSurname.Text = item.surname;
                lbl_SendCVEmail.Text = item.email;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
       
            MessageBox.Show("CVniz elave edildi!");

            lbl_cvName.Text = lbl_SendCVName.Text;
            lbl_cvSurname.Text = lbl_SendCVSurname.Text;
            lbl_cvEmail.Text = lbl_SendCVEmail.Text;
            lbl_cvEmekHaqqi.Text = txbx_emekHaqqim.Text;
            lbl_cvBiliklerim.Text = txbx_CVBilikler.Text;

           
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            SirketCVPoct SirketPoct = new SirketCVPoct();

            UserCV usrCV = new UserCV();

            USERcvDB.usersCV.Remove(usrCV);

            usrCV.userName = lbl_cvName.Text;
            usrCV.UserSurname = lbl_cvSurname.Text;
            usrCV.UserEmail = lbl_cvEmail.Text;
            usrCV.UserEmekHaqqi = lbl_cvEmekHaqqi.Text;
            usrCV.userTeleb = lbl_cvBiliklerim.Text;
            USERcvDB.AddCV(usrCV);

            foreach (SirketVakansiya Vakant in SirketDB.Vakansiyalar)
            {
                foreach (UserCV CV in USERcvDB.usersCV)
                {
                    if(Vakant.teleb == CV.userTeleb)
                    {
                        MessageBox.Show("Uygundur!");

                        //SirketPoct.lbl_poctCVName.Text = CV.userName;
                        //SirketPoct.lbl_poctCVSurname.Text = CV.UserSurname;
                        //SirketPoct.lbl_poctCVEmekHaqqi.Text = CV.UserEmekHaqqi;
                        //SirketPoct.lbl_poctCVBilikler.Text = CV.userTeleb;
                        break;
                    }
                    else if(Convert.ToInt32(Vakant.emekHaqqi) > Convert.ToInt32(CV.UserEmekHaqqi))
                    {
                        MessageBox.Show("Uygundur!");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Uygun deyilsiniz");
                        break;
                    }
                }
            }

        }
    }
}
