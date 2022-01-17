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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void btn_Mhome_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home();
            h.Show();
        }

        private void btn_Maddmember_Click(object sender, EventArgs e)
        {
            this.Close();
            AddNewMember n = new AddNewMember();
            n.Show();
        }

        private void btn_Mweb_Click(object sender, EventArgs e)
        {
            this.Close();
            web w = new web();
            w.Show();
        }
    }
}
