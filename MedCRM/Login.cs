using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection(); // link connection class
        Home home = new Home(); // link home page / Dashboard
        string date = DateTime.Now.ToString("d"); // link date and time class
        string identity = WindowsIdentity.GetCurrent().Name;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string password = txt_password.Text;

            // try to find matching credentials in the database
            try
            {
                string result = con.ReadString($"SELECT ID FROM profile WHERE name = '{name}' AND password = '{password}'");
                if (!string.IsNullOrEmpty(result))
                {
                    
                    int id = int.Parse(result);
                    con.ExecuteQuery($"INSERT INTO session (UserID, name, status, identity, date) VALUES( {id}, '{name}', 'online', '{identity}', '{date}')");
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Your credentials are incorrect!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The system is unavilable right now, please contact technical support!", "Error!");
            }
            
        }
    }
}
