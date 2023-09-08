namespace WindowsFormsApplication2
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.ecran = new System.Windows.Forms.Panel();
            this.screen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ecran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // ecran
            // 
            this.ecran.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ecran.Controls.Add(this.screen);
            this.ecran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ecran.Location = new System.Drawing.Point(0, 0);
            this.ecran.Name = "ecran";
            this.ecran.Size = new System.Drawing.Size(184, 182);
            this.ecran.TabIndex = 0;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.screen.Image = ((System.Drawing.Image)(resources.GetObject("screen.Image")));
            this.screen.Location = new System.Drawing.Point(37, 41);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(100, 407);
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 182);
            this.Controls.Add(this.ecran);
            this.Name = "Form7";
            this.Text = "Credits";
            this.ecran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ecran;
        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Timer timer1;
    }
}