namespace traffic_light
{
    partial class Form1
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
            this.pictop = new System.Windows.Forms.PictureBox();
            this.picmid = new System.Windows.Forms.PictureBox();
            this.picbutton = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictop
            // 
            this.pictop.BackColor = System.Drawing.Color.Transparent;
            this.pictop.Image = global::traffic_light.Properties.Resources.red;
            this.pictop.Location = new System.Drawing.Point(425, 24);
            this.pictop.Name = "pictop";
            this.pictop.Size = new System.Drawing.Size(83, 83);
            this.pictop.TabIndex = 0;
            this.pictop.TabStop = false;
            this.pictop.Click += new System.EventHandler(this.pictop_Click);
            // 
            // picmid
            // 
            this.picmid.BackColor = System.Drawing.Color.Transparent;
            this.picmid.Image = global::traffic_light.Properties.Resources.yellow;
            this.picmid.Location = new System.Drawing.Point(425, 113);
            this.picmid.Name = "picmid";
            this.picmid.Size = new System.Drawing.Size(82, 81);
            this.picmid.TabIndex = 1;
            this.picmid.TabStop = false;
            this.picmid.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picbutton
            // 
            this.picbutton.BackColor = System.Drawing.Color.Transparent;
            this.picbutton.Image = global::traffic_light.Properties.Resources.green;
            this.picbutton.Location = new System.Drawing.Point(427, 200);
            this.picbutton.Name = "picbutton";
            this.picbutton.Size = new System.Drawing.Size(78, 81);
            this.picbutton.TabIndex = 2;
            this.picbutton.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::traffic_light.Properties.Resources.traffic_light;
            this.pictureBox4.Location = new System.Drawing.Point(287, -9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(316, 317);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::traffic_light.Properties.Resources.black4;
            this.pictureBox1.Location = new System.Drawing.Point(425, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 77);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::traffic_light.Properties.Resources.road;
            this.ClientSize = new System.Drawing.Size(1212, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picbutton);
            this.Controls.Add(this.picmid);
            this.Controls.Add(this.pictop);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictop;
        private System.Windows.Forms.PictureBox picmid;
        private System.Windows.Forms.PictureBox picbutton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

