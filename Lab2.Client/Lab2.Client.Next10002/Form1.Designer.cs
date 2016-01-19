namespace Lab2.Client.Next10002
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
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelNext1000 = new System.Windows.Forms.Label();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.buttonBirthday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(13, 13);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(166, 17);
            this.labelBirthday.TabIndex = 0;
            this.labelBirthday.Text = "Skriv in ditt födelsedatum";
            // 
            // labelNext1000
            // 
            this.labelNext1000.AutoSize = true;
            this.labelNext1000.Location = new System.Drawing.Point(13, 121);
            this.labelNext1000.Name = "labelNext1000";
            this.labelNext1000.Size = new System.Drawing.Size(0, 17);
            this.labelNext1000.TabIndex = 1;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(16, 34);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(100, 22);
            this.textBoxBirthday.TabIndex = 2;
            // 
            // buttonBirthday
            // 
            this.buttonBirthday.Location = new System.Drawing.Point(16, 72);
            this.buttonBirthday.Name = "buttonBirthday";
            this.buttonBirthday.Size = new System.Drawing.Size(75, 23);
            this.buttonBirthday.TabIndex = 3;
            this.buttonBirthday.Text = "Beräkna";
            this.buttonBirthday.UseVisualStyleBackColor = true;
            this.buttonBirthday.Click += new System.EventHandler(this.buttonBirthday_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 268);
            this.Controls.Add(this.buttonBirthday);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.labelNext1000);
            this.Controls.Add(this.labelBirthday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelNext1000;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.Button buttonBirthday;
    }
}

