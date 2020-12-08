using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class FrmTorresDeHanoi : Form
    {
        //Atributos de clase
       private int contador=0;
       private string origen = "";
       private Stack<PictureBox> pilaPicBox1 = new Stack<PictureBox>();
       private Stack<PictureBox> pilaPicBox2 = new Stack<PictureBox>();
       private Stack<PictureBox> pilaPicBox3 = new Stack<PictureBox>();

        public FrmTorresDeHanoi()
        {
            InitializeComponent();
            foreach (Panel item in this.Controls.OfType<Panel>())
            {
                //Nos imprimira los names de cada panel que tiene la forma
                //MessageBox.Show(item.Name);
                item.AllowDrop = true;
                item.DragEnter += Panel_DragEnter;
                item.DragDrop += Panel_DragDrop;
            }
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            pictureBox4.MouseDown += pictureBox4_MouseDown;
            pictureBox5.MouseDown += pictureBox5_MouseDown;

        }
        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            mover(pictureBox3);
        }
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            mover(pictureBox4);
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            mover(pictureBox5);
        }
        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            ((PictureBox)e.Data.GetData(typeof(PictureBox))).Parent = (Panel)sender;
        }
        private void mover(PictureBox pictureBox)
        {
            origen = pictureBox.Parent.Name.ToString();
           // MessageBox.Show(origen);
            pictureBox.DoDragDrop(pictureBox, DragDropEffects.Move);
            if (!setPosicion(pictureBox, origen))
            {
                switch (origen)
                {
                    case "panel1":
                        pictureBox.Parent = panel1;
                        break;
                    case "panel2":
                        pictureBox.Parent = panel2;
                        break;
                    case "panel3":
                        pictureBox.Parent = panel3;
                        break;
                }
            }
            pictureBox.BringToFront();
        }
        private void FrmTorresDeHanoi_Load(object sender, EventArgs e)
        {
            pictureBox3.Parent = panel1;
            pictureBox4.Parent = panel1;
            pictureBox5.Parent = panel1;

            pictureBox3.BringToFront();
            pictureBox4.BringToFront();
            pictureBox5.BringToFront();

            pilaPicBox1.Clear();
            pilaPicBox2.Clear();
            pilaPicBox3.Clear();

            pilaPicBox1.Push(pictureBox3);
            pilaPicBox1.Push(pictureBox4);
            pilaPicBox1.Push(pictureBox5);
            contador = 0;
            lblMovs.Text = "Movimientos : 0";
        }
        private bool setPosicion(PictureBox pictureBox, string origen)
        {
            //MessageBox.Show(origen +" " +pictureBox.Parent.Name.ToString());
            switch (pictureBox.Parent.Name.ToString())
            {
                case "panel1":
                    if (origen == "panel2") return validador(pilaPicBox2,pilaPicBox1, pictureBox);
                    if (origen == "panel3") return validador(pilaPicBox3, pilaPicBox1, pictureBox);
                    break;
                case "panel2":
                    if (origen == "panel1") return validador(pilaPicBox1, pilaPicBox2, pictureBox);
                    if (origen == "panel3") return validador(pilaPicBox3, pilaPicBox2, pictureBox);
                    break;
                case "panel3":
                    if (origen == "panel1") return validador(pilaPicBox1, pilaPicBox3, pictureBox);
                    if (origen == "panel2") return validador(pilaPicBox2, pilaPicBox3, pictureBox);
                    break;
            }
            return true;
        }

        private bool validador(Stack<PictureBox> origen, Stack<PictureBox> destino, PictureBox pictureBox)
        {
            if (
                (destino.Count==0 && pictureBox.Tag == origen.Peek().Tag)
                ||
                (destino.Count!=0 &&
                int.Parse(destino.Peek().Tag.ToString()) > int.Parse(pictureBox.Tag.ToString())
                && pictureBox.Tag.ToString() == origen.Peek().Tag.ToString())
                
                )
            {
                destino.Push(origen.Pop());
                pictureBox.Top = panel1.Height - pictureBox.Height - destino.Count * pictureBox.Height - 7;

                lblMovs.Text = "Movimientos"+" " + (++contador);
                lblMovs.Update();
                return true;
            }
            else
            {
                return false;

            }


        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            FrmTorresDeHanoi_Load(sender, e);

            Mover(pilaPicBox1, pilaPicBox2, pictureBox5, panel2);
            Mover(pilaPicBox1, pilaPicBox3, pictureBox4, panel3);
            Mover(pilaPicBox2, pilaPicBox3, pictureBox5, panel3);
            Mover(pilaPicBox1, pilaPicBox2, pictureBox3, panel2);
            Mover(pilaPicBox3, pilaPicBox2, pictureBox5, panel2);
            Mover(pilaPicBox3, pilaPicBox1, pictureBox4, panel1);
            Mover(pilaPicBox2, pilaPicBox1, pictureBox5, panel1);
            Mover(pilaPicBox2, pilaPicBox3, pictureBox3, panel3);
            Mover(pilaPicBox1, pilaPicBox2, pictureBox5, panel2);
            Mover(pilaPicBox1, pilaPicBox2, pictureBox4, panel3);
            Mover(pilaPicBox2, pilaPicBox3, pictureBox5, panel3);



        }

        private void Mover(Stack<PictureBox> pila1, Stack<PictureBox> pila2, PictureBox picture, Panel panel)
        {
            validador(pila1, pila2, picture);
            picture.Parent = panel;
            panel1.Update();
            panel2.Update();
            panel3.Update();
            picture.BringToFront();
            picture.Update();
            Thread.Sleep(500);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            FrmTorresDeHanoi_Load(sender, e);
        }
    }
}
