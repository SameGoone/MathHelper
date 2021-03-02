using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetMAndDButton_Click(object sender, EventArgs e)
        {
            double[,] distributionLaw = new double[RandomGrid.ColumnCount, RandomGrid.RowCount];
            for (int i = 0; i < RandomGrid.RowCount; i++)
                for (int j = 0; j < RandomGrid.ColumnCount; j++)
                    distributionLaw[j, i] = Convert.ToDouble(RandomGrid[j, i].Value);

            RandomValue rv = new RandomValue(distributionLaw);
            MResultBox.Text = rv.ExpectedValue.ToString(); 
            DResultBox.Text = rv.Dispersion.ToString();
        }

        private void GetSampleResultButton_Click(object sender, EventArgs e)
        {
            double[,] distributionLaw = new double[SampleGrid.ColumnCount, SampleGrid.RowCount];
            for (int i = 0; i < SampleGrid.RowCount; i++)
                for (int j = 0; j < SampleGrid.ColumnCount; j++)
                    distributionLaw[j, i] = Convert.ToDouble(SampleGrid[j, i].Value);

            Sample s = new Sample(distributionLaw);
            SampleMeanBox.Text = s.Mean.ToString();
            SampleDispersionBox.Text = s.Dispersion.ToString();
            SampleExactleDispersionBox.Text = s.ExactleDispersion.ToString();
        }

        private void GetCombResultButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mCombInputBox.Text))
            {
                double n;
                double.TryParse(nCombInputBox.Text, out n);
                Combinatorics comb = new Combinatorics(n);

                PCombOutputBox.Text = comb.P.ToString();
            }
            else
            {
                double n;
                double m;
                double.TryParse(nCombInputBox.Text, out n);
                double.TryParse(mCombInputBox.Text, out m);

                Combinatorics combCA = new Combinatorics(n, m);
                Combinatorics combP = new Combinatorics(n);

                PCombOutputBox.Text = combP.P.ToString();
                CCombOutputBox.Text = combCA.C.ToString();
                ACombOutputBox.Text = combCA.A.ToString();
            }
        }

        private void ClearRandomButton_Click(object sender, EventArgs e)
        {
            MResultBox.Text = string.Empty;
            DResultBox.Text = string.Empty;
            RandomGrid.Rows.Clear();
        }

        private void ClearSampleButton_Click(object sender, EventArgs e)
        {
            SampleMeanBox.Text = string.Empty;
            SampleDispersionBox.Text = string.Empty;
            SampleExactleDispersionBox.Text = string.Empty;
            SampleGrid.Rows.Clear();
        }

        private void ClearCombButton_Click(object sender, EventArgs e)
        {
            mCombInputBox.Text = string.Empty;
            nCombInputBox.Text = string.Empty;
            PCombOutputBox.Text = string.Empty;
            CCombOutputBox.Text = string.Empty;
            ACombOutputBox.Text = string.Empty;
        }
    }
}
