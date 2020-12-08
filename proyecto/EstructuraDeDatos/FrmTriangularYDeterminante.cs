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
    public partial class FrmTriangularYDeterminante : Form
    {
        Random random = new Random();
        public FrmTriangularYDeterminante()
        {
            InitializeComponent();
        }

        public void MatrizGeneradaDg()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            try
            {
                for (int i = 0; i < int.Parse(txtRenglonesyCols.Text); i++)
                {
                    dataGridView1.Columns.Add("Column", "Column");
                    dataGridView2.Columns.Add("Column", "Column");
                }
                for (int i = 0; i < int.Parse(txtRenglonesyCols.Text); i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
                }
                for (int r = 0; r < int.Parse(txtRenglonesyCols.Text); r++)
                {
                    for (int c = 0; c < int.Parse(txtRenglonesyCols.Text); c++)
                    {
                        dataGridView1[c, r].Value = random.Next(int.Parse(txtInferior.Text) - 1, int.Parse(txtSuperior.Text) + 1);
                        dataGridView2[c, r].Value = dataGridView1[c, r].Value;

                    }
                }
                pictureBox1.Visible = false;
            }
            catch (Exception)
            {

                //errorProvider1.SetError(txtRenglonesyCols, "Error, debes escribir caracteres númericos");
                pictureBox1.Visible = true;
            }

            
        }
        private void FrmTriangularYDeterminante_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MatrizGeneradaDg();
            
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            /*for (int r = 0; r < int.Parse(txtRenglonesyCols.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtRenglonesyCols.Text); c++)
                {
                    dataGridView1[c, r].Value = random.Next(int.Parse(txtInferior.Text) - 1, int.Parse(txtSuperior.Text) + 1);
                }
            }*/
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double denominador = 0.0;
            int cols = 0;
            double det = 1.0;

            for (int ren = 0; ren < dataGridView2.RowCount; ren++)
            {
                cols = ren;
                for (int ren1 = ren + 1; ren1 < dataGridView2.ColumnCount; ren1++)
                {
                    if (double.Parse(dataGridView2[cols, ren].Value.ToString()) == double.Parse(dataGridView2[cols, ren1].Value.ToString()))
                    {
                        lblError.Visible = true;
                        lblError.Text = "son iguales";

                        for (int col2 = cols; col2 < dataGridView2.ColumnCount; col2++)
                        {
                            dataGridView2[col2, ren1].Value = double.Parse(dataGridView2[col2, ren1].Value.ToString()) - double.Parse(dataGridView2[col2, ren].Value.ToString());
                        }
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "no son iguales";
                        denominador = double.Parse(dataGridView2[cols, ren1].Value.ToString()) / double.Parse(dataGridView2[cols, ren].Value.ToString());
                        for (int col2 = cols; col2 < dataGridView2.ColumnCount; col2++)
                        {
                            dataGridView2[col2, ren1].Value = double.Parse(dataGridView2[col2, ren1].Value.ToString())
                                - (double.Parse(dataGridView2[col2, ren].Value.ToString()) * denominador);
                        }
                    }
                    
                    
                }

                }
            for (int col = 0; col < dataGridView2.ColumnCount; col++)
            {

                det *= double.Parse(dataGridView2[col, col].Value.ToString());
            }
            txtDeterminante.Text = det.ToString();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            lblError.Visible = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            lblError.Visible = true;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblError.Visible = false;

        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = null;
            dataGridView2.Columns.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Clear();

       
                for (int i = 0; i <3; i++)
                {
                    dataGridView2.Columns.Add("Column", "Column");
                    dataGridView1.Columns.Add("Column", "Column");
                }
                for (int i = 0; i < 3; i++)
                {
                    dataGridView2.Rows.Add();
                    dataGridView1.Rows.Add();
                    dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
                    dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
                }

            dataGridView2[0, 0].Value = 3;
            dataGridView2[0, 1].Value = 0;
            dataGridView2[0, 2].Value = -2;
            dataGridView2[1, 0].Value = 2;
            dataGridView2[1, 1].Value = 2;
            dataGridView2[1, 2].Value = 1;
            dataGridView2[2, 0].Value = 1;
            dataGridView2[2, 1].Value = -5;
            dataGridView2[2, 2].Value = 4; 
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

        private void btnEjemploSup_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = null;
            dataGridView2.Columns.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();


            for (int i = 0; i < 4; i++)
            {
                dataGridView2.Columns.Add("Column", "Column");
                dataGridView1.Columns.Add("Column", "Column");
            }
            for (int i = 0; i < 4; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView1.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
                dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
            }

            dataGridView1[0, 0].Value = 2;
            dataGridView1[0, 1].Value = 0;
            dataGridView1[0, 2].Value = 0;
            dataGridView1[0, 3].Value = 0;
            dataGridView1[1, 0].Value = 2;
            dataGridView1[1, 1].Value = 8;
            dataGridView1[1, 2].Value = 0;
            dataGridView1[1, 3].Value = 0;
            dataGridView1[2, 0].Value = 1;
            dataGridView1[2, 1].Value = -5;
            dataGridView1[2, 2].Value = 4;
            dataGridView1[2, 3].Value = 0;
            dataGridView1[3, 0].Value = 1;
            dataGridView1[3, 1].Value = 5;
            dataGridView1[3, 2].Value = 4;
            dataGridView1[3, 3].Value = 2;


            dataGridView2[0, 0].Value = 2;
            dataGridView2[0, 1].Value = 0;
            dataGridView2[0, 2].Value = 0;
            dataGridView2[0, 3].Value = 0;
            dataGridView2[1, 0].Value = 2;
            dataGridView2[1, 1].Value = 8;
            dataGridView2[1, 2].Value = 0;
            dataGridView2[1, 3].Value = 0;
            dataGridView2[2, 0].Value = 1;
            dataGridView2[2, 1].Value = -5;
            dataGridView2[2, 2].Value = 4;
            dataGridView2[2, 3].Value = 0;
            dataGridView2[3, 0].Value = 1;
            dataGridView2[3, 1].Value = 5;
            dataGridView2[3, 2].Value = 4;
            dataGridView2[3, 3].Value = 2;

        }

        private void btnEjemploInferior_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = null;
            dataGridView2.Columns.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();


            for (int i = 0; i < 4; i++)
            {
                dataGridView2.Columns.Add("Column", "Column");
                dataGridView1.Columns.Add("Column", "Column");
            }
            for (int i = 0; i < 4; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView1.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
                dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
            }

            dataGridView1[0, 0].Value = 2;
            dataGridView1[0, 1].Value = 5;
            dataGridView1[0, 2].Value = 4;
            dataGridView1[0, 3].Value = 8;
            dataGridView1[1, 0].Value = 0;
            dataGridView1[1, 1].Value = 2;
            dataGridView1[1, 2].Value = 3;
            dataGridView1[1, 3].Value = 1;
            dataGridView1[2, 0].Value = 0;
            dataGridView1[2, 1].Value = 0;
            dataGridView1[2, 2].Value = 8;
            dataGridView1[2, 3].Value = 5;
            dataGridView1[3, 0].Value = 0;
            dataGridView1[3, 1].Value = 0;
            dataGridView1[3, 2].Value = 0;
            dataGridView1[3, 3].Value = 5;


            dataGridView2[0, 0].Value = 2;
            dataGridView2[0, 1].Value = 5;
            dataGridView2[0, 2].Value = 4;
            dataGridView2[0, 3].Value = 8;
            dataGridView2[1, 0].Value = 0;
            dataGridView2[1, 1].Value = 2;
            dataGridView2[1, 2].Value = 3;
            dataGridView2[1, 3].Value = 1;
            dataGridView2[2, 0].Value = 0;
            dataGridView2[2, 1].Value = 0;
            dataGridView2[2, 2].Value = 8;
            dataGridView2[2, 3].Value = 5;
            dataGridView2[3, 0].Value = 0;
            dataGridView2[3, 1].Value = 0;
            dataGridView2[3, 2].Value = 0;
            dataGridView2[3, 3].Value = 5;
        }
    }
}
