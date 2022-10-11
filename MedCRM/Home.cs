using System;
using System.Security.Principal;
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
        Chats chats = new Chats();
        Profile profile = new Profile();
        utils utils = new utils();
        Forum forum = new Forum();
        StyleDataGrid stye = new StyleDataGrid();
        string identity = WindowsIdentity.GetCurrent().Name;
        public Home()
        {
            InitializeComponent();
        }
        // things during runtime
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
            dashboard.lbl_name.Text = loadUsername();
        }
        // load userID
        private string loadUserID()
        {
            string id = con.ReadString($"SELECT UserID FROM session WHERE identity = '{identity}'");
            return id;
        }
        // load username
        private string loadUsername()
        {
            string name = con.ReadString($"SELECT Name FROM session WHERE identity = '{identity}' AND status = 'online'");
            return name;
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
            appointments.data_appointments.Columns[2].Visible = false;
            appointments.data_appointments.Columns[3].Visible = false;
            appointments.data_appointments.Columns[4].Visible = false;
            appointments.data_appointments.Columns[5].Visible = false;
            appointments.data_appointments.Columns[6].Visible = false;
            appointments.data_appointments.Columns[7].Visible = false;
            appointments.data_appointments.Columns[8].Visible = false;
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
            reminders.data_reminders.Columns[2].Visible = false;
            reminders.data_reminders.Columns[3].Visible = false;
            reminders.data_reminders.Columns[4].Visible = false;
            reminders.data_reminders.Columns[5].Visible = false;
            reminders.data_reminders.Columns[6].Visible = false;
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
            forum.data_forum.ColumnHeadersVisible = false;
            forum.data_forum.Columns[0].Visible = false;
            forum.data_forum.Columns[2].Visible = false;
            forum.data_forum.Columns[3].Visible = false;
            forum.data_forum.Columns[4].Visible = false;
            forum.data_forum.Columns[5].Visible = false;
            forum.data_forum.Columns[6].Visible = false;
            stye.style(forum.data_forum);
        }
        // loads messages
        public void loadChats()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(chats);
            chats.Dock = DockStyle.Fill;
            chats.Show();
            con.LoadData($"SELECT `ID`, `From`, `To` FROM chats WHERE `To` = '{loadUsername()}'", chats.data_chats);
            chats.data_chats.Columns[0].Visible = false;
            // messages.data_messages.Columns[1].Visible = false;
            chats.data_chats.Columns[2].Visible = false;
            stye.styleChat(chats.data_chats);
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
        // opens profile page
        private void btn_profile_Click(object sender, EventArgs e)
        {
            loadProfile();
        }
        // closes the whole application
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.ExecuteQuery($"UPDATE session SET status = 'offline' WHERE identity = '{identity}'");
            Application.Exit();
        }
        // load chats
        private void btn_chats_Click(object sender, EventArgs e)
        {
            loadChats();
        }
    }
}
