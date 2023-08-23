using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasse
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmMensalista_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            if (rbtnSim.Checked)
                objMensalista.HomeOficce = 'S';
            else
                objMensalista.HomeOficce = 'N';

            //get
            MessageBox.Show("Matrícula:  " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data Entrada: " +
                objMensalista.DataEntradaEmpresa.ToShortDateString() +
                "\n" +
                "Salario Bruto: " + objMensalista.SalarioBruto().ToString("N2")
                + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() +
                '\n' + objMensalista.VerificaHome());
        }
    }
}
