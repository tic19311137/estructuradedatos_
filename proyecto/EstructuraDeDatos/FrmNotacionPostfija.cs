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
    public partial class FrmNotacionPostfija : Form
    {
        int indice = 0;
        string[] elementos;
        Stack<float> pila = new Stack<float>();

        public FrmNotacionPostfija()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1 10 -3 - + 1 2 3 * * /";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "52 2 + -  80 8 * * - 1.25 -13 * 12 4 -";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4 4 2 + * 1 + 1 /";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            richTxtImpresion.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }
        public void imprimirExpresion()
        {
            string salida = "";
            foreach (var item in pila.Reverse())
            {
                salida += item + " ";
            }
            for (int i = indice +1; i < elementos.Length; i++)
            {
                salida += elementos[i] + " ";
            }
            richTxtImpresion.AppendText(salida + "\n");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            elementos = textBox1.Text.Split(' ');
            richTxtImpresion.Clear();
            richTxtImpresion.AppendText(textBox1.Text + "\n");
            indice = 0;
            pila.Clear();
            try
            {
                foreach (var item in elementos)
                {
                    //MessageBox.Show(item);
                    switch (item)
                    {
                        case "*":
                            float operando9 = pila.Pop();
                            float operando10 = pila.Pop();
                            MessageBox.Show("Es Multiplicación");
                            pila.Push(operando9 * operando10);
                            imprimirExpresion();
                            break;
                        case "-":
                            float operando1 = pila.Pop();
                            float operando2 = pila.Pop();
                            MessageBox.Show("Es Resta");
                            pila.Push(operando2 - operando1);
                            imprimirExpresion();
                            break;
                        case "/":
                            float operando3 = pila.Pop();
                            float operando4 = pila.Pop();
                            MessageBox.Show("Es División");
                            pila.Push(operando4 / operando3);
                            imprimirExpresion();
                            break;
                        case "+":
                            float operando5 = pila.Pop();
                            float operando6 = pila.Pop();
                            MessageBox.Show("Es Suma");
                            pila.Push(operando5 + operando6);
                            imprimirExpresion();
                            break;
                        case "%":
                            float operando7 = pila.Pop();
                            float operando8 = pila.Pop();
                            MessageBox.Show("Es Mod");
                            pila.Push(operando7 % operando8);
                            imprimirExpresion();
                            break;
                        default:
                            MessageBox.Show("Es OPERANDO" + "" + item);
                            pila.Push(float.Parse((item)));
                            break;
                    }
                    imprimir();
                    indice++;
                }//fin foreach

            }//fin try
            catch (Exception)
            {
                MessageBox.Show("Error en tu expresión", "Error");
            }
         
            if (pila.Count==1)
            {
                lblRes.Text = "Resultado = " + pila.Peek();
            }
            else
            {
                lblRes.Text = "Error en la expresión ";
            }
        }
        private void imprimir()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in pila)
            {
                dataGridView1.Rows.Add(item.ToString());
            }
         
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNotacionPostfija_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            elementos = textBox1.Text.Split(' ');
            richTxtImpresion.Clear();
            richTxtImpresion.AppendText(textBox1.Text + "\n");
            indice = 0;
            pila.Clear();
            try
            {
                foreach (var item in elementos)
                {
                    //MessageBox.Show(item);
                    switch (item)
                    {
                        case "*":
                            float operando9 = pila.Pop();
                            float operando10 = pila.Pop();
                           // MessageBox.Show("Es Multiplicación");
                            pila.Push(operando9 * operando10);
                            imprimirExpresion();
                            break;
                        case "-":
                            float operando1 = pila.Pop();
                            float operando2 = pila.Pop();
                           // MessageBox.Show("Es Resta");
                            pila.Push(operando2 - operando1);
                            imprimirExpresion();
                            break;
                        case "/":
                            float operando3 = pila.Pop();
                            float operando4 = pila.Pop();
                           // MessageBox.Show("Es División");
                            pila.Push(operando4 / operando3);
                            imprimirExpresion();
                            break;
                        case "+":
                            float operando5 = pila.Pop();
                            float operando6 = pila.Pop();
                           // MessageBox.Show("Es Suma");
                            pila.Push(operando5 + operando6);
                            imprimirExpresion();
                            break;
                        case "%":
                            float operando7 = pila.Pop();
                            float operando8 = pila.Pop();
                           // MessageBox.Show("Es Mod");
                            pila.Push(operando7 % operando8);
                            imprimirExpresion();
                            break;
                        default:
                           // MessageBox.Show("Es OPERANDO" + "" + item);
                            pila.Push(float.Parse((item)));
                            break;
                    }
                    imprimir();
                    indice++;
                }//fin foreach

            }//fin try
            catch (Exception)
            {
                MessageBox.Show("Error en tu expresión", "Error");
            }

            if (pila.Count == 1)
            {
                lblRes.Text = "Resultado = " + pila.Peek();
            }
            else
            {
                lblRes.Text = "Error en la expresión ";
            }
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInfoNotPost frmInfoNot = new FrmInfoNotPost();
            frmInfoNot.ShowDialog();
        }
    }
}
