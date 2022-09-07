using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class AddPatient : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        string date = DateTime.Now.ToString("d");
        public AddPatient()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string contact = txt_contact.Text;
            string bloodtype = txt_bloodtype.Text;
            string birthday = txt_birthday.Text;
            string address = txt_address.Text;
            string notes = txt_notes.Text;

            try
            {
                string loadPatients = con.ReadString($"SELECT * FROM patients WHERE Name = '{name}'");

                if (string.IsNullOrEmpty(loadPatients))
                {
                    con.ExecuteQuery($"INSERT INTO patients (Name, Birthday, Address, Contact, BloodType, Notes, Date) VALUES('{name}', '{birthday}', '{address}', '{contact}', '{bloodtype}', '{notes}', '{date}')");
                    MessageBox.Show("Patient Registered!");
                }
                else
                {
                    MessageBox.Show("A patient with a similar name exists!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops error!");
            }
        }
    }
}
