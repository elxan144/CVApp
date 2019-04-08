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
    public partial class SirketCVPoct : Form
    {
        public SirketCVPoct()
        {
            InitializeComponent();
        }

        public int x = 20;
        public int y = 90;
        public int counter = 0;


        private void SirketCVPoct_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Label lbl = new Label();

            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.Location = new System.Drawing.Point(239, 22);
            lbl.Name = "label1";
            lbl.Size = new System.Drawing.Size(240, 41);
            lbl.TabIndex = 0;
            lbl.Text = "Gelen CV-ler";
            lbl.Click += new System.EventHandler(this.label1_Click);

            this.Controls.Add(lbl);

            foreach (UserCV CV in USERcvDB.usersCV)
                {
                    CVPoct cv = new CVPoct();

                    cv.lbl_poctCVName.Text = CV.userName;
                    cv.lbl_poctCVSurname.Text = CV.UserSurname;
                    cv.lbl_poctCVEmekHaqqi.Text = CV.UserEmekHaqqi;
                    cv.lbl_poctCVBilikler.Text = CV.userTeleb;
                    cv.Location = new Point(x, y);
                    y += 190;

                cv.rejectCV_btn.Click += reject_click;
                cv.acceptCv_btn.Click += accept_click;
                this.Controls.Add(cv);
                    this.AutoScroll = true;
                    counter++;
                }            
        }

        private void accept_click(object sender, EventArgs e)
        {
            MessageBox.Show("qebul oldu");

            CVPoct cvPct = new CVPoct();
            cvPct.groupBox1.BackColor = SystemColors.HotTrack;
            cvPct.panel1.BackColor = SystemColors.HotTrack;
        }

        private void reject_click(object sender, EventArgs e)
        {
            MessageBox.Show("tessuf!");
            CVPoct cvPct = new CVPoct();
            cvPct.groupBox1.BackColor = SystemColors.Desktop;
            cvPct.panel1.BackColor = SystemColors.Desktop;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
