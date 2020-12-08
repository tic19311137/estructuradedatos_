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
    public partial class FrmRecursividad : Form
    {
        ulong a = 0;
        ulong b = 1;
        ulong c = 1;
        public FrmRecursividad()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgLimite.Rows.Clear();
            dgLimite.Rows.Add("0");
            dgLimite.Rows[0].HeaderCell.Value = "1";
            int i = 1;
            for (a=0, b=1, c=1; ;)
            {
                if (c > ulong.Parse(txtLimite.Text)) break;
                dgLimite.Rows.Add(c.ToString());
                dgLimite.Rows[i++].HeaderCell.Value = i.ToString(); 
                c = a + b;
                a = b;
                b = c;
            }
        }

        private void FrmRecursividad_Load(object sender, EventArgs e)
        {

        }
    }
}
