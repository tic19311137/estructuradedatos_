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
    public partial class FrmDatosAbstractosArray : Form
    {
        datoAbstracto dAbstracto;
        datoAbstractoPerro dPerro;
        int r = 0;
        int c = 0;
        public FrmDatosAbstractosArray()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (validarCampo())
            {
                if (EstructuraAbstracta.opcion == "ADT 1")
                {
                    dgElementos[c, r].Value = new datoAbstracto(txtElementos.Text).Nombre;
                }
                else if (EstructuraAbstracta.opcion == "ADT 2")
                {
                    dgElementos[c, r].Value = new datoAbstractoPerro(txtElementos.Text).Nombre;
                }
                else dgElementos[c, r].Value = txtElementos.Text;

                r++;
                if (r == 3) { c++; r = 0; }
                txtElementos.Clear();
                txtElementos.Focus();
                if (c == 3)
                {
                    btnCapturar.Enabled = false;
                    txtElementos.Enabled = false;
                }
                else
                {
                    label1.Text = "Elemento [" + c + "," + r + "]= ";
                }
            }
            else
            {
                MessageBox.Show("NO PUEDES PONER LETRAS");
                txtElementos.Focus();
                txtElementos.Clear();
            }

        }

        public bool validarCampo()
        {

            switch (EstructuraAbstracta.opcion)
            {
                case "INT": return int.TryParse(txtElementos.Text, out int x);
                case "DOUBLE": return double.TryParse(txtElementos.Text, out double y);
                case "DECIMAL": return decimal.TryParse(txtElementos.Text, out decimal z);
                case "CHAR": return char.TryParse(txtElementos.Text, out char t);
                case "STRING": return true;
                case "ADT 1": return true;
                case "ADT 2": return true;
                default: return false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            r = 0;
            c = 0;
            btnCapturar.Enabled = true;
            lblElemento.Text = "Elemento [0,0]";
            dgElementos.Rows.Clear();
            dgElementos.Rows.Add();
            dgElementos.Rows.Add();
            dgElementos.Rows.Add();
            txtElementos.Enabled = true;
            txtElementos.Focus();

        }

        private void FrmDatosAbstractosArray_Load(object sender, EventArgs e)
        {
          
            dgElementos.Rows.Add();
            dgElementos.Rows.Add();
            dgElementos.Rows.Add();
            dgElementos.Rows[0].Height = 29; 
            dgElementos.Rows[1].Height = 29; 
            dgElementos.Rows[2].Height = 29; 
            dgElementos.Rows[0].HeaderCell.Value = "Renglón 1";
            dgElementos.Rows[1].HeaderCell.Value = "Renglón 2";
            dgElementos.Rows[2].HeaderCell.Value = "Renglón 3";
            lblDato.Text = EstructuraAbstracta.opcion;

        }
    }

    public class datoAbstracto
    {

        private string nombre;

        public datoAbstracto()
        {

        }
        public datoAbstracto(string nomb)
        {
            Nombre = nomb;

        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
    public class datoAbstractoPerro
    {
        private string raza;

        public datoAbstractoPerro()
        {

        }
        public datoAbstractoPerro(string raza)
        {
            this.raza = raza;

        }

        public string Nombre { get => raza; set => raza = value; }
    }
}
