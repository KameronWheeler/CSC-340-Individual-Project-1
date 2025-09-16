using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class DoctorMedicineRequest : Form
    {


        public DoctorMedicineRequest()
        {
            
            
            InitializeComponent();
            requestList.Items.Add("Jane Doe");
            datePrescribed.Text = "08/12/2025";
            RxPurpose.Text = "Ear Infection";
            numRefills.Text = "0";
            MedicationName.Text = "Amoxicillin";
            patientName.Text = "Jane Doe";

        }

        private void drNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void DoctorMedicineRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
