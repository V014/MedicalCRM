using System;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class Reminders : UserControl
    {
        Connection con = new Connection();
        StyleDataGrid style = new StyleDataGrid();
        utils utils = new utils();
        string date = DateTime.Now.ToString("d");
        public Reminders()
        {
            InitializeComponent();
        }
        private void loadReminders()
        {
            con.LoadData("SELECT * FROM reminders", data_reminders);
            data_reminders.Columns[2].Visible = false;
            data_reminders.Columns[3].Visible = false;
            data_reminders.Columns[4].Visible = false;
            data_reminders.Columns[5].Visible = false;
            data_reminders.Columns[6].Visible = false;
            style.style(data_reminders);
        }
        private void data_reminders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data_reminders.Rows[e.RowIndex];
                txt_title.Text = row.Cells[1].Value.ToString();
                txt_description.Text = row.Cells[2].Value.ToString();
                txt_date.Text = row.Cells[3].Value.ToString();
                txt_time.Text = row.Cells[4].Value.ToString();
                txt_repeat.Text = row.Cells[5].Value.ToString();
                utils.id = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            catch (Exception)
            {

            }
        }
        private void btn_set_Click(object sender, EventArgs e)
        {
            string title = txt_title.Text;
            string description = txt_description.Text;
            string dateset = txt_date.Text;
            string time = txt_time.Text;
            string repeat = txt_repeat.Text;

            // title should atleast be present
            if (!string.IsNullOrEmpty(title))
            {
                try
                {
                    con.ExecuteQuery($"INSERT INTO reminders (Title, Description, Date, Time, Repeat, DateSet) VALUES('{title}', '{description}', '{dateset}', '{time}', '{repeat}', '{date}')");
                    MessageBox.Show("Reminder set!", "Success!");
                    loadReminders();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to set reminder!", "Error!");
                }
            }
            else
            {
                MessageBox.Show("Reminder must atleast have a title!", "Error!");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int id = utils.id;
            string title = txt_title.Text;
            string description = txt_description.Text;
            string dateset = txt_date.Text;
            string time = txt_time.Text;
            string repeat = txt_repeat.Text;

            // title should atleast be present
            if (!string.IsNullOrEmpty(title))
            {
                try
                {
                    con.ExecuteQuery($"UPDATE reminders SET Title = '{title}', Description = '{description}', Date = '{dateset}', Time = '{time}', Repeat = '{repeat}', DateSet = '{date}' WHERE ID = {id}");
                    MessageBox.Show("Reminder updated!", "Success!");
                    loadReminders();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to update reminder!", "Error!");
                }
            }
            else
            {
                MessageBox.Show("Title must atleast have a name!", "Error!");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete reminder?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var id = data_reminders.CurrentRow.Cells[0].Value;
                    // build query to delete user transaction
                    string queryDelete = "DELETE FROM reminders WHERE id = '" + id + "'";
                    con.ExecuteQuery(queryDelete);
                    loadReminders();
                }
                catch (Exception)
                {
                    // show suggestion box
                    MessageBox.Show("Application Error!", "Error!");
                    try
                    {
                        // log the error
                        string queryEvents = "INSERT INTO events (Date, Description, Location) VALUES( '" + date + "', 'SQL error', 'Reminders')";
                        con.ExecuteQuery(queryEvents);
                        MessageBox.Show("Error recorded!");
                    }
                    catch
                    {
                        // if logging fails, close the application
                        Application.Exit();
                    }
                }
            }
        }
    }
}
