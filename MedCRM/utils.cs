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
        public int id;
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
        public string countPatients()
        {
            string number = con.ReadString("SELECT COUNT(ID) FROM patients");
            return number;
        }
    }
}
