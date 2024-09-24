using Entidades;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace AppEstadistica
{
    public partial class frmDatos : Form
    {
        private int NFilas;

        public frmDatos(int Cantidad)
        {
            InitializeComponent();
            NFilas = Cantidad;

            dgvDatos.Rows.Add(NFilas);
            tabControl1.TabPages[2].Enabled = false;
            tabControl1.TabPages[1].Enabled = false;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {



        }

        private void dgvDatos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void dgvDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double SumaX = 0;
            double SumaY = 0;
            double SumaXCuadrado = 0;
            double SumaYCuadrado = 0;
            double SumaXY = 0;
            Calculos calculos = new Calculos();
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {

                if (double.TryParse(dgvDatos.Rows[i].Cells[0].Value?.ToString(), out double valorX))
                {
                    SumaX = valorX + SumaX;
                    double resultadoX = Math.Pow(valorX, 2);
                    dgvDatos.Rows[i].Cells[2].Value = resultadoX;
                    SumaXCuadrado = SumaXCuadrado + resultadoX;
                }


                if (double.TryParse(dgvDatos.Rows[i].Cells[1].Value?.ToString(), out double valorY))
                {
                    SumaY = valorY + SumaY;
                    double resultadoY = Math.Pow(valorY, 2);
                    dgvDatos.Rows[i].Cells[3].Value = resultadoY;
                    SumaYCuadrado = SumaYCuadrado + resultadoY;
                }

                if (double.TryParse(dgvDatos.Rows[i].Cells[0].Value?.ToString(), out double valorX2) && double.TryParse(dgvDatos.Rows[i].Cells[1].Value?.ToString(), out double valorY2))
                {
                    double ResultadoXY = valorX2 * valorY2;
                    SumaXY = SumaXY + ResultadoXY;
                    dgvDatos.Rows[i].Cells[4].Value = ResultadoXY;
                }
                tabControl1.TabPages[2].Enabled = true; 
                tabControl1.TabPages[1].Enabled = true; 

            }


            b1txt.Text = Convert.ToString((Math.Truncate(calculos.b1(SumaXY, SumaX, SumaY, SumaXCuadrado, NFilas) * 10000)) / 10000);

            b0txt.Text = Convert.ToString((Math.Truncate(calculos.b0() * 10000)) / 10000);
            RVtxt.Text = Convert.ToString((Math.Truncate(calculos.RV1(SumaYCuadrado) * 10000)) / 10000);
            Rcuadradotxt.Text = Convert.ToString((Math.Truncate(calculos.R2() * 10000)) / 10000);
            Rtxt.Text = Convert.ToString((Math.Truncate(calculos.R() * 10000)) / 10000);
            Ttxt.Text = Convert.ToString((Math.Truncate(calculos.t_student() * 10000)) / 10000);

            //int rowCount = dgvDatos.Rows.Count;
            //int ColumnCount = dgvDatos.Columns.Count;

            //double[] X = new double[rowCount];
            //double[] Y = new double[ColumnCount];

            //for (int i = 0; i < rowCount; i++)
            //{
            //    X[i] = double.Parse(dgvDatos.Rows[i].Cells[0].Value?.ToString());

            //    Y[i] = double.Parse(dgvDatos.Rows[i].Cells[2].Value?.ToString());
            //}

            tabPage2.Enabled = true;
            tabPage3.Enabled = true;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btndelete_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro que quieres eliminar todos los datos?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Value = "";
                    }
                }
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void tabpage3_Selected(object sender, TabControlEventArgs e)
        {


        }

        private void frmDatos_Load(object sender, EventArgs e)
        {


        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage3) // Verifica si estás en la página 3
            {
                int rowCount = dgvDatos.Rows.Count;
                double[] X = new double[rowCount];
                double[] Y = new double[rowCount];

                for (int i = 0; i < rowCount; i++)
                {
                    X[i] = double.Parse(dgvDatos.Rows[i].Cells[0].Value?.ToString());

                    Y[i] = double.Parse(dgvDatos.Rows[i].Cells[1].Value?.ToString());
                }

                var sp = formsPlot1.Plot.Add.Scatter(X, Y);
                sp.LineWidth = 0;
                sp.MarkerSize = 10;

                ScottPlot.Statistics.LinearRegression reg = new(X, Y);

                Coordinates Reg1 = new(X.First(), reg.GetValue(X.First()));
                Coordinates Reg2 = new(Y.Last(), reg.GetValue(Y.Last()));

                var line = formsPlot1.Plot.Add.Line(Reg1, Reg2);
                line.MarkerSize = 0;
                line.LineWidth = 2;
                line.LinePattern = LinePattern.Dashed;

                formsPlot1.Plot.Add.Line(Reg1, Reg2);
                formsPlot1.Plot.Title(reg.FormulaWithRSquared);
            }
        }
    }
}
