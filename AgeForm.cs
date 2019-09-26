using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPrimerPAacial
{
    public partial class AgeForm : Form
    {
        public AgeForm()
        {
            InitializeComponent();
        }

        private void BtnCalcularEdad_Click(object sender, EventArgs e)
        {
            string dob = dtpDateOfBirth.Value.ToString("dd-MM-yyyy");
            lblEdad.Text = Age.CalculateYourAge(Convert.ToDateTime(dob));

        }
    }
}
