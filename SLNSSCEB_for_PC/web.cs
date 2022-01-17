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
    public partial class web : Form
    {
        public web()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void web_Load(object sender, EventArgs e)
        {
            try
            {
                StringBuilder mapLocation = new StringBuilder();
                mapLocation.Append("https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/");
                webBrowser1.Navigate(mapLocation.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading map", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Mhome_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home();
            h.Show();
        }

        private void btn_Mprofile_Click(object sender, EventArgs e)
        {
            this.Close();
            profile p = new profile();
            p.Show();
        }

        private void btn_Maddmember_Click(object sender, EventArgs e)
        {
            this.Close();
            AddNewMember n = new AddNewMember();
            n.Show();
        }
    }
}
