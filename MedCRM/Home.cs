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
        countNotifications countNotifications = new countNotifications();
        patientRegistration patientRegistration = new patientRegistration();
        Forum forum = new Forum();
        StyleDataGrid stye = new StyleDataGrid();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadHome();
            dashboard.lbl_appointments.Text = countNotifications.countAppointments();
            dashboard.lbl_reminders.Text = countNotifications.countReminders();
            dashboard.lbl_forum.Text = countNotifications.countForum();
        }
        // loads home
        void loadHome()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            dashboard.AutoSize = true;
            dashboard.Show();
        }
        // loads patients
        public void loadPatients()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(patients);
            patients.Dock = DockStyle.Fill;
            patients.Show();
            con.LoadData("SELECT * FROM patients", patients.data_patients);
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
        // opens home page
        private void btn_home_Click(object sender, EventArgs e)
        {
            loadHome();
        }
        // opens patients page
        private void btn_patients_Click(object sender, EventArgs e)
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
    }
}
