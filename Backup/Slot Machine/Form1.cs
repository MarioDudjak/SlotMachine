using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace Slot_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int m;
        int a;
        int b;
        int c;
		
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

      
   

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m = m + 10;
            if (m < 1000)
            {

                a = (int)(Conversion.Int(1 + VBMath.Rnd() * 3));

                b = (int)(Conversion.Int(1 + VBMath.Rnd() * 3));

                c = (int)(Conversion.Int(1 + VBMath.Rnd() * 3));

                switch (a)
                {
                    case 1:
                        PictureBox1.Image = Image.FromFile("C:\\Users\\don\\Desktop\\bg.o sa vb.net\\Slot Machine\\Slot Machine\\Resources\\apple.jpg");
                        break;
                    case 2:
                        PictureBox1.Image = Image.FromFile("C:\\Users\\don\\Desktop\\bg.o sa vb.net\\Slot Machine\\Slot Machine\\Resources\\grapes.jpg");
                        break;
                    case 3:
                        PictureBox1.Image = Image.FromFile("C:\\Users\\don\\Desktop\\bg.o sa vb.net\\Slot Machine\\Slot Machine\\Resources\\strawberry.jpg");
                        break;

                }

                switch (b)
                {
                    case 1:
                        PictureBox2.Image = Image.FromFile("C:\\Users\\don\\Desktop\\bg.o sa vb.net\\Slot Machine\\Slot Machine\\Resources\\apple.jpg");
                        break;
                    case 2:
                        PictureBox2.Image = Image.FromFile("C:\\Users\\don\\Desktop\\bg.o sa vb.net\\Slot Machine\\Slot Machine\\Resources\\grapes.jpg");
                        break;
                    case 3:
                        PictureBox2.Image = Image.FromFile("C:\\Users\\don\\Desktop\\bg.o sa vb.net\\Slot Machine\\Slot Machine\\Resources\\strawberry.jpg");
                        break;

                }
                switch (c)
                {
                    case 1:
                        PictureBox3.Image = Image.FromFile("C:\\Users\\don\\Desktop\\bg.o sa vb.net\\Slot Machine\\Slot Machine\\Resources\\apple.jpg");
                        break;
                    case 2:
                        PictureBox3.Image = Image.FromFile("C:\\Users\\don\\Desktop\\bg.o sa vb.net\\Slot Machine\\Slot Machine\\Resources\\grapes.jpg");
                        break;
                    case 3:
                        PictureBox3.Image = Image.FromFile("C:\\Users\\don\\Desktop\\bg.o sa vb.net\\Slot Machine\\Slot Machine\\Resources\\strawberry.jpg");
                        break;

                }

            }
            else
            {
                timer1.Enabled = false;
                m = 0;
                if (System.Convert.ToInt32(a == b) == c)
                {
                    lblMsg.Text = "Jackpot! You won P1,000,000″";
                }
                else
                {
                    lblMsg.Text = "No luck, try again";

                }
            }
		
        }
    }
}