namespace OOP_SEMProject
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.UpperMenue = new System.Windows.Forms.Panel();
            this.Parentpanel = new System.Windows.Forms.Panel();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.Rulebtn = new System.Windows.Forms.Button();
            this.Pacetbtn = new System.Windows.Forms.Button();
            this.Firewallbtn = new System.Windows.Forms.Button();
            this.Helpbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UpperMenue.SuspendLayout();
            this.Parentpanel.SuspendLayout();
            this.Leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperMenue
            // 
            this.UpperMenue.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UpperMenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpperMenue.Controls.Add(this.label1);
            this.UpperMenue.Controls.Add(this.pictureBox1);
            this.UpperMenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperMenue.Location = new System.Drawing.Point(0, 0);
            this.UpperMenue.Name = "UpperMenue";
            this.UpperMenue.Size = new System.Drawing.Size(1599, 121);
            this.UpperMenue.TabIndex = 0;
            // 
            // Parentpanel
            // 
            this.Parentpanel.BackColor = System.Drawing.Color.Honeydew;
            this.Parentpanel.Controls.Add(this.pictureBox2);
            this.Parentpanel.Controls.Add(this.Leftpanel);
            this.Parentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parentpanel.Location = new System.Drawing.Point(0, 121);
            this.Parentpanel.Name = "Parentpanel";
            this.Parentpanel.Size = new System.Drawing.Size(1599, 866);
            this.Parentpanel.TabIndex = 2;
            this.Parentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Parentpanel_Paint);
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Leftpanel.Controls.Add(this.Helpbtn);
            this.Leftpanel.Controls.Add(this.Firewallbtn);
            this.Leftpanel.Controls.Add(this.Pacetbtn);
            this.Leftpanel.Controls.Add(this.Rulebtn);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(200, 866);
            this.Leftpanel.TabIndex = 0;
            // 
            // Rulebtn
            // 
            this.Rulebtn.BackColor = System.Drawing.Color.Honeydew;
            this.Rulebtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rulebtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Rulebtn.Location = new System.Drawing.Point(32, 50);
            this.Rulebtn.Name = "Rulebtn";
            this.Rulebtn.Size = new System.Drawing.Size(127, 46);
            this.Rulebtn.TabIndex = 0;
            this.Rulebtn.Text = "Rules";
            this.Rulebtn.UseVisualStyleBackColor = false;
            this.Rulebtn.Click += new System.EventHandler(this.Rulebtn_Click);
            // 
            // Pacetbtn
            // 
            this.Pacetbtn.BackColor = System.Drawing.Color.Honeydew;
            this.Pacetbtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pacetbtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Pacetbtn.Location = new System.Drawing.Point(32, 148);
            this.Pacetbtn.Name = "Pacetbtn";
            this.Pacetbtn.Size = new System.Drawing.Size(127, 46);
            this.Pacetbtn.TabIndex = 1;
            this.Pacetbtn.Text = "Packets";
            this.Pacetbtn.UseVisualStyleBackColor = false;
            this.Pacetbtn.Click += new System.EventHandler(this.Pacetbtn_Click);
            // 
            // Firewallbtn
            // 
            this.Firewallbtn.BackColor = System.Drawing.Color.Honeydew;
            this.Firewallbtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firewallbtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Firewallbtn.Location = new System.Drawing.Point(32, 248);
            this.Firewallbtn.Name = "Firewallbtn";
            this.Firewallbtn.Size = new System.Drawing.Size(127, 46);
            this.Firewallbtn.TabIndex = 2;
            this.Firewallbtn.Text = "Firewall";
            this.Firewallbtn.UseVisualStyleBackColor = false;
            this.Firewallbtn.Click += new System.EventHandler(this.Firewallbtn_Click);
            // 
            // Helpbtn
            // 
            this.Helpbtn.BackColor = System.Drawing.Color.Honeydew;
            this.Helpbtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpbtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Helpbtn.Location = new System.Drawing.Point(32, 342);
            this.Helpbtn.Name = "Helpbtn";
            this.Helpbtn.Size = new System.Drawing.Size(127, 46);
            this.Helpbtn.TabIndex = 3;
            this.Helpbtn.Text = "Help";
            this.Helpbtn.UseVisualStyleBackColor = false;
            this.Helpbtn.Click += new System.EventHandler(this.Helpbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, -182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(784, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 123);
            this.label1.TabIndex = 2;
            this.label1.Text = "FireWall";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(842, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 326);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 987);
            this.Controls.Add(this.Parentpanel);
            this.Controls.Add(this.UpperMenue);
            this.Name = "Home";
            this.Text = "FireWall";
            this.UpperMenue.ResumeLayout(false);
            this.UpperMenue.PerformLayout();
            this.Parentpanel.ResumeLayout(false);
            this.Parentpanel.PerformLayout();
            this.Leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperMenue;
        private System.Windows.Forms.Panel Parentpanel;
        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Button Rulebtn;
        private System.Windows.Forms.Button Helpbtn;
        private System.Windows.Forms.Button Firewallbtn;
        private System.Windows.Forms.Button Pacetbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

