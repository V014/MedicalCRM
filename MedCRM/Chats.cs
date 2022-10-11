using System;
using System.Media;
using System.Security.Principal;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class Chats : UserControl
    {
        Connection con = new Connection();
        StyleDataGrid style = new StyleDataGrid();
        utils utils = new utils();
        string date = DateTime.Now.ToString("d");
        string recipient;
        string chatID;
        string identity = WindowsIdentity.GetCurrent().Name;
        public Chats()
        {
            InitializeComponent();
        }
        // loads messages onto text datagrid
        private void loadTexts()
        {
            try
            {
                con.LoadData($"SELECT Message FROM messages WHERE `From` = '{recipient}' AND `To` = '{loadUsername()}' ", data_in);
                con.LoadData($"SELECT Message FROM messages WHERE `From` = '{loadUsername()}' AND `To` = '{recipient}' ", data_out);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }
        // load UserID
        private int loadUserID()
        {
            int id = int.Parse(con.ReadString($"SELECT UserID FROM session WHERE identity = '{identity}'"));
            return id;
        }
        // load username
        private string loadUsername()
        {
            string name = con.ReadString($"SELECT Name FROM session WHERE identity = '{identity}'");
            return name;
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            string message = txt_message.Text;
          
            if (!string.IsNullOrEmpty(message))
            {
                try
                {
                    con.ExecuteQuery($"INSERT INTO messages (`From`, `To`, `Message`, `Date`) VALUES('{loadUsername()}', '{recipient}', '{message}', '{date}')");
                    loadTexts();
                    txt_message.Clear();
                    // play chime
                    SoundPlayer chime = new SoundPlayer(@"sfx/pop.wav");
                    chime.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Assistant");
                }
            }
            else
            {
                MessageBox.Show("Write comment first!", "Warning!");
            }
        }

        private void data_chats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = data_chats.Rows[e.RowIndex];
            txt_from.Text = row.Cells[1].Value.ToString();
            txt_to.Text = row.Cells[2].Value.ToString();

            recipient = row.Cells[1].Value.ToString();
            chatID = row.Cells[0].Value.ToString();
            loadTexts();
            style.styleChat(data_in);
            style.styleChat(data_out);
        }
    }
}
