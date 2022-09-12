using System;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        Dashboard dashboard = new Dashboard();
        Patients patients = new Patients();
        Appointments appointments = new Appointments();
        Reminders reminders = new Reminders();
        Messages messages = new Messages();
        Profile profile = new Profile();
        utils utils = new utils();
        Forum forum = new Forum();
        StyleDataGrid stye = new StyleDataGrid();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadHome();
        }
        // loads home
        void loadHome()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            dashboard.AutoSize = true;
            dashboard.Show();
            dashboard.lbl_appointments.Text = utils.countAppointments();
            dashboard.lbl_reminders.Text = utils.countReminders();
            dashboard.lbl_forum.Text = utils.countForum();
            dashboard.lbl_patients.Text = utils.countPatients();
            int id = int.Parse(con.ReadString($"SELECT id FROM session WHERE status = 'online'"));
            dashboard.lbl_name.Text = con.ReadString($"SELECT Name FROM profile WHERE ID = {id}");
            dashboard.lbl_initials.Text = con.ReadString($"SELECT Initials FROM profile WHERE ID = {id}");
        }
        // loads patients
        private void loadPatients()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(patients);
            patients.Dock = DockStyle.Fill;
            patients.Show();
            con.LoadData("SELECT * FROM patients", patients.data_patients);
            patients.data_patients.Columns[2].Visible = false;
            patients.data_patients.Columns[3].Visible = false;
            patients.data_patients.Columns[4].Visible = false;
            patients.data_patients.Columns[5].Visible = false;
            patients.data_patients.Columns[6].Visible = false;
            patients.data_patients.Columns[7].Visible = false;
            patients.data_patients.Columns[8].Visible = false;
            stye.style(patients.data_patients);
        }
        // loads appointments
        public void loadAppointments()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(appointments);
            appointments.Dock = DockStyle.Fill;
            appointments.Show();
            con.LoadData("SELECT * FROM appointments", appointments.data_appointments);
            stye.style(appointments.data_appointments);
        }
        // loads reminder
        public void loadReminder()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(reminders);
            reminders.Dock = DockStyle.Fill;
            reminders.Show();
            con.LoadData("SELECT * FROM reminders", reminders.data_reminders);
            stye.style(reminders.data_reminders);
        }
        // loads the forun
        public void loadForum()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(forum);
            forum.Dock = DockStyle.Fill;
            forum.Show();
            con.LoadData("SELECT * FROM forum", forum.data_forum);
            stye.style(forum.data_forum);
        }
        // loads messages
        public void loadMessages()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(messages);
            messages.Dock = DockStyle.Fill;
            messages.Show();
            con.LoadData("SELECT * FROM messages", messages.data_messages);
            stye.style(messages.data_messages);
        }
        // loads user profile
        public void loadProfile()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
            profile.AutoSize = true;
            profile.Show();
        }
        // opens home page
        private void btn_home_Click(object sender, EventArgs e)
        {
            loadHome();
        }
        // opens patients page
        public void btn_patients_Click(object sender, EventArgs e)
        {
            loadPatients();
        }
        // opens appointments page
        private void btn_appointments_Click(object sender, EventArgs e)
        {
            loadAppointments();
        }
        // opens remiders page
        private void btn_reminders_Click(object sender, EventArgs e)
        {
            loadReminder();
        }
        // opens forum page
        private void btn_forum_Click(object sender, EventArgs e)
        {
            loadForum();
        }
        // opens messages page
        private void btn_messages_Click(object sender, EventArgs e)
        {
            loadMessages();
        }
        // opens profile page
        private void btn_profile_Click(object sender, EventArgs e)
        {
            loadProfile();
        }
        // closes the whole application
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.ExecuteQuery($"UPDATE session SET StaffID = 0, status = 'offline' WHERE ID = 1");
            Application.Exit();
        }
    }
}
