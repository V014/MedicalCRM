using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MedCRM
{
    public partial class Profile : UserControl
    {
        Connection con = new Connection();
        string date = DateTime.Now.ToString("d");
        public Profile()
        {
            InitializeComponent();
        }

        private void picture_profile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = ofd.FileName;
                string name = txt_name.Text;
                string destinationPath = @"profiles/staff/" + name + ".jpeg";
                if (!File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, destinationPath);
                    picture_profile.ImageLocation = sourcePath;
                }
                else
                {
                    File.Delete(destinationPath);
                    File.Copy(sourcePath, destinationPath);
                    picture_profile.ImageLocation = sourcePath;
                }
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string jobtitle = txt_jobtitle.Text;
            string initials = txt_initials.Text;
            string gender = txt_gender.Text;
            string qualification = txt_qualification.Text;
            string facility = txt_facility.Text;
            string practice = txt_facility.Text;
            string address = txt_address.Text;
            string password = txt_password.Text;
            string email = txt_email.Text;
            string birthday = txt_email.Text;

            try
            {
                con.ExecuteQuery($"UPDATE profile SET name = '{name}', '{jobtitle}', '{initials}', '{gender}', '{qualification}', '{facility}', '{practice}', '{address}', '{password}', '{email}', '{birthday}', '{date}'");
                MessageBox.Show("Profile updated!", "Success!");
            }
            catch (Exception)
            {
                MessageBox.Show("Application error!", "Error!");
            }
        }
    }
}
