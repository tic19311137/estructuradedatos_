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
    public partial class FrmInfoNotPost : Form
    {
        public FrmInfoNotPost()
        {
            InitializeComponent();
        }
     

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNotacionPostfija frmNotacionPostfija = new FrmNotacionPostfija();
            frmNotacionPostfija.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://sites.google.com/a/espe.edu.ec/programacion-ii/home/pila/notacion-postfija-y-prefija");
        }
        private void FrmInfoNotPost_Load(object sender, EventArgs e)
        {
            
        }
    }
}
