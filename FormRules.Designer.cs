namespace OOP_SEMProject
{
    partial class FormRules
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
            this.SrcIP_txt = new System.Windows.Forms.TextBox();
            this.DstIP_text = new System.Windows.Forms.TextBox();
            this.SrcPort_txt = new System.Windows.Forms.TextBox();
            this.DstPort_txt = new System.Windows.Forms.TextBox();
            this.SrcIP_lable = new System.Windows.Forms.Label();
            this.DstIP_lable = new System.Windows.Forms.Label();
            this.SrcPort_lable = new System.Windows.Forms.Label();
            this.DstPort_lable = new System.Windows.Forms.Label();
            this.Protocol_lable = new System.Windows.Forms.Label();
            this.Decision_label = new System.Windows.Forms.Label();
            this.Saverulebtn = new System.Windows.Forms.Button();
            this.Viewrulesbtn = new System.Windows.Forms.Button();
            this.RulesListBox = new System.Windows.Forms.ListBox();
            this.protocolcomboBox = new System.Windows.Forms.ComboBox();
            this.allowradioButton = new System.Windows.Forms.RadioButton();
            this.denyradioButton = new System.Windows.Forms.RadioButton();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SrcIP_txt
            // 
            this.SrcIP_txt.BackColor = System.Drawing.Color.Ivory;
            this.SrcIP_txt.Location = new System.Drawing.Point(235, 117);
            this.SrcIP_txt.Multiline = true;
            this.SrcIP_txt.Name = "SrcIP_txt";
            this.SrcIP_txt.Size = new System.Drawing.Size(183, 44);
            this.SrcIP_txt.TabIndex = 1;
            // 
            // DstIP_text
            // 
            this.DstIP_text.BackColor = System.Drawing.Color.Ivory;
            this.DstIP_text.Location = new System.Drawing.Point(235, 205);
            this.DstIP_text.Multiline = true;
            this.DstIP_text.Name = "DstIP_text";
            this.DstIP_text.Size = new System.Drawing.Size(183, 44);
            this.DstIP_text.TabIndex = 2;
            // 
            // SrcPort_txt
            // 
            this.SrcPort_txt.BackColor = System.Drawing.Color.Ivory;
            this.SrcPort_txt.Location = new System.Drawing.Point(235, 296);
            this.SrcPort_txt.Multiline = true;
            this.SrcPort_txt.Name = "SrcPort_txt";
            this.SrcPort_txt.Size = new System.Drawing.Size(183, 44);
            this.SrcPort_txt.TabIndex = 3;
            // 
            // DstPort_txt
            // 
            this.DstPort_txt.BackColor = System.Drawing.Color.Ivory;
            this.DstPort_txt.Location = new System.Drawing.Point(235, 383);
            this.DstPort_txt.Multiline = true;
            this.DstPort_txt.Name = "DstPort_txt";
            this.DstPort_txt.Size = new System.Drawing.Size(183, 44);
            this.DstPort_txt.TabIndex = 4;
            this.DstPort_txt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // SrcIP_lable
            // 
            this.SrcIP_lable.AutoSize = true;
            this.SrcIP_lable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcIP_lable.ForeColor = System.Drawing.Color.DarkGreen;
            this.SrcIP_lable.Location = new System.Drawing.Point(55, 136);
            this.SrcIP_lable.Name = "SrcIP_lable";
            this.SrcIP_lable.Size = new System.Drawing.Size(113, 25);
            this.SrcIP_lable.TabIndex = 14;
            this.SrcIP_lable.Text = "Source IP";
            // 
            // DstIP_lable
            // 
            this.DstIP_lable.AutoSize = true;
            this.DstIP_lable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DstIP_lable.ForeColor = System.Drawing.Color.DarkGreen;
            this.DstIP_lable.Location = new System.Drawing.Point(40, 224);
            this.DstIP_lable.Name = "DstIP_lable";
            this.DstIP_lable.Size = new System.Drawing.Size(164, 25);
            this.DstIP_lable.TabIndex = 15;
            this.DstIP_lable.Text = "Destination IP";
            // 
            // SrcPort_lable
            // 
            this.SrcPort_lable.AutoSize = true;
            this.SrcPort_lable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcPort_lable.ForeColor = System.Drawing.Color.DarkGreen;
            this.SrcPort_lable.Location = new System.Drawing.Point(55, 315);
            this.SrcPort_lable.Name = "SrcPort_lable";
            this.SrcPort_lable.Size = new System.Drawing.Size(131, 25);
            this.SrcPort_lable.TabIndex = 16;
            this.SrcPort_lable.Text = "Source Port";
            this.SrcPort_lable.Click += new System.EventHandler(this.SrcPort_lable_Click);
            // 
            // DstPort_lable
            // 
            this.DstPort_lable.AutoSize = true;
            this.DstPort_lable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DstPort_lable.ForeColor = System.Drawing.Color.DarkGreen;
            this.DstPort_lable.Location = new System.Drawing.Point(22, 402);
            this.DstPort_lable.Name = "DstPort_lable";
            this.DstPort_lable.Size = new System.Drawing.Size(182, 25);
            this.DstPort_lable.TabIndex = 17;
            this.DstPort_lable.Text = "Destination Port";
            this.DstPort_lable.Click += new System.EventHandler(this.label4_Click);
            // 
            // Protocol_lable
            // 
            this.Protocol_lable.AutoSize = true;
            this.Protocol_lable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Protocol_lable.ForeColor = System.Drawing.Color.DarkGreen;
            this.Protocol_lable.Location = new System.Drawing.Point(71, 493);
            this.Protocol_lable.Name = "Protocol_lable";
            this.Protocol_lable.Size = new System.Drawing.Size(97, 25);
            this.Protocol_lable.TabIndex = 18;
            this.Protocol_lable.Text = "Protocol";
            // 
            // Decision_label
            // 
            this.Decision_label.AutoSize = true;
            this.Decision_label.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decision_label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Decision_label.Location = new System.Drawing.Point(71, 589);
            this.Decision_label.Name = "Decision_label";
            this.Decision_label.Size = new System.Drawing.Size(99, 25);
            this.Decision_label.TabIndex = 19;
            this.Decision_label.Text = "Decision";
            // 
            // Saverulebtn
            // 
            this.Saverulebtn.BackColor = System.Drawing.Color.LightYellow;
            this.Saverulebtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saverulebtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Saverulebtn.Location = new System.Drawing.Point(568, 625);
            this.Saverulebtn.Name = "Saverulebtn";
            this.Saverulebtn.Size = new System.Drawing.Size(127, 46);
            this.Saverulebtn.TabIndex = 20;
            this.Saverulebtn.Text = "Save";
            this.Saverulebtn.UseVisualStyleBackColor = false;
            this.Saverulebtn.Click += new System.EventHandler(this.Saverulebtn_Click);
            // 
            // Viewrulesbtn
            // 
            this.Viewrulesbtn.BackColor = System.Drawing.Color.LightYellow;
            this.Viewrulesbtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewrulesbtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Viewrulesbtn.Location = new System.Drawing.Point(752, 625);
            this.Viewrulesbtn.Name = "Viewrulesbtn";
            this.Viewrulesbtn.Size = new System.Drawing.Size(127, 46);
            this.Viewrulesbtn.TabIndex = 21;
            this.Viewrulesbtn.Text = "View";
            this.Viewrulesbtn.UseVisualStyleBackColor = false;
            this.Viewrulesbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RulesListBox
            // 
            this.RulesListBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.RulesListBox.FormattingEnabled = true;
            this.RulesListBox.ItemHeight = 16;
            this.RulesListBox.Location = new System.Drawing.Point(529, 54);
            this.RulesListBox.Name = "RulesListBox";
            this.RulesListBox.Size = new System.Drawing.Size(556, 468);
            this.RulesListBox.TabIndex = 23;
            // 
            // protocolcomboBox
            // 
            this.protocolcomboBox.BackColor = System.Drawing.Color.LightYellow;
            this.protocolcomboBox.FormattingEnabled = true;
            this.protocolcomboBox.Location = new System.Drawing.Point(235, 494);
            this.protocolcomboBox.Name = "protocolcomboBox";
            this.protocolcomboBox.Size = new System.Drawing.Size(183, 24);
            this.protocolcomboBox.TabIndex = 24;
            // 
            // allowradioButton
            // 
            this.allowradioButton.AutoSize = true;
            this.allowradioButton.Location = new System.Drawing.Point(235, 594);
            this.allowradioButton.Name = "allowradioButton";
            this.allowradioButton.Size = new System.Drawing.Size(60, 20);
            this.allowradioButton.TabIndex = 25;
            this.allowradioButton.TabStop = true;
            this.allowradioButton.Text = "Allow";
            this.allowradioButton.UseVisualStyleBackColor = true;
            // 
            // denyradioButton
            // 
            this.denyradioButton.AutoSize = true;
            this.denyradioButton.Location = new System.Drawing.Point(358, 594);
            this.denyradioButton.Name = "denyradioButton";
            this.denyradioButton.Size = new System.Drawing.Size(60, 20);
            this.denyradioButton.TabIndex = 26;
            this.denyradioButton.TabStop = true;
            this.denyradioButton.Text = "Deny";
            this.denyradioButton.UseVisualStyleBackColor = true;
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.Color.LightYellow;
            this.Reset_btn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Reset_btn.Location = new System.Drawing.Point(925, 625);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(127, 46);
            this.Reset_btn.TabIndex = 27;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = false;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1154, 715);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.denyradioButton);
            this.Controls.Add(this.allowradioButton);
            this.Controls.Add(this.protocolcomboBox);
            this.Controls.Add(this.RulesListBox);
            this.Controls.Add(this.Viewrulesbtn);
            this.Controls.Add(this.Saverulebtn);
            this.Controls.Add(this.Decision_label);
            this.Controls.Add(this.Protocol_lable);
            this.Controls.Add(this.DstPort_lable);
            this.Controls.Add(this.SrcPort_lable);
            this.Controls.Add(this.DstIP_lable);
            this.Controls.Add(this.SrcIP_lable);
            this.Controls.Add(this.DstPort_txt);
            this.Controls.Add(this.SrcPort_txt);
            this.Controls.Add(this.DstIP_text);
            this.Controls.Add(this.SrcIP_txt);
            this.Name = "FormRules";
            this.Text = "Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SrcIP_txt;
        private System.Windows.Forms.TextBox DstIP_text;
        private System.Windows.Forms.TextBox SrcPort_txt;
        private System.Windows.Forms.TextBox DstPort_txt;
        private System.Windows.Forms.Label SrcIP_lable;
        private System.Windows.Forms.Label DstIP_lable;
        private System.Windows.Forms.Label SrcPort_lable;
        private System.Windows.Forms.Label DstPort_lable;
        private System.Windows.Forms.Label Protocol_lable;
        private System.Windows.Forms.Label Decision_label;
        private System.Windows.Forms.Button Saverulebtn;
        private System.Windows.Forms.Button Viewrulesbtn;
        private System.Windows.Forms.ListBox RulesListBox;
        private System.Windows.Forms.ComboBox protocolcomboBox;
        private System.Windows.Forms.RadioButton allowradioButton;
        private System.Windows.Forms.RadioButton denyradioButton;
        private System.Windows.Forms.Button Reset_btn;
    }
}