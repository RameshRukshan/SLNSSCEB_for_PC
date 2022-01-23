using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SLNSSCEB_for_PC
{
    public partial class AddNewMember : Form
    {
        public AddNewMember()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, System.EventArgs e)
        {
            txt_PFNumber.Clear();
            txt_FName.Clear();
            txt_LName.Clear();
            txt_AddressOne.Clear();
            txt_AddressTwo.Clear();
            txt_City.Clear();
            txt_ZipCode.Clear();
            txt_NIC.Clear();
            txt_MobileNumber.Clear();
            rad_female.Checked = false;
            rad_Male.Checked = false;
            cmbx_WorkStation.Text = "";
            cmbx_grade.Text = "";

            lbl_error.Visible = false;

            txt_FName.BorderColor = System.Drawing.Color.DarkGray;
            txt_PFNumber.BorderColor = System.Drawing.Color.DarkGray;
            txt_LName.BorderColor = System.Drawing.Color.DarkGray;
            txt_AddressOne.BorderColor = System.Drawing.Color.DarkGray;
            txt_AddressTwo.BorderColor = System.Drawing.Color.DarkGray;
            txt_City.BorderColor = System.Drawing.Color.DarkGray;
            txt_ZipCode.BorderColor = System.Drawing.Color.DarkGray;
            txt_NIC.BorderColor = System.Drawing.Color.DarkGray;
            txt_MobileNumber.BorderColor = System.Drawing.Color.DarkGray;

            cmbx_grade.BorderColor = System.Drawing.Color.DarkGray;
            cmbx_WorkStation.BorderColor = System.Drawing.Color.DarkGray;

            lbl_gender.ForeColor = System.Drawing.Color.DarkGray;
            rad_female.ForeColor = System.Drawing.Color.DarkGray;
            rad_Male.ForeColor = System.Drawing.Color.DarkGray;
        }

        private void btn_addMember_Click(object sender, System.EventArgs e)
        {
            int countVal = 0;
            bool gend;
            string workStation = "", grade = "", gender;

            if (rad_female.Checked)
            {
                gender = "Female";
                gend = false;
            }else if (rad_Male.Checked)
            {
                gender = "Male";
                gend = true;
            }

            workStation = cmbx_WorkStation.Text;
            grade = cmbx_grade.Text;

            if (string.IsNullOrEmpty(txt_PFNumber.Text))
            {
                txt_PFNumber.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal = countVal + 1;
            }


            if (string.IsNullOrEmpty(txt_FName.Text))
            {
                txt_FName.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal = countVal + 1;
            }


            if (string.IsNullOrEmpty(txt_LName.Text))
            {
                txt_LName.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal = countVal + 1;
            }


            if (string.IsNullOrEmpty(txt_AddressOne.Text))
            {
                txt_AddressOne.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal++;
            }


            if (string.IsNullOrEmpty(txt_AddressTwo.Text))
            {
                txt_AddressTwo.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal++;
            }


            if (string.IsNullOrEmpty(txt_City.Text))
            {
                txt_City.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal++;
            }


            if (string.IsNullOrEmpty(txt_ZipCode.Text))
            {
                txt_ZipCode.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal++;
            }


            if (string.IsNullOrEmpty(txt_MobileNumber.Text))
            {
                txt_MobileNumber.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal++;
            }


            if (string.IsNullOrEmpty(txt_NIC.Text))
            {
                txt_NIC.BorderColor = System.Drawing.Color.Red;
            }
            else if (!Regex.IsMatch(txt_NIC.Text, @"^([0-9]{9}[x|X|v|V]|[0-9]{12})$"))
            {
                txt_NIC.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal++;
            }


            if (string.IsNullOrEmpty(workStation))
            {
                cmbx_WorkStation.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal++;
            }


            if (string.IsNullOrEmpty(grade))
            {
                cmbx_grade.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                countVal++;
            }


            if(rad_female.Checked || rad_Male.Checked)
            {
                countVal++;
            }
            else
            {
                lbl_gender.ForeColor = System.Drawing.Color.Red;
                rad_female.ForeColor = System.Drawing.Color.Red;
                rad_Male.ForeColor = System.Drawing.Color.Red;
            }


            if (countVal == 12)
            {
                MessageBox.Show("Sucess","Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_error.Visible = true;
            }
        }

        private void AddNewMember_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'sLNSSCEBDataSet.workStation' table. You can move, or remove it, as needed.
            this.workStationTableAdapter.Fill(this.sLNSSCEBDataSet.workStation);
            lbl_error.Visible = false;

            txt_FName.BorderColor = System.Drawing.Color.DarkGray;
            txt_PFNumber.BorderColor = System.Drawing.Color.DarkGray;
            txt_LName.BorderColor = System.Drawing.Color.DarkGray;
            txt_AddressOne.BorderColor = System.Drawing.Color.DarkGray;
            txt_AddressTwo.BorderColor = System.Drawing.Color.DarkGray;
            txt_City.BorderColor = System.Drawing.Color.DarkGray;
            txt_ZipCode.BorderColor = System.Drawing.Color.DarkGray;
            txt_NIC.BorderColor = System.Drawing.Color.DarkGray;
            txt_MobileNumber.BorderColor = System.Drawing.Color.DarkGray;

            cmbx_grade.BorderColor = System.Drawing.Color.DarkGray;
            cmbx_WorkStation.BorderColor = System.Drawing.Color.DarkGray;

            lbl_gender.ForeColor = System.Drawing.Color.DarkGray;
            rad_female.ForeColor = System.Drawing.Color.DarkGray;
            rad_Male.ForeColor = System.Drawing.Color.DarkGray;
        }
    }
}
