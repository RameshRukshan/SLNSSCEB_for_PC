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
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            txt_password.MaxLength = 15;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lbl_invalid.Visible = false;
            txt_password.BorderColor = Color.DarkGray;
            txt_username.BorderColor = Color.DarkGray;

            bool status = false;

            DatabaseConnection dc = new DatabaseConnection();

            status = dc.checkLoginCredentials(txt_username.Text,txt_password.Text);

            if (status == true)
            {
                this.Hide();
                Home h = new Home();
                h.Show();
            }
            else
            {
                lbl_invalid.Visible = true;
                txt_password.BorderColor = Color.Red;
                txt_username.BorderColor = Color.Red;
            }

            //if you wnat to run this without databade connection following code will help
            /*
            if (txt_username.Text == "slnssceb" && txt_password.Text == "adminSLNSSCEB")
            {
                this.Hide();
                Home h = new Home();
                h.Show();
            }
            else
            {
                lbl_invalid.Visible = true;
                txt_password.BorderColor = Color.Red;
                txt_username.BorderColor = Color.Red;
            }
            */
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {
            lbl_invalid.Visible = false;
            txt_password.BorderColor = Color.DarkGray;
            txt_username.BorderColor = Color.DarkGray;
        }
    }
}
