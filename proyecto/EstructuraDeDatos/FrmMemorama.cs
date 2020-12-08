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
  
    public partial class FrmMemorama : Form
    {
        PictureBox imagenTemporal;
        int posicionTemporal, intentos, pares, segundos, minutos = 0;
        int restantes = 8;
        bool esperando = true;
        
        string ruta = @"C:\Users\Administrador\source\repos\EstructuraDeDatos\proyecto\EstructuraDeDatos\img\";

        string[] posiciones = {"1.jpg", "1.jpg" , "2.jpg" , "2.jpg" ,
                               "3.jpg" , "3.jpg" , "4.jpg" , "4.jpg","5.jpg",
                               "5.jpg","6.jpg","6.jpg","7.jpg","7.jpg",
                               "8.jpg","8.jpg"
        };

        public void voltear(PictureBox img, int posicion)
        {

            try
            {
                timer1.Enabled = true;

                img.BackgroundImage = Image.FromFile(ruta + posiciones[posicion]);
                img.Update();
                if (esperando)
                {
                    imagenTemporal = img;
                    posicionTemporal = posicion;
                    img.Enabled = false;
                }
                else
                {
                 intentos0ToolStripMenuItem.Text = "Intentos: " + (++intentos);
                    if (posiciones[posicionTemporal]==posiciones[posicion])
                    {
                        imagenTemporal.Visible = false;
                        img.Visible = false;
                        imagenTemporal.BackgroundImage = null;
                        img.BackgroundImage = null;
                        imagenTemporal.Enabled = false;
                        img.Enabled = false;
                        pares0ToolStripMenuItem.Text = "Pares: " + (++pares);
                        if (pares==8)
                        {
                            timer1.Enabled = false;
                            MessageBox.Show("¡Felicidades has ganado!");
                        }
                        restantes0ToolStripMenuItem.Text = "Restantes: " + (--restantes);
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        img.BackgroundImage = Image.FromFile(ruta + "anverso.jpg");
                        imagenTemporal.BackgroundImage = Image.FromFile(ruta + "anverso.jpg");
                        imagenTemporal.Enabled = true;
                        img.Enabled = true;
                       
                    }
                }
                esperando = !esperando;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }

        }

        public FrmMemorama()
        {
            InitializeComponent();
        }

        private void FrmMemorama_Load(object sender, EventArgs e)
        {
            intentos0ToolStripMenuItem.Text = "Intentos: 0" ; 
            intentos = 0;
            pares0ToolStripMenuItem.Text = "Pares : 0";
            pares = 0;
            timer1.Enabled = false;
            tiempoJugado000ToolStripMenuItem.Text = "Tiempo Restante: 0:00 ";
            Random random = new Random();
            int deck = random.Next(1, 4);
            ruta = @"C:\Users\Administrador\source\repos\EstructuraDeDatos\proyecto\EstructuraDeDatos\img\deck"+deck+@"\";
           
            int fondo = random.Next(1, 11);
            this.BackgroundImage = Image.FromFile(@"C:\Users\Administrador\source\repos\EstructuraDeDatos\proyecto\EstructuraDeDatos\img\backgrounds\" + fondo + ".jpg");
            posiciones = posiciones.OrderBy(s => Guid.NewGuid()).ToArray();
            //MessageBox.Show(string.Join(" ", posiciones));
            foreach (PictureBox item in this.Controls.OfType<PictureBox>())
            {
                item.BackgroundImage = Image.FromFile(ruta + "anverso.jpg");
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.Visible  = true;
                item.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            voltear(pictureBox1, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            voltear(pictureBox4, 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            voltear(pictureBox3, 2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            voltear(pictureBox2, 3);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            voltear(pictureBox8, 4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            voltear(pictureBox5, 5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            voltear(pictureBox6, 6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            voltear(pictureBox7, 7);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            voltear(pictureBox12, 8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            voltear(pictureBox9, 9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            voltear(pictureBox10, 10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            voltear(pictureBox11, 11);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            voltear(pictureBox16, 12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            voltear(pictureBox13, 13);
        }

        private void intentos0ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restantes0ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            voltear(pictureBox14, 14);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos==60)
            {
                minutos++;
                segundos = 0;
            }
            tiempoJugado000ToolStripMenuItem.Text = "Tiempo jugado: "  + minutos + " : " +segundos;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            voltear(pictureBox15, 15);
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMemorama_Load(sender, e);
            
           
        }
    }
}
