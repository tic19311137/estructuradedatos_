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
    public partial class FrmEstructuraDeDatos : Form
    {
        float alumno1 = 3.14f;
        double maestro1 = 3.14;
        Alumnos alumno = new Alumnos();
        Maestros maestro = new Maestros();
        public FrmEstructuraDeDatos()
        {
            InitializeComponent();
            alumno1.ToString();
            alumno.ToString();
            maestro1.ToString();
            maestro.ToString();
        }

        private void FrmEstructuraDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void triangularYDeterminanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Triangular Anonima
            new FrmTriangularYDeterminante().ShowDialog();
            //Triangular con objeto
            //Instancia de la forma FrmTriangularYDeterminante
            //FrmTriangularYDeterminante frmTriangularYDeterminante = new FrmTriangularYDeterminante();
            //frmTriangularYDeterminante.ShowDialog();

            
        }

        private void tiposDeDatosAbstractosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new FrmDatosAbstractosArray().ShowDialog();
        }

        private void tiposDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EstructuraAbstracta().ShowDialog();
        }

        private void serieDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRecursividad().ShowDialog();
        }

        private void memoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMemorama().ShowDialog();
        }

        private void matrizTranspuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTranspuesta().ShowDialog();
        }

        private void matrizInversaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMatrizInversa().ShowDialog();
        }

        private void matrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSumaMatrices().ShowDialog();
        }

        private void pilaGenericaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPilaGenerica().ShowDialog();
        }

        private void evaluaciónDeExpresionesPostfijasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNotacionPostfija().ShowDialog();
        }

        private void torresDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTorresDeHanoi().ShowDialog();
        }
    }
    //Clases abstractas 
    class Alumnos
    {

    }

    class Maestros
    {

    }
}

