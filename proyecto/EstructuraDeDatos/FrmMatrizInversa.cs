using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class FrmMatrizInversa : Form
    {
        Random random = new Random();
        public FrmMatrizInversa()
        {
            InitializeComponent();
        }

        private void FrmMatrizInversa_Load(object sender, EventArgs e)
        {
            Matriz();
        }
        public void Matriz()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dgDeterminante.DataSource = null;
            dataGridView5.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dgDeterminante.Columns.Clear();
            dataGridView5.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dgDeterminante.Rows.Clear();
            dataGridView5.Rows.Clear();

            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                dataGridView1.Columns.Add("Column", "Column");
                dataGridView2.Columns.Add("Column", "Column");
                dgDeterminante.Columns.Add("Column", "Column");
                dataGridView5.Columns.Add("Column", "Column");
            }
            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
                dgDeterminante.Rows.Add();
                dgDeterminante.Rows[i].HeaderCell.Value = "Row" + i;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
                dataGridView5.Rows.Add();
                dataGridView5.Rows[i].HeaderCell.Value = "Row" + i;

            }
            for (int r = 0; r < int.Parse(txtColumnas.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    dataGridView1[c, r].Value = "1";
                    dataGridView2[c, r].Value = "1";
                    dgDeterminante[c, r].Value = "1";
                    dataGridView5[c, r].Value = "1";
                }
            }
        }

        public void matrizTrans()
        {
            dataGridView2.DataSource = null;
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                dataGridView2.Columns.Add("Column", "Column");
            }
            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;

            }
            for (int r = 0; r < int.Parse(txtColumnas.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    dataGridView2[c, r].Value = int.Parse(dataGridView1[r, c].Value.ToString());

                }
            }
        }

        private void btnDimensionar_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtColumnas.Text);
            }
            catch (Exception)
            {
                txtColumnas.Text = "2";
                throw;
            }
            Matriz();
            matrizTrans();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < int.Parse(txtColumnas.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    dataGridView1[c, r].Value = random.Next(int.Parse(txtLimInf.Text) - 1, int.Parse(txtLimSup.Text) + 1).ToString();
                    dgDeterminante[c, r].Value = dataGridView1[c, r].Value;
                }
            }
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dgDeterminante.DataSource = null;
            dataGridView1.Columns.Clear();
            dgDeterminante.Columns.Clear();
            dataGridView1.Rows.Clear();
            dgDeterminante.Rows.Clear();
            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                dataGridView1.Columns.Add("Column", "Column");
                dgDeterminante.Columns.Add("Column", "Column");
            }
            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                dataGridView1.Rows.Add();
                dgDeterminante.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
                dgDeterminante.Rows[i].HeaderCell.Value = "Row" + i;
            }
            dgDeterminante[0, 0].Value = 3;
            dgDeterminante[0, 1].Value = 0;
            dgDeterminante[0, 2].Value = -2;
            dgDeterminante[1, 0].Value = 2;
            dgDeterminante[1, 1].Value = 2;
            dgDeterminante[1, 2].Value = 1;
            dgDeterminante[2, 0].Value = 1;
            dgDeterminante[2, 1].Value = -5;
            dgDeterminante[2, 2].Value = 4;
            dataGridView1[0, 0].Value = 3;
            dataGridView1[0, 1].Value = 0;
            dataGridView1[0, 2].Value = -2;
            dataGridView1[1, 0].Value = 2;
            dataGridView1[1, 1].Value = 2;
            dataGridView1[1, 2].Value = 1;
            dataGridView1[2, 0].Value = 1;
            dataGridView1[2, 1].Value = -5;
            dataGridView1[2, 2].Value = 4;
        }

        private void btnInversa_Click(object sender, EventArgs e)
        {
            double det = 1.0;
            double denominador = 0.0;
            int cols = 0;

            for (int ren = 0; ren < dgDeterminante.RowCount; ren++)
            {
                cols = ren;
                for (int ren1 = ren + 1; ren1 < dgDeterminante.ColumnCount; ren1++)
                {
                    if (double.Parse(dgDeterminante[cols, ren].Value.ToString()) == double.Parse(dgDeterminante[cols, ren1].Value.ToString()))
                    {
                        for (int col2 = cols; col2 < dgDeterminante.ColumnCount; col2++)
                        {
                            dgDeterminante[col2, ren1].Value = double.Parse(dgDeterminante[col2, ren1].Value.ToString()) - double.Parse(dgDeterminante[col2, ren].Value.ToString());
                        }
                    }
                    else
                    {
                        denominador = double.Parse(dgDeterminante[cols, ren1].Value.ToString()) / double.Parse(dgDeterminante[cols, ren].Value.ToString());
                        for (int col2 = cols; col2 < dgDeterminante.ColumnCount; col2++)
                        {
                            dgDeterminante[col2, ren1].Value = double.Parse(dgDeterminante[col2, ren1].Value.ToString())
                                - (double.Parse(dgDeterminante[col2, ren].Value.ToString()) * denominador);
                        }
                    }
                }
            }
            //multiplicacion de los elementos de la diagonal
            for (int col = 0; col < dgDeterminante.ColumnCount; col++)
            {
                det *= double.Parse(dgDeterminante[col, col].Value.ToString());
            }
            lblDet.Text = det.ToString();

            matrizTrans();
            //generar matriz inversa
            for (int r = 0; r < int.Parse(txtColumnas.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    dataGridView5[c, r].Value = double.Parse(dataGridView2[c, r].Value.ToString()) / det;
                }
            }
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {

        }
    }
}
