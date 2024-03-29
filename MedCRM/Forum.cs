﻿using System;
using System.Windows.Forms;
using System.Media;
using System.Security.Principal;

namespace MedCRM
{
    public partial class Forum : UserControl
    {
        Connection con = new Connection();
        string date = DateTime.Now.ToString("d");
        utils utils = new utils();
        StyleDataGrid style = new StyleDataGrid();
        string identity = WindowsIdentity.GetCurrent().Name;

        public Forum()
        {
            InitializeComponent();
        }
        private void loadForum()
        {
            con.LoadData("SELECT * FROM forum", data_forum);
            data_forum.Columns[0].Visible = false;
            data_forum.Columns[2].Visible = false;
            data_forum.Columns[3].Visible = false;
            data_forum.Columns[4].Visible = false;
            data_forum.Columns[5].Visible = false;
            data_forum.Columns[6].Visible = false;
            style.style(data_forum);
        }
        private void loadComments()
        {
            int id = utils.userID;
            if (id != 0)
            {
                con.LoadData($"SELECT Name, Comment, Date FROM comments WHERE ForumID = '{id}'", data_comments);
                style.styleChat(data_comments);
                data_comments.Columns[0].Width = 100;
                data_comments.Columns[1].Width = 600;
            }
            else
            {
                //MessageBox.Show("Select forum first!", "Warning!");
            }
        }
        private void btn_comment_Click(object sender, EventArgs e)
        {
            string comment = txt_comment.Text;
            int id = utils.userID;
            string name = con.ReadString($"SELECT Name FROM session WHERE identity = '{identity}'");
            
            if (!string.IsNullOrEmpty(comment))
            {
                con.ExecuteQuery($"INSERT INTO comments (ForumID, Name, Comment, Date) VALUES('{id}', '{name}', '{comment}', '{date}')");
                loadComments();
                txt_comment.Clear();
                // play chime
                SoundPlayer chime = new SoundPlayer(@"sfx/pop.wav");
                chime.Play();
            }
            else
            {
                MessageBox.Show("Write comment first!", "Warning!");
            }
        }

        private void data_forum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = data_forum.Rows[e.RowIndex];
            txt_title.Text = row.Cells[1].Value.ToString();
            txt_description.Text = row.Cells[3].Value.ToString();
            txt_date.Text = row.Cells[4].Value.ToString();
            txt_time.Text = row.Cells[6].Value.ToString();
            txt_lead.Text = row.Cells[2].Value.ToString();
            utils.userID = Convert.ToInt32(row.Cells[0].Value.ToString());
            loadComments();
            style.styleChat(data_comments);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int id = utils.userID;
            string title = txt_title.Text;
            string description = txt_description.Text;
            string dateset = txt_date.Text;
            string time = txt_time.Text;

            // title should atleast be present
            if (!string.IsNullOrEmpty(title))
            {
                try
                {
                    con.ExecuteQuery($"UPDATE forum SET Title = '{title}', Description = '{description}', Date = '{dateset}', Time = '{time}', DateSet = '{date}' WHERE ID = {id}");
                    MessageBox.Show("Forum updated!", "Success!");
                    loadForum();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to update forum!", "Error!");
                }
            }
            else
            {
                MessageBox.Show("Title must atleast have a name!", "Error!");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string title = txt_title.Text;
            string lead = txt_lead.Text;
            string dateset = txt_date.Text;
            string time = txt_time.Text;
            string description = txt_description.Text;

            try
            {
                con.ExecuteQuery($"INSERT INTO forum (Title, Lead, Description, Date, Time, DateSet) VALUES('{title}', '{lead}', '{description}', '{dateset}', '{time}', '{date}')");
                loadForum();
            }
            catch (Exception)
            {
                MessageBox.Show("Application Error!", "Error!");
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
