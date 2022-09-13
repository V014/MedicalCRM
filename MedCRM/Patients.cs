using System;
using System.IO;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class Patients : UserControl
    {
        Connection con = new Connection();
        utils utils = new utils();
        string date = DateTime.Now.ToString("d");
        StyleDataGrid style = new StyleDataGrid();
        public Patients()
        {
            InitializeComponent();
        }

        private void data_patients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data_patients.Rows[e.RowIndex];
                txt_name.Text = row.Cells[1].Value.ToString();
                txt_contact.Text = row.Cells[2].Value.ToString();
                txt_birthday.Text = row.Cells[3].Value.ToString();
                txt_bloodtype.Text = row.Cells[4].Value.ToString();
				txt_gender.Text = row.Cells[5].Value.ToString();
                txt_address.Text = row.Cells[6].Value.ToString();
                txt_notes.Text = row.Cells[7].Value.ToString();
                utils.id = Convert.ToInt32(row.Cells[0].Value.ToString());
                if (!string.IsNullOrEmpty(row.Cells[8].Value.ToString()))
                {
                    picture_profile.ImageLocation = row.Cells[8].Value.ToString();
                }
                else
                {
                    picture_profile.ImageLocation = @"profiles/person.png";
                }
            }
            catch (Exception)
            {

            }
        }
        private void loadPatients()
        {
            con.LoadData("SELECT * FROM patients", data_patients);
            data_patients.Columns[2].Visible = false;
            data_patients.Columns[3].Visible = false;
            data_patients.Columns[4].Visible = false;
            data_patients.Columns[5].Visible = false;
            data_patients.Columns[6].Visible = false;
            data_patients.Columns[7].Visible = false;
            data_patients.Columns[8].Visible = false;
            style.style(data_patients);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string contact = txt_contact.Text;
            string birthday = txt_birthday.Text;
            string address = txt_address.Text;
            string bloodtype = txt_bloodtype.Text;
			string gender = txt_gender.Text;
            string notes = txt_notes.Text;

            // name should atleast be present
            if (!string.IsNullOrEmpty(name))
            {
                try
                {
                    string imagePath = @"profiles/patients/" + name + ".jpeg";
                    con.ExecuteQuery($"INSERT INTO patients (name, contact, birthday, bloodtype, gender, address, notes, picture, date) VALUES('{name}', '{contact}', '{birthday}', '{bloodtype}', '{gender}', '{address}', '{notes}', '{imagePath}', '{date}')");
                    MessageBox.Show("Patient registered!", "Success!");
                    loadPatients();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to register patient!", "Error!");
                }
            }
            else
            {
                MessageBox.Show("Patient must atleast have a name!", "Error!");
            }
            
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            int id = utils.id;
            string name = txt_name.Text;
            string contact = txt_contact.Text;
            string birthday = txt_birthday.Text;
            string address = txt_address.Text;
            string bloodtype = txt_bloodtype.Text;
			string gender = txt_gender.Text;
            string notes = txt_notes.Text;

            // name should atleat be present
            if (!string.IsNullOrEmpty(name))
            {
                try
                {
                    string imagePath = @"profiles/patients/" + name + ".jpeg";
                    con.ExecuteQuery($"UPDATE patients SET Name = '{name}', Contact = '{contact}', Birthday = '{birthday}', Bloodtype = '{bloodtype}', gender = '{gender}', Address = '{address}', Notes = '{notes}', Picture = '{imagePath}' WHERE ID = {id}");
                    MessageBox.Show("Patient records updated!", "Sucess!");
                    loadPatients();
                }
                catch (Exception)
                {
                    MessageBox.Show("Application error!", "Error!");
                }
            }
            else
            {
                MessageBox.Show("Patient must atleast have a name!", "Error!");
            }
        }
        private void picture_profile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = ofd.FileName;
                string name = txt_name.Text;
                string destinationPath = @"profiles/patients/" + name + ".jpeg";
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

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
