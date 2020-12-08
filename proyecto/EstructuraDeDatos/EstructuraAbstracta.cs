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
    public partial class EstructuraAbstracta : Form
    {
        public static string opcion = "int";
        public EstructuraAbstracta()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (radioBtnINT.Checked)
            {
                opcion = "INT";
            }
            else if (radioBtnDOUBLE.Checked)
            {
                opcion = "DOUBLE";
            }
            else if (radioBtnDECIMAL.Checked)
            {
                opcion = "DECIMAL";
            }
            else if (radioBtnCHAR.Checked)
            {
                opcion = "CHAR";
            }
            else if (radioBtnSTRING.Checked)
            {
                opcion = "STRING";
            }
            else if (radioBtnADT1.Checked)
            {
                opcion = "ADT 1";
            }
            else if (radioBtnADT2.Checked)
            {
                opcion = "ADT 2";
            }
            new FrmDatosAbstractosArray().ShowDialog();
        }

        private void EstructuraAbstracta_Load(object sender, EventArgs e)
        {

        }
    }
}
