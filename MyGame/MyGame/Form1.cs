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
    public partial class Form1 : Form
    {
        bool jump;
        int Force = 10, Force1 = 10, Force2 = 10;

        public Form1()
        {
            InitializeComponent();
            player1.Visible = false;
            player2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (jump == true)
            {
                player.Top -= Force;
                Force -= 1;
            }
            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height;
                jump = true;
                Force = 10;
            }
            if (jump == true)
            {
                player1.Top -= Force1;
                Force1 -= 1;
            }
            if (player1.Top + player1.Height >= screen.Height)
            {
                player1.Top = screen.Height - player1.Height;
                jump = true;
                Force1 = 10;
            }
            if (jump == true)
            {
                player2.Top -= Force2;
                Force2 -= 1;
            }
            if (player2.Top + player2.Height >= screen.Height)
            {
                player2.Top = screen.Height - player2.Height;
                jump = true;
                Force2 = 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            player.Visible = false;
            player2.Visible = false;
            player1.Visible = true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            player.Visible = true;
            player2.Visible = false;
            player1.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            player.Visible = false;
            player2.Visible = true;
            player1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Level Level = new Level();
            Level.Show();
        }

        private void player_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void player1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void player2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}