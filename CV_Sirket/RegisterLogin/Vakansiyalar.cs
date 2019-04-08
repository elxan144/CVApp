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
    public partial class Vakansiyalar : Form
    {
        public Vakansiyalar()
        {
            InitializeComponent();
        }

        public int x = 20;
        public int y = 60;
        public int counter = 0;

        private void Vakansiyalar_Load(object sender, EventArgs e)
        {

            foreach (SirketVakansiya item in SirketDB.Vakansiyalar)
            {
                VakanYerler vakantlar = new VakanYerler();

                vakantlar.lbl_vakansiyaAD.Text = item.VakansiyaAdi;
                vakantlar.lbl_vakansiyaEmekHaqqi.Text = item.emekHaqqi;
                vakantlar.lbl_vakansiyaTeleb.Text = item.teleb;
                vakantlar.Location = new Point(x, y);
                y += 200;
                Vakansiyalar vkn = new Vakansiyalar();
                vakantlar.button1.Click += new EventHandler(Apply_btn);
                this.Controls.Add(vakantlar);
                this.AutoScroll = true;
                counter++;
            }
        }

        private void lbl_NameEmailReg_Click(object sender, EventArgs e)
        {
            VakansiyalarStatic.vakansiyaForm.Visible = false;
        }

        private void vakanYerler1_Click(object sender, EventArgs e)
        {              

        }

        private void Apply_btn(object sender, EventArgs e)
        {          
            SendCV sendCV = new SendCV();
            sendCV.Show();
        }
    }
}
