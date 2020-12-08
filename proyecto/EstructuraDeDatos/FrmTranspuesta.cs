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
    public partial class FrmTranspuesta : Form
    {
        //Variable de tipo Random
      Random random = new Random();
        public FrmTranspuesta()
        {
            InitializeComponent();
        }

  

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Eliminamos todas las columnas y renglones del btn generar para que no sigan
            //Añadiendo mas
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                //Con un for agregamos las columnas que ingresa el usuario
                dataGridView1.Columns.Add("Column" + i, "Column" + i);
             
            }
            for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            {
                //Agregamos los renglones al datagridView1
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
            } 
            for (int i = 0; i < int.Parse(txtRenglones.Text); i++)
            {
                //Agregamos las columnas del datagridView2
                dataGridView2.Columns.Add("Column" + i, "Column" + i);
            }
            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                //Se agregan los renglones del datagridView2
                dataGridView2.Rows.Add();
                //Titulo de los renglones
                dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
            }

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < int.Parse(txtRenglones.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    //Generamos de manera aleatoria las celdas del datagridView1
                    dataGridView1[c, r].Value = random.Next(int.Parse(txtInferior.Text) - 1, int.Parse(txtSuperior.Text) + 1);

                }
            }
        }

        private void btnTranspuesta_Click(object sender, EventArgs e)
        {
            //TextBox de Renglones
            for (int r = 0; r < int.Parse(txtRenglones.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                                    //Generamos la transpuesta
                        //Renglones Columnas           //Columnas Renglones
                    dataGridView2[r, c].Value = dataGridView1[c, r].Value.ToString();

                }
            }
        }

        private void txtRenglones_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
