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
                
                con.LoadData($"SELECT Message FROM messages AS m INNER JOIN chats AS c ON c.ID = m.ChatID WHERE `ChatID` = '{chatID}' AND `From` = '{Username()}'", data_out);
                
                con.LoadData($"SELECT Message FROM messages AS m INNER JOIN chats AS c ON c.ID = m.ChatID WHERE `ChatID` = '{chatID}' AND `To` = '{recipient }'", data_in);
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
        private string Username()
        {
            string name = con.ReadString($"SELECT name FROM profile WHERE ID = '{chatID}'");
            return name;
        }
        
        private void btn_send_Click(object sender, EventArgs e)
        {
            string message = txt_message.Text;
          
            if (!string.IsNullOrEmpty(message))
            {
                try
                {
                    con.ExecuteQuery($"INSERT INTO messages (`ChatID`, `Message`, `Date`) VALUES('{chatID}', '{message}', '{date}')");
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
            style.styleChat(data_out);
            style.styleChat(data_in);
        }
    }
}
