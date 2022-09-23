using System;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class Messages : UserControl
    {
        Connection con = new Connection();
        StyleDataGrid style = new StyleDataGrid();
        utils utils = new utils();
        string recipient;

        public Messages()
        {
            InitializeComponent();
        }
        // loads messages onto text datagrid
        private void loadTexts()
        {
            try
            {
                con.LoadData($"SELECT Message FROM messages WHERE `From` = '{recipient}'", data_texts);
            }
            catch(Exception)
            {
                MessageBox.Show("Error Message!", "Error!");
            }
        }

        private void data_messages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = data_messages.Rows[e.RowIndex];
            txt_from.Text = row.Cells[1].Value.ToString();
            txt_to.Text = row.Cells[2].Value.ToString();
            txt_date.Text = row.Cells[3].Value.ToString();
            recipient = row.Cells[1].Value.ToString();
            loadTexts();
            style.styleChat(data_texts);
           // id = int.Parse(con.ReadString(($"SELECT ID, FROM messages WHERE ", messages.data_messages));
            //  name = con.ReadString($"SELECT Name FROM profile WHERE ID = {id}");
        }
    }
}
