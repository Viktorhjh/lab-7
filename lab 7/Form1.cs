using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7
{
    public partial class Form1 : Form
    {
        bool prezenty = false, bombki = false, gwiazda = false, 
            swiatelka = false, lancychy = false, melodia = false;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            clear();
            Graphics g = panel1.CreateGraphics();
            int x, y, prezentSize = 40;
            if (lancychy)
            {
                /*g.DrawLine(Pens.Red, 130, 150, 300, 200);
                g.DrawLine(Pens.Red, 300, 200, 130, 230);
                g.DrawLine(Pens.Red, 300, 200, 130, 230);
                g.DrawLine(Pens.Red, 130, 230, 320, 300);
                g.DrawLine(Pens.Red, 320, 300, 105, 340);
                g.DrawLine(Pens.Red, 105, 340, 340, 400);*/
                int i, j;
                for (i = -5, j = -5; i < 150; i += 3, j++)
                {
                    g.FillRectangle(Brushes.Red, 140 + i, 150 + j, 2, 5);
                }

                for (i = -10, j = 1; i < 170; i += 3, j++)
                {
                    g.FillRectangle(Brushes.Red, 140 + i, 230 + j, 2, 6);
                }

                for (i = 10, j = -15; i < 220; i += 3, j++)
                {
                    g.FillRectangle(Brushes.Red, 105 + i, 340 + j, 2, 7);
                }
            }           

            if (bombki)
            {
                
                for(int i = 0; i < random.Next(10,25); i++)
                {
                    SolidBrush myBr = new SolidBrush(Color.FromArgb(255,
                    random.Next(150, 255), random.Next(150, 255), random.Next(150, 255)));
                    g.FillEllipse(myBr, random.Next(100, 300), random.Next(50, 400), 20, 20);
                }                
            }

            int alfa = 255, cur;
            if (swiatelka)
            {
                SolidBrush myBr = new SolidBrush(Color.FromArgb(alfa, 255,255,0));      
                for(int i = 0; i < 500; i++)
                {
                    g.FillEllipse(myBr, random.Next(100,300), random.Next(50,400), 5, 5);
                }                               
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"D:\ProGra2ming\C sharp\lab 7\lab 7\kol.wav";
            if (melodia)
            {                
                player.Play();
            }
            else
            {
                player.Stop();   
            }
            deleteOutOfBounds();
            if (gwiazda)
            {
                x = 175; y = 20;
                Point points1 = new Point(x + 25, y);
                Point points2 = new Point(x + 32, y + 20);
                Point points3 = new Point(x + 50, y + 20);
                Point points4 = new Point(x + 38, y + 30);
                Point points5 = new Point(x + 42, y + 50);
                Point points6 = new Point(x + 25, y + 40);
                Point points7 = new Point(x + 9, y + 50);
                Point points8 = new Point(x + 15, y + 30);
                Point points9 = new Point(x, y + 20);
                Point points10 = new Point(x + 20, y + 20);
                Point[] gw = {points1, points2, points3, points4, points5,
                    points6, points7, points8, points9, points10};
                g.FillPolygon(Brushes.Yellow, gw);
                g.DrawPolygon(Pens.Black, gw);
            }
            if (prezenty)
            {
                x = 245;
                y = 410;
                g.FillRectangle(Brushes.Red, x, y, prezentSize, prezentSize);
                g.FillRectangle(Brushes.Green, x, y + 10, prezentSize, 10);
                g.FillRectangle(Brushes.Green, x + 10, y, 10, prezentSize);

                x = 290;
                y = 410;
                prezentSize += 10;
                g.FillRectangle(Brushes.Aqua, x, y - 20, prezentSize, prezentSize + 10);
                g.FillRectangle(Brushes.Yellow, x, y, prezentSize, 10);
                g.FillRectangle(Brushes.Yellow, x + 20, y - 20, 10, prezentSize + 10);
            }
        }

        public void deleteOutOfBounds()
        {
            Graphics g = panel1.CreateGraphics();
            Point points1 = new Point(200, 50);
            Point points2 = new Point(100, 200);          
            Point points3 = new Point(0, 0);
            Point[] triangle1 = { points1, points2, points3};
            g.FillPolygon(Brushes.White, triangle1);

            Point points4 = new Point(100,200);
            Point points5 = new Point(150, 200);
            Point points6 = new Point(80, 300);
            Point points01 = new Point(0, 0);
            Point points02 = new Point(0, 300);
            Point[] triangle2 = { points4, points5, points6, points02, points01 };
            g.FillPolygon(Brushes.White, triangle2);

            Point points7 = new Point(0, 300);
            Point points8 = new Point(135, 300);
            Point points9 = new Point(60, 400);
            Point[] triangle3 = { points7, points8, points9 };
            g.FillPolygon(Brushes.White, triangle3);

            Point points10 = new Point(200, 50);
            Point points11 = new Point(500, 0);
            Point points12 = new Point(300, 200);
            Point[] triangle4 = { points10, points11, points12 };
            g.FillPolygon(Brushes.White, triangle4);

            Point points13 = new Point(200, 50);
            Point points14 = new Point(500, 0);
            Point points15 = new Point(300, 200);
            Point[] triangle5 = { points13, points14, points15 };
            g.FillPolygon(Brushes.White, triangle5);

            Point points04 = new Point(300, 200);
            Point points05 = new Point(250, 200);                    
            Point points07 = new Point(320, 300);
            Point points008 = new Point(500, 300);
            Point[] triangle02 = { points04, points05, points07, points008};
            g.FillPolygon(Brushes.White, triangle02);
            
            Point points007 = new Point(265, 300);
            Point points08 = new Point(340, 300);
            Point points09 = new Point(340, 400);
            Point[] triangle03 = { points007, points08, points09 };
            g.FillPolygon(Brushes.White, triangle03);
        }

        public void clear()
        {
            Graphics g = panel1.CreateGraphics();
            g.FillRectangle(Brushes.White, 0, 0, 550, 550);
            Point points1 = new Point(200, 50);
            Point points2 = new Point(100, 200);
            Point points3 = new Point(300, 200);
            Point[] triangle1 = { points1, points2, points3 };
            g.FillPolygon(Brushes.Green, triangle1);
            points1.Y += 80;
            points2.Y += 100;
            points3.Y += 100;
            points2.X -= 20;
            points3.X += 20;
            Point[] triangle2 = { points1, points2, points3 };
            g.FillPolygon(Brushes.Green, triangle2);
            points1.Y += 80;
            points2.Y += 100;
            points3.Y += 100;
            points2.X -= 20;
            points3.X += 20;
            Point[] triangle3 = { points1, points2, points3 };
            g.FillPolygon(Brushes.Green, triangle3);

            g.FillRectangle(Brushes.Brown, 175, 400, 50, 50);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            prezenty = !prezenty;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            gwiazda = !gwiazda;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            bombki = !bombki;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            lancychy = !lancychy;            
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            swiatelka = !swiatelka;
        }        
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            melodia = !melodia;
        }
    }

}
/*
...wiszące na drzewku, a nie w powietrzu (wymaga losowej pozycji),
światełka...
...które migają,
łańcuchy,
melodię kolędy,
rysunek nie znika.*/