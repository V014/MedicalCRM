using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCRM
{
    class utils
    {
        Connection con = new Connection();
        // stores user ID during a session
        public int id;
        // stores the user name during a session
        public string name;
        // counts the reminders
        public string countReminders()
        {
            string number = con.ReadString("SELECT COUNT(ID) FROM reminders");
            return number;
        }
        // counts the appointments
        public string countAppointments()
        {
            string number = con.ReadString("SELECT COUNT(ID) FROM appointments");
            return number;
        }
        // counts the forums
        public string countForum()
        {
            string number = con.ReadString("SELECT COUNT(ID) FROM forum");
            return number;
        }
        // counts the patients
        public string countPatients()
        {
            string number = con.ReadString("SELECT COUNT(ID) FROM patients");
            return number;
        }
    }
}
