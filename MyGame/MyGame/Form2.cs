using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        bool right;
        bool left;
        bool jump;
        int G = 15;
        int Force;
        int sw = 0;
        int s = 0;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true;}
            if (e.KeyCode == Keys.Left) { left = true;}
            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = G;
                }

            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // block 1
            if (player.Right >= block.Left && player.Left <= block.Right - player.Width / 2 && player.Bottom > block.Top && player.Top < block.Bottom)
            {
                right = false;
            }

            if (player.Left <= block.Right && player.Right >= block.Left + player.Width / 2 && player.Bottom > block.Top && player.Top < block.Bottom)
            {
                left = false;
            }

            //block 2
            if (player.Right >= block2.Left && player.Left <= block2.Right - player.Width / 2 && player.Bottom > block2.Top && player.Top < block2.Bottom)
            {
                right = false;
            }

            if (player.Left <= block2.Right && player.Right >= block2.Left + player.Width / 2 && player.Bottom > block2.Top && player.Top < block2.Bottom)
            {
                left = false;
            }

            // block 3
            if (player.Right >= block3.Left && player.Left <= block3.Right - player.Width / 2 && player.Bottom > block3.Top && player.Top < block3.Bottom)
            {
                right = false;
            }

            if (player.Left <= block.Right && player.Right >= block3.Left + player.Width / 2 && player.Bottom > block3.Top && player.Top < block3.Bottom)
            {
                left = false;
            }

            // block 4
            if (player.Right >= block4.Left && player.Left <= block4.Right - player.Width / 2 && player.Bottom > block4.Top && player.Top < block4.Bottom)
            {
                right = false;
            }

            if (player.Left <= block4.Right && player.Right >= block4.Left + player.Width / 2 && player.Bottom > block4.Top && player.Top < block4.Bottom)
            {
                left = false;
            }

            //
            
            if (player.Right >= screen.Width)
            {
                player.Left = screen.Right - player.Width;
                right = false;
            }
            if (player.Left <= 0)
            {
                player.Left = screen.Left;
                left = false;
            }

            if (right == true) { player.Left += 5; }
            if (left == true) { player.Left -= 5; }
            if (jump == true)
            {
                player.Top -= Force;
                Force -= 1;
            }
            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height;
                jump = false;
            }
            else
            {
                player.Top += 5;
            }

            //


            // block 1
            if (player.Right > block.Left && player.Left < block.Right && player.Top + player.Height > block.Top && player.Top <= block.Top)
            {
                player.Top = block.Top - player.Height;
                Force = 0;
                jump = false;
            }
            // block 2
            if (player.Right > block2.Left && player.Left < block2.Right && player.Top + player.Height > block2.Top && player.Top <= block2.Top)
            {
                player.Top = block2.Top - player.Height;
                Force = 0;
                jump = false;
            }
            // block 3
            if (player.Right > block3.Left && player.Left < block3.Right && player.Top + player.Height > block3.Top && player.Top <= block3.Top)
            {
                player.Top = block3.Top - player.Height;
                Force = 0;
                jump = false;
            }
            // block 4
            if (player.Right > block4.Left && player.Left < block4.Right && player.Top + player.Height > block4.Top && player.Top <= block4.Top)
            {
                player.Top = block4.Top - player.Height;
                Force = 0;
                jump = false;
            }
            //victory
            if (player.Right >= block5.Left && player.Left <= block5.Right - player.Width / 2 && player.Bottom > block.Top && player.Top < block5.Bottom)
            {
                right = false;
            }
            if (player.Left <= block5.Right && player.Right >= block5.Left + player.Width / 2 && player.Bottom > block5.Top && player.Top < block5.Bottom && sw == 0)
            {
                left = false;
                Form3 form3 = new Form3();
                form3.Show();
                this.Close();
            }
        }


    }
}