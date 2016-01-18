namespace Lab2.Client.BMI2
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
            this.buttonBMI = new System.Windows.Forms.Button();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelBMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBMI
            // 
            this.buttonBMI.Location = new System.Drawing.Point(44, 120);
            this.buttonBMI.Name = "buttonBMI";
            this.buttonBMI.Size = new System.Drawing.Size(160, 23);
            this.buttonBMI.TabIndex = 0;
            this.buttonBMI.Text = "Beräkna BMI";
            this.buttonBMI.UseVisualStyleBackColor = true;
            this.buttonBMI.Click += new System.EventHandler(this.buttonBMI_Click);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(41, 26);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(110, 17);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Skriv in din vikt: ";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(41, 74);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(163, 17);
            this.labelLength.TabIndex = 2;
            this.labelLength.Text = "Skriv in din längd i meter";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(236, 26);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxWeight.TabIndex = 3;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(236, 69);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxLength.TabIndex = 4;
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Location = new System.Drawing.Point(236, 125);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(0, 17);
            this.labelBMI.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 420);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.buttonBMI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBMI;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelBMI;
    }
}

