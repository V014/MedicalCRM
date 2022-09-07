using System;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class Patients : UserControl
    {
        patientRegistration pr = new patientRegistration();
        AddPatient addPatient = new AddPatient();
        Connection con = new Connection();
        public Patients()
        {
            InitializeComponent();
        }
        public void patientRegistration()
        {
            addPatient.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            patientRegistration();
        }
    }
}
