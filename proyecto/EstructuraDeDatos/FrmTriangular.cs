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
    public partial class FrmTriangular : Form
    {
        Random random = new Random();
        public FrmTriangular()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //for (int r = 0; r < int.Parse(txtRenglones.Text); r++)
            //{
            //    for (int c = 0; c < int.Parse(txtRenglones.Text); c++)
            //    {
            //        dataGridView1[c, r].Value = random.Next(int.Parse(txtInferior.Text) - 1, int.Parse(txtSuperior.Text) + 1);
            //    }
            //}
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtRenglones.Text);
            }
            catch (Exception)
            {

                txtRenglones.Text = "2";
            }
            dataGridView1.Columns.Clear();
           
            for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            {
                dataGridView1.Columns.Add("Column" + i, "Column" + i);
               

            }
            for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            {
                dataGridView1.Rows.Add();
               
                dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
               
            }
            for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            {
                //dataGridView2.Columns.Add("Column" + i, "Column" + i);
            }
            for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            {
                //dataGridView2.Rows.Add();
                //dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
            }
            for (int c = 0; c < int.Parse(txtRenglones.Text); c++)
            {
                for (int r = 0; r < int.Parse(txtRenglones.Text); r++)
                {
                    //dataGridView1[c, r].Value = "1";
                    for (int ren = 0; ren < int.Parse(txtRenglones.Text); ren++)
                    {
                        for (int cols = 0; cols < int.Parse(txtRenglones.Text); cols++)
                        {
                            dataGridView1[cols, ren].Value = random.Next(int.Parse(txtInferior.Text) - 1, int.Parse(txtSuperior.Text) + 1);
                        }
                    }
                }
            }

            //for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            //{
            //    for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            //    {

            //    }
            //}
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int.Parse(txtRenglones.Text);
            //}
            //catch (Exception)
            //{

            //    txtRenglones.Text = "2";
            //}
            //dataGridView2.Columns.Clear();

            //for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            //{
            //    //dataGridView1.Columns.Add("Column" + i, "Column" + i);
            //    dataGridView2.Columns.Add("Column" + i, "Column" + i);


            //}
            //for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            //{
            //    //dataGridView1.Rows.Add();

            //    //dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
            //    dataGridView2.Rows.Add();

            //    dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;

            //}
            //for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            //{
            //    //dataGridView2.Columns.Add("Column" + i, "Column" + i);
            //}
            //for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            //{
            //    //dataGridView2.Rows.Add();
            //    //dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
            //}
            //for (int c = 0; c < int.Parse(txtRenglones.Text); c++)
            //{
            //    for (int r = 0; r < int.Parse(txtRenglones.Text); r++)
            //    {
            //        //dataGridView1[c, r].Value = "1";
            //    }
            //}

            //for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            //{
            //    for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            //    {

            //    }
            //}

            //for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            //{
            //    for (int c = 0; c < int.Parse(txtRenglones.Text); c++)
            //    {

            //    }
            //}

            double denominador = 0.0;
            int columns = 0;
            for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            {
                //for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
                //{

                //}
            }
        }
    }
}
