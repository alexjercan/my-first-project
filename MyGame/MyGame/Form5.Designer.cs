namespace WindowsFormsApplication2
{
    partial class Form5
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
            this.screen = new System.Windows.Forms.Panel();
            this.Ban2 = new System.Windows.Forms.PictureBox();
            this.Ban1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lava = new System.Windows.Forms.PictureBox();
            this.block5 = new System.Windows.Forms.PictureBox();
            this.block = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ban2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ban1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.screen.Controls.Add(this.Ban2);
            this.screen.Controls.Add(this.Ban1);
            this.screen.Controls.Add(this.block2);
            this.screen.Controls.Add(this.label1);
            this.screen.Controls.Add(this.lava);
            this.screen.Controls.Add(this.block5);
            this.screen.Controls.Add(this.block);
            this.screen.Controls.Add(this.block4);
            this.screen.Controls.Add(this.block3);
            this.screen.Controls.Add(this.player);
            this.screen.Location = new System.Drawing.Point(1, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(405, 265);
            this.screen.TabIndex = 1;
            // 
            // Ban2
            // 
            this.Ban2.BackColor = System.Drawing.Color.Yellow;
            this.Ban2.Location = new System.Drawing.Point(311, 174);
            this.Ban2.Name = "Ban2";
            this.Ban2.Size = new System.Drawing.Size(10, 12);
            this.Ban2.TabIndex = 14;
            this.Ban2.TabStop = false;
            // 
            // Ban1
            // 
            this.Ban1.BackColor = System.Drawing.Color.Yellow;
            this.Ban1.Location = new System.Drawing.Point(182, 131);
            this.Ban1.Name = "Ban1";
            this.Ban1.Size = new System.Drawing.Size(10, 12);
            this.Ban1.TabIndex = 13;
            this.Ban1.TabStop = false;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.DimGray;
            this.block2.Location = new System.Drawing.Point(354, 101);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(51, 18);
            this.block2.TabIndex = 12;
            this.block2.TabStop = false;
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
            // lava
            // 
            this.lava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lava.Location = new System.Drawing.Point(3, 230);
            this.lava.Name = "lava";
            this.lava.Size = new System.Drawing.Size(402, 35);
            this.lava.TabIndex = 10;
            this.lava.TabStop = false;
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
            // block
            // 
            this.block.BackColor = System.Drawing.Color.DimGray;
            this.block.Location = new System.Drawing.Point(228, 170);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(39, 80);
            this.block.TabIndex = 7;
            this.block.TabStop = false;
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.DimGray;
            this.block4.Location = new System.Drawing.Point(120, 170);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(39, 95);
            this.block4.TabIndex = 6;
            this.block4.TabStop = false;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.DimGray;
            this.block3.Location = new System.Drawing.Point(262, 204);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(89, 20);
            this.block3.TabIndex = 4;
            this.block3.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player.Location = new System.Drawing.Point(367, 70);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(25, 25);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 262);
            this.Controls.Add(this.screen);
            this.Name = "Form5";
            this.Text = "Form5";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyUp);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ban2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ban1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox Ban2;
        private System.Windows.Forms.PictureBox Ban1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox lava;
        private System.Windows.Forms.PictureBox block5;
        private System.Windows.Forms.PictureBox block;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;

    }
}