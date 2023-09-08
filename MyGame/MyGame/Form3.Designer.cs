namespace WindowsFormsApplication2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.block = new System.Windows.Forms.PictureBox();
            this.block5 = new System.Windows.Forms.PictureBox();
            this.lava = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Panel();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.Ban = new System.Windows.Forms.PictureBox();
            this.text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).BeginInit();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ban)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player.Location = new System.Drawing.Point(377, 240);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(25, 25);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.DimGray;
            this.block3.Location = new System.Drawing.Point(177, 170);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(39, 67);
            this.block3.TabIndex = 4;
            this.block3.TabStop = false;
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.DimGray;
            this.block4.Location = new System.Drawing.Point(101, 111);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(39, 154);
            this.block4.TabIndex = 6;
            this.block4.TabStop = false;
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.Color.DimGray;
            this.block.Location = new System.Drawing.Point(0, 170);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(106, 18);
            this.block.TabIndex = 7;
            this.block.TabStop = false;
            // 
            // block5
            // 
            this.block5.BackColor = System.Drawing.Color.DarkRed;
            this.block5.Location = new System.Drawing.Point(16, 27);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(37, 81);
            this.block5.TabIndex = 8;
            this.block5.TabStop = false;
            // 
            // lava
            // 
            this.lava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lava.Location = new System.Drawing.Point(3, 230);
            this.lava.Name = "lava";
            this.lava.Size = new System.Drawing.Size(287, 35);
            this.lava.TabIndex = 10;
            this.lava.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(117, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ai grija la lava!";
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.screen.Controls.Add(this.text);
            this.screen.Controls.Add(this.Ban);
            this.screen.Controls.Add(this.block2);
            this.screen.Controls.Add(this.label1);
            this.screen.Controls.Add(this.lava);
            this.screen.Controls.Add(this.block5);
            this.screen.Controls.Add(this.block);
            this.screen.Controls.Add(this.block4);
            this.screen.Controls.Add(this.block3);
            this.screen.Controls.Add(this.player);
            this.screen.Location = new System.Drawing.Point(-4, -1);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(405, 265);
            this.screen.TabIndex = 0;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.DimGray;
            this.block2.Location = new System.Drawing.Point(248, 202);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(88, 63);
            this.block2.TabIndex = 12;
            this.block2.TabStop = false;
            // 
            // Ban
            // 
            this.Ban.BackColor = System.Drawing.Color.Yellow;
            this.Ban.Location = new System.Drawing.Point(43, 152);
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(10, 12);
            this.Ban.TabIndex = 13;
            this.Ban.TabStop = false;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(28, 136);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(35, 13);
            this.text.TabIndex = 14;
            this.text.Text = "Banut";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 262);
            this.Controls.Add(this.screen);
            this.Name = "Form3";
            this.Text = "Form3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).EndInit();
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.PictureBox block;
        private System.Windows.Forms.PictureBox block5;
        private System.Windows.Forms.PictureBox lava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.PictureBox Ban;
    }
}