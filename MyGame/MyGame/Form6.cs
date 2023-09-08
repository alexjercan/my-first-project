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
    public partial class Form6 : Form
    {
        bool right;
        bool left;
        bool jump;
        int G = 15;
        int Force;
        int s = 0;

        public Form6()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            //


            // block 1
            if (player.Right >= block1.Left && player.Left <= block1.Right - player.Width / 2 && player.Bottom > block1.Top && player.Top < block1.Bottom)
            {
                right = false;
            }

            if (player.Left <= block1.Right && player.Right >= block1.Left + player.Width / 2 && player.Bottom > block1.Top && player.Top < block1.Bottom)
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

            if (player.Left <= block3.Right && player.Right >= block3.Left + player.Width / 2 && player.Bottom > block3.Top && player.Top < block3.Bottom)
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

            // block 5
            if (player.Right >= block5.Left && player.Left <= block5.Right - player.Width / 2 && player.Bottom > block5.Top && player.Top < block5.Bottom)
            {
                right = false;
            }

            if (player.Left <= block5.Right && player.Right >= block5.Left + player.Width / 2 && player.Bottom > block5.Top && player.Top < block5.Bottom)
            {
                left = false;
            }

            //block 6
            if (player.Right >= block6.Left && player.Left <= block6.Right - player.Width / 2 && player.Bottom > block6.Top && player.Top < block6.Bottom)
            {
                right = false;
            }

            if (player.Left <= block6.Right && player.Right >= block6.Left + player.Width / 2 && player.Bottom > block6.Top && player.Top < block6.Bottom)
            {
                left = false;
            }

            //block 7
            if (player.Right >= block7.Left && player.Left <= block7.Right - player.Width / 2 && player.Bottom > block7.Top && player.Top < block7.Bottom)
            {
                right = false;
            }

            if (player.Left <= block7.Right && player.Right >= block7.Left + player.Width / 2 && player.Bottom > block7.Top && player.Top < block7.Bottom)
            {
                left = false;
            }
            //block 8
            if (player.Right >= block8.Left && player.Left <= block8.Right - player.Width / 2 && player.Bottom > block8.Top && player.Top < block8.Bottom)
            {
                right = false;
            }

            if (player.Left <= block8.Right && player.Right >= block8.Left + player.Width / 2 && player.Bottom > block8.Top && player.Top < block8.Bottom)
            {
                left = false;
            }
            //block 9
            if (player.Right >= block9.Left && player.Left <= block9.Right - player.Width / 2 && player.Bottom > block9.Top && player.Top < block9.Bottom)
            {
                right = false;
            }

            if (player.Left <= block9.Right && player.Right >= block9.Left + player.Width / 2 && player.Bottom > block9.Top && player.Top < block9.Bottom)
            {
                left = false;
            }
            //block 10
            if (player.Right >= block10.Left && player.Left <= block10.Right - player.Width / 2 && player.Bottom > block10.Top && player.Top < block10.Bottom)
            {
                right = false;
            }

            if (player.Left <= block10.Right && player.Right >= block10.Left + player.Width / 2 && player.Bottom > block10.Top && player.Top < block10.Bottom)
            {
                left = false;
            }
            //block 11
            if (player.Right >= block11.Left && player.Left <= block11.Right - player.Width / 2 && player.Bottom > block11.Top && player.Top < block11.Bottom)
            {
                right = false;
            }

            if (player.Left <= block11.Right && player.Right >= block11.Left + player.Width / 2 && player.Bottom > block11.Top && player.Top < block11.Bottom)
            {
                left = false;
            }
            //block 12
            if (player.Right >= block12.Left && player.Left <= block12.Right - player.Width / 2 && player.Bottom > block12.Top && player.Top < block12.Bottom)
            {
                right = false;
            }

            if (player.Left <= block12.Right && player.Right >= block12.Left + player.Width / 2 && player.Bottom > block12.Top && player.Top < block12.Bottom)
            {
                left = false;
            }
            //block 13
            if (player.Right >= block13.Left && player.Left <= block13.Right - player.Width / 2 && player.Bottom > block13.Top && player.Top < block13.Bottom)
            {
                right = false;
            }

            if (player.Left <= block13.Right && player.Right >= block13.Left + player.Width / 2 && player.Bottom > block13.Top && player.Top < block13.Bottom)
            {
                left = false;
            }
            //block 14
            if (player.Right >= block14.Left && player.Left <= block14.Right - player.Width / 2 && player.Bottom > block14.Top && player.Top < block14.Bottom)
            {
                right = false;
            }

            if (player.Left <= block14.Right && player.Right >= block14.Left + player.Width / 2 && player.Bottom > block14.Top && player.Top < block14.Bottom)
            {
                left = false;
            }
            //block 15
            if (player.Right >= block15.Left && player.Left <= block15.Right - player.Width / 2 && player.Bottom > block15.Top && player.Top < block15.Bottom)
            {
                right = false;
            }

            if (player.Left <= block15.Right && player.Right >= block15.Left + player.Width / 2 && player.Bottom > block15.Top && player.Top < block15.Bottom)
            {
                left = false;
            }
            //block 16
            if (player.Right >= block16.Left && player.Left <= block16.Right - player.Width / 2 && player.Bottom > block16.Top && player.Top < block16.Bottom)
            {
                right = false;
            }

            if (player.Left <= block16.Right && player.Right >= block16.Left + player.Width / 2 && player.Bottom > block16.Top && player.Top < block16.Bottom)
            {
                left = false;
            }
            //victorie
            if (player.Right >= block17.Left && player.Left <= block17.Right - player.Width / 2 && player.Bottom > block17.Top && player.Top < block17.Bottom && s == 0)
            {
                right = false; s = 1;
                MessageBox.Show("Felicitari! Acum micul negru a ajuns acasa!");
                this.Close();
            }

            if (player.Left <= block17.Right && player.Right >= block17.Left + player.Width / 2 && player.Bottom > block17.Top && player.Top < block17.Bottom && s == 0)
            {
                left = false;s = 1;
                MessageBox.Show("Felicitari! Acum micul negru a ajuns acasa!");
                this.Close();
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
            if (player.Right > block1.Left && player.Left < block1.Right && player.Top + player.Height > block1.Top && player.Top <= block1.Top)
            {
                player.Top = block1.Top - player.Height;
                Force = 0;
                jump = false;
            }
            // block 1
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

            // block 5
            if (player.Right > block5.Left && player.Left < block5.Right && player.Top + player.Height > block5.Top && player.Top <= block5.Top)
            {
                player.Top = block5.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 6
            if (player.Right > block6.Left && player.Left < block6.Right && player.Top + player.Height > block6.Top && player.Top <= block6.Top)
            {
                player.Top = block6.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 7
            if (player.Right > block7.Left && player.Left < block7.Right && player.Top + player.Height > block7.Top && player.Top <= block7.Top)
            {
                player.Top = block7.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 8
            if (player.Right > block8.Left && player.Left < block8.Right && player.Top + player.Height > block8.Top && player.Top <= block8.Top)
            {
                player.Top = block8.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 9
            if (player.Right > block9.Left && player.Left < block9.Right && player.Top + player.Height > block9.Top && player.Top <= block9.Top)
            {
                player.Top = block9.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 10
            if (player.Right > block10.Left && player.Left < block10.Right && player.Top + player.Height > block10.Top && player.Top <= block10.Top)
            {
                player.Top = block10.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 11
            if (player.Right > block11.Left && player.Left < block11.Right && player.Top + player.Height > block11.Top && player.Top <= block11.Top)
            {
                player.Top = block11.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 12
            if (player.Right > block12.Left && player.Left < block12.Right && player.Top + player.Height > block12.Top && player.Top <= block12.Top)
            {
                player.Top = block12.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 13
            if (player.Right > block13.Left && player.Left < block13.Right && player.Top + player.Height > block13.Top && player.Top <= block13.Top)
            {
                player.Top = block13.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 14
            if (player.Right > block14.Left && player.Left < block14.Right && player.Top + player.Height > block14.Top && player.Top <= block14.Top)
            {
                player.Top = block14.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 15
            if (player.Right > block15.Left && player.Left < block15.Right && player.Top + player.Height > block15.Top && player.Top <= block15.Top)
            {
                player.Top = block15.Top - player.Height;
                Force = 0;
                jump = false;
            }

            // block 16
            if (player.Right > block16.Left && player.Left < block16.Right && player.Top + player.Height > block16.Top && player.Top <= block16.Top)
            {
                player.Top = block16.Top - player.Height;
                Force = 0;
                jump = false;
            }

            //

            if (player.Right > lava1.Left && player.Left < lava1.Right && player.Top + player.Height > lava1.Top && player.Top <= lava1.Top)
            {
                player.Left = screen.Right - player.Width;
                player.Top = block2.Top - player.Height;
                Force = 0;
                jump = false;
                left = false;
                right = false;
                MessageBox.Show("Ai fost prajit!");

            }
            if (player.Right > lava2.Left && player.Left < lava2.Right && player.Top + player.Height > lava2.Top && player.Top <= lava2.Top)
            {
                player.Left = screen.Right - player.Width;
                player.Top = block2.Top - player.Height;
                Force = 0;
                jump = false;
                left = false;
                right = false;
                MessageBox.Show("Ai fost prajit!");
            }
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = G;
                }

            }
        }

        private void Form6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }
    }
}
