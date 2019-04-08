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
    public partial class Sirket : Form
    {
        public Sirket()
        {
            InitializeComponent();
        }

        private void Add_vakansiya_Click(object sender, EventArgs e)
        {

            SirketVakansiya sirketvakansiya = new SirketVakansiya(txbx_vakansiyaAdi.Text,
                                                                  txbx_EmekHaqqi.Text,
                                                                   txbx_Teleb.Text
                                                                    );
            SirketDB.AddVakansiya(sirketvakansiya);
        }

        private void Apply_btn(object sender, EventArgs e)
        {
            SendCV snd = new SendCV();
            snd.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void getPostCV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SirketCVPoct sirketPoct = new SirketCVPoct();
            sirketPoct.Show();        
        }


        private void lbl_sirketVakansiyalarLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vakansiyalar vkn = new Vakansiyalar();
            vkn.Show();
        }


        private void Sirket_Load(object sender, EventArgs e)
        {

        }

    }
    }

