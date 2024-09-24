using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEstadistica
{
    public partial class frmGrafico : Form
    {
        public double[] EjeX;
        public double[] EjeY;

        public frmGrafico(double[] X, double[] Y)
        {
            InitializeComponent();
            EjeX = X;
            EjeY = Y;

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void frmGrafico_Load(object sender, EventArgs e)
        {
            var sp = formsPlot1.Plot.Add.Scatter(EjeX, EjeY);
            sp.LineWidth = 0;
            sp.MarkerSize = 10;

            ScottPlot.Statistics.LinearRegression reg = new(EjeX, EjeY);

            Coordinates Reg1 = new(EjeX.First(), reg.GetValue(EjeX.First()));
            Coordinates Reg2 = new(EjeY.Last(), reg.GetValue(EjeY.Last()));

            var line = formsPlot1.Plot.Add.Line(Reg1, Reg2);
            line.MarkerSize = 0;
            line.LineWidth = 2;
            line.LinePattern = LinePattern.Dashed;

            formsPlot1.Plot.Add.Line(Reg1, Reg2);
            formsPlot1.Plot.Title(reg.FormulaWithRSquared);


        }
    }
}
