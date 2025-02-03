namespace OOP_SEMProject
{
    partial class FormFirewall
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
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.CheckPacketBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 16;
            this.ResultsListBox.Location = new System.Drawing.Point(39, 42);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(1097, 452);
            this.ResultsListBox.TabIndex = 0;
            // 
            // CheckPacketBtn
            // 
            this.CheckPacketBtn.BackColor = System.Drawing.Color.LightYellow;
            this.CheckPacketBtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPacketBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CheckPacketBtn.Location = new System.Drawing.Point(462, 564);
            this.CheckPacketBtn.Name = "CheckPacketBtn";
            this.CheckPacketBtn.Size = new System.Drawing.Size(223, 46);
            this.CheckPacketBtn.TabIndex = 22;
            this.CheckPacketBtn.Text = "Check Packets";
            this.CheckPacketBtn.UseVisualStyleBackColor = false;
            this.CheckPacketBtn.Click += new System.EventHandler(this.CheckPacketBtn_Click);
            // 
            // FormFirewall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1163, 719);
            this.Controls.Add(this.CheckPacketBtn);
            this.Controls.Add(this.ResultsListBox);
            this.Name = "FormFirewall";
            this.Text = "Firewall";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Button CheckPacketBtn;
    }
}