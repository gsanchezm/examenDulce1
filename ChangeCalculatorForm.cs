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
    public partial class ChangeCalculatorForm : Form
    {
        public ChangeCalculatorForm()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal dinero = nudMoney.Value;
            Change change = new Change(dinero);

            lblQuinientos.Text = $"Billetes de Quinientos: {change.BilletesQuinientos}";
            lblDoscientos.Text = $"Billetes de  Doscientos {change.BilletesDoscientos}";
            lblCien.Text = $"Billetes de Cien: {change.BilletesCien}";
            lblCincuenta.Text = $"Billetes de Cincuenta: {change.BilletesCincuenta}";
            lblveinte.Text = $"Billetes de veinte: {change.BilletesVeinte}";
            lblCinco.Text = $"Monedas de 5 peso: {change.MonedaCincoPesos}";
            lblDos.Text = $"Monedas de 2 peso: {change.MonedaDosPesos}";
            lblUno.Text = $"Monedas de 1 peso: {change.MonedaPeso}";
            lblCincuentaCents.Text = $"Monedas de 50 centavos: {change.MonedaCincuentaCents}";
        }
    }
}
