using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLNSSCEB_for_PC
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        AddNewMember adnm = new AddNewMember();

        private void pbx_addNewMember_Click(object sender, EventArgs e)
        {
            adnm.ShowDialog();
        }

        private void btn_Maddmember_Click(object sender, EventArgs e)
        {
            adnm.ShowDialog();
        }

        private void pnal_addNewMember_Paint(object sender, PaintEventArgs e)
        {
            //adnm.ShowDialog();
        }

        private void lbl_hAddNewMember_Click(object sender, EventArgs e)
        {
            adnm.ShowDialog();
        }

        private void lbl_pAddNewMember_Click(object sender, EventArgs e)
        {
            adnm.ShowDialog();
        }

        private void btn_s1addNewMember_Click(object sender, EventArgs e)
        {
            adnm.ShowDialog();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Sign_in sin = new Sign_in();
            sin.Show();
        }

        private void btn_Mweb_Click(object sender, EventArgs e)
        {
            this.Close();
            web w = new web();
            w.Show();
        }

        private void btn_Mprofile_Click(object sender, EventArgs e)
        {
            this.Close();
            profile p = new profile();
            p.Show();
        }
    }
}
