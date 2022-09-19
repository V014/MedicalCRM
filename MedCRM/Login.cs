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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        Home home = new Home();
        utils utils = new utils();
        string date = DateTime.Now.ToString("d");
        public Login()
        {
            InitializeComponent();
        }

        private void btn_authenticate_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string password = txt_password.Text;

            string result = con.ReadString($"SELECT id FROM profile WHERE name = '{name}' AND password = '{password}'");
            if (!string.IsNullOrEmpty(result))
            {
                int id = int.Parse(result);
                con.ExecuteQuery($"UPDATE session SET StaffID = {id}, status = 'online', Name = '{name}', date = '{date}' WHERE id = 1");
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Your credentials are incorrect!");
            }
        }
    }
}
