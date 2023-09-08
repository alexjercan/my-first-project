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
    public partial class Form5 : Form
    {

        bool right;
        bool left;
        bool jump;
        int G = 15;
        int Force;
        int sw = 0;
        int s = 0;
        int q = 0;

        public Form5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //ban1
            if (player.Right >= Ban1.Left && player.Left <= Ban1.Right - player.Width / 2 && player.Bottom > Ban1.Top && player.Top < Ban1.Bottom && s==0)
            {
                s=1;
                Ban1.Hide();
            }

            if (player.Left <= Ban1.Right && player.Right >= Ban1.Left + player.Width / 2 && player.Bottom > Ban1.Top && player.Top < Ban1.Bottom && s==0)
            {
                s=1;
                Ban1.Hide();
            }
            //


            //ban2
            if (player.Right >= Ban2.Left && player.Left <= Ban2.Right - player.Width / 2 && player.Bottom > Ban2.Top && player.Top < Ban2.Bottom && q==0)
            {
                q=1;
                Ban2.Hide();                
            }
            if (player.Left <= Ban2.Right && player.Right >= Ban2.Left + player.Width / 2 && player.Bottom > Ban2.Top && player.Top < Ban2.Bottom && q==0 )
            {
                q=1;
                Ban2.Hide();
            }
            //


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
            // lava
            if (player.Right > lava.Left && player.Left < lava.Right && player.Top + player.Height > lava.Top && player.Top <= lava.Top)
            {
                player.Left = screen.Right - player.Width;
                player.Top = block2.Top - player.Height;
                Force = 0;
                jump = false;
                left = false;
                right = false;
                MessageBox.Show("Ai fost prajit!");
                s = 0; q = 0;
                Ban1.Show();
                Ban2.Show();

            }
            //victory
            if (player.Right >= block5.Left && player.Left <= block5.Right - player.Width / 2 && player.Bottom > block.Top && player.Top < block5.Bottom)
            {
                right = false;
                if (s == 1 && q==1)
                    MessageBox.Show("Felicitari! Acum micul negru a ajuns acasa cu doi banuti!");
                if ((s==1&&q==0)||(s==0&&q==1))
                    MessageBox.Show("Felicitari! Acum micul negru a ajuns acasa cu un banut!");
                if (s == 0 && q == 0)
                    MessageBox.Show("Felicitari! Acum micul negru a ajuns acasa!");
                MessageBox.Show("Felicitari! Acum micul negru a descoperit un nivel secret. Apasa pe peronajul din meniul principal ca sa-l joci!");
            }
            if (player.Left <= block5.Right && player.Right >= block5.Left + player.Width / 2 && player.Bottom > block5.Top && player.Top < block5.Bottom && sw == 0)
            {
                left = false;
                this.Close();
                if (s == 1 && q == 1)
                    MessageBox.Show("Felicitari! Acum micul negru a ajuns acasa cu doi banuti!");
                if ((s == 1 && q == 0) || (s == 0 && q == 1))
                    MessageBox.Show("Felicitari! Acum micul negru a ajuns acasa cu un banut!");
                if (s == 0 && q == 0)
                    MessageBox.Show("Felicitari! Acum micul negru a ajuns acasa!");
                MessageBox.Show("Felicitari! Acum micul negru a descoperit un nivel secret. Apasa pe peronajul din meniul principal ca sa-l joci!");
            }

        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
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

        private void Form5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }
    }
}
