using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FondoControl
{
    public partial class UserControl1: UserControl
    {
        Graphics g;
        
        bool imagen1 = false;
        bool imagen2 = false;
        int x = -1;
        int y = -1;
        bool moving=false;
        Pen pen;
        Pen texturedPen;
        Brush TextureBrush;
        Bitmap bitmap;
        HatchBrush HatchBrus;
        
        public UserControl1()
        {
            InitializeComponent();
            //pinceles graficos
            g = panel1.CreateGraphics();
           // g = pictureBox12.CreateGraphics();
            //pinceles
            pen = new Pen(Color.Black, 5);
            
            
            
            //HatchBrus = new HatchBrush(HatchStyle.Weave, Color.DarkBlue, Color.Cyan);
            //bitmap = new Bitmap("re1.png");
            //TextureBrush tBrush = new TextureBrush(bitmap);
            //tBrush.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            //texturedPen = new Pen(tBrush, 30);
            
            //pen2 = new Pen(HatchBrus, 30);
        }
        //panel crayon amarillo
        private void amarillofondo(object sender, EventArgs e)
        {
           
            pen.Color = System.Drawing.Color.Yellow;
            imagen1 = false;
            imagen2 = false;

        }
        //panel crayon rojo
        private void rojofondo(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Red;
            imagen1 = false;
            imagen2 = false;
        }
        //panel crayon azul
        private void azulfondo(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.DarkBlue;
            imagen1 = false;
            imagen2 = false;
        }
        //panel crayon verde
        private void verdefondo(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Green;
            imagen1 = false;
            imagen2 = false;
        }
        //panel crayon naranja
        private void naranjafondo(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Orange;
            imagen1 = false;
            imagen2 = false;
        }

        //panel crayon negro
        private void negrofondo(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Black;
            imagen1 = false;
            imagen2 = false;

        }

        //panel crayon cafe
        private void cafefondo(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Brown;
            imagen1 = false;
            imagen2 = false;
        }
        //panel crayon rosa
        private void rosafondo(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.Purple;
            imagen1 = false;
            imagen2 = false;

        }
        //panel principal pintar abajo
        private void panel_down(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }
        //panel principal pintar en movimiento
        private void panel_move(object sender, MouseEventArgs e)
        {
            if (moving && x!=-1 && y!=-1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);

                if (imagen1==true)
                {
                    var picture = new PictureBox
                    {
                        Name = "re1",
                        Size = new Size(100, 100),
                        Location = new Point(x, y),
                        Image = FondoControl.Properties.Resources.re1,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    panel1.Controls.Add(picture);
                    picture.BringToFront();
                    picture.BackColor = System.Drawing.Color.Transparent;
                }
                else
                {
                    imagen1 = false;
                   
                }
                if (imagen2 == true)
                {
                    var picture2 = new PictureBox
                    {
                        Name = "zero_removebg_preview",
                        Size = new Size(110, 110),
                        Location = new Point(x, y),
                        Image =FondoControl.Properties.Resources.zero_removebg_preview,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    panel1.Controls.Add(picture2);
                    picture2.BringToFront();
                    picture2.BackColor = System.Drawing.Color.Transparent;
                }
                else
                {
                  
                    imagen2 = false;
                }


                //g.DrawLine(pen2, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }
       
        //panel principal pintar arriba
        private void panel_up(object sender, MouseEventArgs e)
        {
            moving = true;
            x = -1;
            y = -1;
        }
        //borrador boton
        private void borrador(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.White;
            imagen1 = false;
            imagen2 = false;
        }
        //borrador tamanio del pen
        private void sizepen(object sender, EventArgs e)
        {  
            pen.Width = trackBar1.Value;
            //pen2.Width = trackBar1.Value;
        }

       
        // panel pintar metodo
        private void pintar(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            //e.Graphics.DrawEllipse(texturedPen, 100, 20, 200, 100);
        }

        //fondo color
        private void colorfondo(object sender, EventArgs e)
        {
            ColorDialog cd2 = new ColorDialog();
            Color new_color2;
            cd2.ShowDialog();
            new_color2 = cd2.Color;
            panel1.BackColor = cd2.Color;
            panel1.BackgroundImage = null;
            imagen1 = false;
            imagen2 = false;
        }
        //limpiar panel principal
        private void limpiarpanel(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.Red;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Clear();
            panel1.BackgroundImage = null;

        }
     
       
        //mostrar imagen 1 para pintar
        private void imagen1mostrar(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\migue\OneDrive\Escritorio\png\rei2.jpg");
            panel1.BackgroundImage = myimage;
            panel2.Visible = false;
             

        }

        //pintar
        private void colorlapiz(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            Color new_color;
            cd.ShowDialog();
            new_color = cd.Color;
            pictureBox10.BackColor = cd.Color;
            pen.Color = cd.Color;
            imagen1 = false;

        }

        private void imagenb2(object sender, EventArgs e)
        {
            Image myimage2 = new Bitmap(@"C:\Users\migue\OneDrive\Escritorio\png\among.jpg");
            panel1.BackgroundImage = myimage2;
            panel2.Visible = false;
        }

        private void imagenb3(object sender, EventArgs e)
        {
            Image myimage3 = new Bitmap(@"C:\Users\migue\OneDrive\Escritorio\png\imagen2.jpg");
            panel1.BackgroundImage = myimage3;
            panel2.Visible = false;
        }

        private void imagenb4(object sender, EventArgs e)
        {
            Image myimage4 = new Bitmap(@"C:\Users\migue\OneDrive\Escritorio\png\imagen3.jpg");
            panel1.BackgroundImage = myimage4;
            panel2.Visible = false;
        }

        private void imagenb5(object sender, EventArgs e)
        {
            Image myimage5 = new Bitmap(@"C:\Users\migue\OneDrive\Escritorio\png\imagen4.jpg");
            panel1.BackgroundImage = myimage5;
            panel2.Visible = false;
        }

        private void mostrarpanel2(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void stiker1(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.White;
            imagen1 = true;
            imagen2 = false;
        }

        private void stiker2(object sender, EventArgs e)
        {
            pen.Color = System.Drawing.Color.White;
            imagen2 = true;
        }

       
    }
}
