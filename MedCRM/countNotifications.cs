namespace MedCRM
{
    class countNotifications
    {
        Connection con = new Connection();
        public string countReminders()
        {
            string number = con.ReadString("SELECT COUNT(ID) FROM reminders");
            return number;
        }
        public string countAppointments()
        {
            string number = con.ReadString("SELECT COUNT(ID) FROM appointments");
            return number;
        }
        public string countForum()
        {
            string number = con.ReadString("SELECT COUNT(ID) FROM forum");
            return number;
        }
    }
}
