using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace pipe_randomizate
{
    public partial class Form1 : Form
    {
        List<int> pipe1= new List<int>();
        List<int> pipe2 = new List<int>();
        List<int> pipe3 = new List<int>();
        List<int> pipe4 = new List<int>();
        int pipeh = 50;
        int pipew = 400;
        int pipedist = 150;
        bool resetpipes = true, Start = false;
        int OriginalX, OriginalY;
        int G = 5;
        bool right = false, left = false;
        Stopwatch stopWatch;
        long duration , highHighScore;



        public Form1()
        {
            InitializeComponent();
            OriginalX = player.Location.X;
            OriginalY = player.Location.Y;
            tepi.Visible = false;
            player.Visible = false;
            if (!File.Exists("HighScore.ini"))
            {
                File.Create("HighScore.ini").Dispose();
            }
        }

        private void ShowHighScore()
        {
            using (StreamReader reader = new StreamReader("HighScore.ini"))
            {
                highHighScore = int.Parse(reader.ReadToEnd());
                reader.Close();
                if (duration > highHighScore)
                {
                    MessageBox.Show(string.Format("Felicitari, ai facut un nou high HighScore! Noul scor este de {0}.", duration), "Falling Bocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (StreamWriter writer = new StreamWriter("HighScore.ini"))
                    {
                        writer.Write(duration);
                        writer.Close();
                    }
                }
                if (duration <= highHighScore)
                {
                    MessageBox.Show(string.Format("Ai facut {0}. Mai iti trebuiau {1} puncte ca sa depasesti highHighScore-ul de {2}", duration , highHighScore - duration , highHighScore), "Falling Bocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                duration = 0;

            }
        }

        private void Die()
        {
            if ((player.Location.Y + player.Height > this.ClientSize.Height | player.Top < tepi.Bottom) && Start == true)
            {
                timer2.Enabled = false;
                timer3.Enabled = false;
                Start = false;
                resetpipes = true;
                stopWatch.Stop();
                duration = stopWatch.ElapsedMilliseconds;
                ShowHighScore();
                player.Location = new Point(OriginalX, OriginalY);
                tepi.Visible = false;
                player.Visible = false;
                button1.Visible = true;
                right = false;
                left = false;
            }
        }

        private void StartGame()
        {
            //ptr a calcula scorul;
            duration = 0;
            //aprinde timer2 ptr a recrea tevile care ies din ecran
            timer2.Enabled = true;
            //aprinde timer3 ptr a se misca player
            timer3.Enabled = true;
            //devine fals doar cand jocul e pornit ptr a nu aparea pe ecran tevi
            resetpipes = false;
            Start = true;

            //se creaza prima teava
            Random random = new Random();
            int nr = random.Next(0, this.Width - 300);
            int num = pipedist;
            pipe1.Clear();
            pipe1.Add(nr);
            pipe1.Add(num);
            pipe1.Add(this.Height);


            //a doua teava
            nr = random.Next(0, this.Width - 300);
            num = pipedist*2;
            pipe2.Clear();
            pipe2.Add(nr);
            pipe2.Add(num);
            pipe2.Add(this.Height);

            // a treia teava
            nr = random.Next(0, this.Width - 300);
            num = pipedist * 3;
            pipe3.Clear();
            pipe3.Add(nr);
            pipe3.Add(num);
            pipe3.Add(this.Height);

            // a patra teava
            nr = random.Next(0, this.Width - 300);
            num = pipedist * 4;
            pipe4.Clear();
            pipe4.Add(nr);
            pipe4.Add(num);
            pipe4.Add(this.Height);

            Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
            button1.Visible = false;
            tepi.Visible = true;
            player.Visible = true;
            stopWatch = new Stopwatch();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (resetpipes == false)
            {
                //se deseneaza prima teava
                e.Graphics.FillRectangle(Brushes.Silver, new Rectangle( pipe1[0] , pipe1[1] , pipew, pipeh));
                //adoua teava
                e.Graphics.FillRectangle(Brushes.Silver, new Rectangle(pipe2[0], pipe2[1], pipew, pipeh));
                //a treia teava
                e.Graphics.FillRectangle(Brushes.Silver, new Rectangle(pipe3[0], pipe3[1], pipew, pipeh));
                //a patra teava
                e.Graphics.FillRectangle(Brushes.Silver, new Rectangle(pipe4[0], pipe4[1], pipew, pipeh));
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //se refac tevile iesite din ecran
            if (pipe1[1] + pipeh <= 0)
            {
                Random rnd = new Random();
                int nr = rnd.Next(0, this.Width - 300);
                int num = pipedist;
                pipe1.Clear();
                pipe1.Add(nr);
                pipe1.Add(this.Height);
            }
            else
            {
                pipe1[1] -= 2;
            }


            //a doua teava
            if (pipe2[1] + pipeh <= 0)
            {
                Random rnd = new Random();
                int nr = rnd.Next(0, this.Width - 300);
                int num = pipedist;
                pipe2.Clear();
                pipe2.Add(nr);
                pipe2.Add(this.Height);
            }
            else
            {
                pipe2[1] -= 2;
            }

            //a treia teava
            if (pipe3[1] + pipeh <= 0)
            {
                Random rnd = new Random();
                int nr = rnd.Next(0, this.Width - 300);
                int num = pipedist;
                pipe3.Clear();
                pipe3.Add(nr);
                pipe3.Add(this.Height);
            }
            else
            {
                pipe3[1] -= 2;
            }

            //a patra teava
            if (pipe4[1] + pipeh <= 0)
            {
                Random rnd = new Random();
                int nr = rnd.Next(0, this.Width - 300);
                int num = pipedist;
                pipe4.Clear();
                pipe4.Add(nr);
                pipe4.Add(this.Height);
            }
            else
            {
                pipe4[1] -= 2;
            }
        }

        private void Move()
        {
            if (right) player.Left += 5;
            if (left) player.Left -= 5;
        }

        private void Collision()
        {
            Rectangle rec = player.Bounds;
            Rectangle rec1 = new Rectangle(pipe1[0], pipe1[1], pipew, pipeh);
            Rectangle rec2 = new Rectangle(pipe2[0], pipe2[1], pipew, pipeh);
            Rectangle rec3 = new Rectangle(pipe3[0], pipe3[1], pipew, pipeh);
            Rectangle rec4 = new Rectangle(pipe4[0], pipe4[1], pipew, pipeh);
            Rectangle intersect1 = Rectangle.Intersect(rec, rec1);
            Rectangle intersect2 = Rectangle.Intersect(rec, rec2);
            Rectangle intersect3 = Rectangle.Intersect(rec, rec3);
            Rectangle intersect4 = Rectangle.Intersect(rec, rec4);
            if( intersect1 != Rectangle.Empty)
                player.Top = - player.Width + pipe1[1];
            if (intersect2 != Rectangle.Empty)
                player.Top = -player.Width + pipe2[1];
            if (intersect3 != Rectangle.Empty)
                player.Top = -player.Width + pipe3[1];
            if (intersect4 != Rectangle.Empty)
                player.Top = -player.Width + pipe4[1];
            if (player.Right < 0)
                player.Left = this.Width;
            if (player.Left > this.Width)
                player.Left = 0;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            stopWatch.Start();
            player.Top += G;
            Collision();
            Die();
            Move();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = true;
            if (e.KeyCode == Keys.Left)
                left = true;
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = false;
            if (e.KeyCode == Keys.Left)
                left = false;
        }

    }
}
