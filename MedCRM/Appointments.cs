using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class Appointments : UserControl
    {
        Connection con = new Connection();
        utils utils = new utils();
        string date = DateTime.Now.ToString("d");
        StyleDataGrid style = new StyleDataGrid();
        public Appointments()
        {
            InitializeComponent();
            loadFacilites();
        }
        private void loadAppointments()
        {
            con.LoadData("SELECT * FROM appointments", data_appointments);
            data_appointments.Columns[2].Visible = false;
            data_appointments.Columns[3].Visible = false;
            data_appointments.Columns[4].Visible = false;
            data_appointments.Columns[5].Visible = false;
            data_appointments.Columns[6].Visible = false;
            data_appointments.Columns[7].Visible = false;
            data_appointments.Columns[8].Visible = false;
            style.style(data_appointments);
        }
        private void loadFacilites()
        {
            con.LoadItems("SELECT Name FROM facility", txt_facility);
        }
        // pulls data from the grind and throws it to the controls
        private void data_appointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data_appointments.Rows[e.RowIndex];
                txt_interviewer.Text = row.Cells[1].Value.ToString();
                txt_interviewee.Text = row.Cells[2].Value.ToString();
                txt_intervieweePosition.Text = row.Cells[3].Value.ToString();
                txt_facility.Text = row.Cells[4].Value.ToString();
                txt_description.Text = row.Cells[5].Value.ToString();
                txt_date.Text = row.Cells[6].Value.ToString();
                txt_time.Text = row.Cells[7].Value.ToString();
                txt_status.Text = row.Cells[8].Value.ToString();
                utils.id = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            catch (Exception)
            {

            }
        }
        // gets form data and pushes it to the database
        private void btn_set_Click(object sender, EventArgs e)
        {
            string interviewer = txt_interviewer.Text;
            string interviewee = txt_interviewee.Text;
            string intervieweePosition = txt_intervieweePosition.Text;
            string facility = txt_facility.Text;
            string description = txt_description.Text;
            string date = txt_date.Text;
            string time = txt_time.Text;
            string status = txt_status.Text;

            // name should atleast be present
            if (!string.IsNullOrEmpty(interviewer))
            {
                try
                {
                    con.ExecuteQuery($"INSERT INTO appointments (Interviewer, Interviewee, IntervieweePosition, Facility, Description, Date, Time, Status, DateRecorded)" +
                       $"VALUES('{interviewer}', '{interviewee}', '{intervieweePosition}', '{facility}', '{description}', '{date}', '{time}', '{status}', '{date}')");
                    MessageBox.Show("Patient registered!", "Success!");
                    loadAppointments();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to set appointment!", "Error!");
                }
            }
            else
            {
                MessageBox.Show("Interviewer must atleast have a name!", "Error!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = utils.id;
            string interviewer = txt_interviewer.Text;
            string interviewee = txt_interviewee.Text;
            string intervieweePosition = txt_intervieweePosition.Text;
            string facility = txt_facility.Text;
            string description = txt_description.Text;
            string dateOn = txt_date.Text;
            string time = txt_time.Text;
            string status = txt_status.Text;

            // name should atleast be present
            if (!string.IsNullOrEmpty(interviewer))
            {
                try
                {
                    con.ExecuteQuery($"UPDATE appointments SET Interviewer = '{interviewer}', Interviewee = '{interviewee}', IntervieweePosition = '{intervieweePosition}', Facility = '{facility}', Description = '{description}', Date = '{dateOn}', Time = '{time}', Status = '{status}' WHERE ID = {id}");
                    MessageBox.Show("Appointment updated!", "Success!");
                    loadAppointments();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to update appointment!", "Error!");
                }
            }
            else
            {
                MessageBox.Show("Interviewer must atleast have a name!", "Error!");
            }
        }
    }
}
