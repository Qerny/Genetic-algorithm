using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravellingSalesmanProblem
{
    public partial class MainForm : Form
    {
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            
        }                    

        private void nmrcCountCities_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                nmrcCountCities.Update();
                var val = nmrcCountCities.Value;
            }
        }

        private void nmrcCountCities_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(nmrcCountCities.Value);
                if (count > 1)
                {
                    dtGrdVwCitiesMatrix.RowCount = dtGrdVwCitiesMatrix.ColumnCount =
                        count;
                }
            }
            catch { }
        }

        // Generates random matrix
        private void btnRandMatr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtGrdVwCitiesMatrix.RowCount; ++i)
            {                
                for (int j = 0; j < i; ++j)
                {
                    dtGrdVwCitiesMatrix[i, j].Value =
                        dtGrdVwCitiesMatrix[j, i].Value =
                            random.Next(1, byte.MaxValue);
                }
                dtGrdVwCitiesMatrix[i, i].Value = "-";
            }
        }

        // Sets inputed matrix value [i,j] to [j, i] too
        private void dtGrdVwCitiesMatrix_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == e.ColumnIndex)
            {
                dtGrdVwCitiesMatrix[e.ColumnIndex, e.RowIndex].Value = "-";
            }
            else
            {
                dtGrdVwCitiesMatrix[e.RowIndex, e.ColumnIndex].Value =
                dtGrdVwCitiesMatrix[e.ColumnIndex, e.RowIndex].Value;
            }
                
        }

        // Checks inputed value in the matrix
        private void dtGrdVwCitiesMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int val = Convert.ToInt32(dtGrdVwCitiesMatrix[e.ColumnIndex, e.RowIndex].Value);
                dtGrdVwCitiesMatrix[e.ColumnIndex, e.RowIndex].Value = Math.Abs(val);

            }
            catch
            {
                dtGrdVwCitiesMatrix[e.ColumnIndex, e.RowIndex].Value =
                    dtGrdVwCitiesMatrix[e.RowIndex, e.ColumnIndex].Value;
            }
        }

        // Gets matrix form the dataGridView
        private int[,] GetMatrix(out int n)
        {
            n = dtGrdVwCitiesMatrix.RowCount;
            var matr = new int[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    matr[i, j] = matr[j, i] = (int)dtGrdVwCitiesMatrix[i, j].Value;
                }
                matr[i, i] = 0;
            }
            return matr;
        }

        // Find the shortest path
        private void btnFindPath_Click(object sender, EventArgs e)
        {
        }
    }
}
