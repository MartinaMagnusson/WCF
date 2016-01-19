namespace Lab2.Client.Hobby2
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
            this.buttonShoes = new System.Windows.Forms.Button();
            this.labelShoes = new System.Windows.Forms.Label();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.textBoxShoes = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonShoes
            // 
            this.buttonShoes.Location = new System.Drawing.Point(26, 181);
            this.buttonShoes.Name = "buttonShoes";
            this.buttonShoes.Size = new System.Drawing.Size(195, 23);
            this.buttonShoes.TabIndex = 0;
            this.buttonShoes.Text = "Finns skon i min storlek? ";
            this.buttonShoes.UseVisualStyleBackColor = true;
            this.buttonShoes.Click += new System.EventHandler(this.buttonShoes_Click);
            // 
            // labelShoes
            // 
            this.labelShoes.AutoSize = true;
            this.labelShoes.Location = new System.Drawing.Point(23, 13);
            this.labelShoes.Name = "labelShoes";
            this.labelShoes.Size = new System.Drawing.Size(138, 17);
            this.labelShoes.TabIndex = 1;
            this.labelShoes.Text = "Skriv in skons namn ";
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Checked = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(26, 127);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(72, 21);
            this.radioButtonWoman.TabIndex = 2;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Kvinna";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(26, 154);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(56, 21);
            this.radioButtonMan.TabIndex = 3;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Man";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // textBoxShoes
            // 
            this.textBoxShoes.Location = new System.Drawing.Point(26, 33);
            this.textBoxShoes.Name = "textBoxShoes";
            this.textBoxShoes.Size = new System.Drawing.Size(100, 22);
            this.textBoxShoes.TabIndex = 4;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(26, 78);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxSize.TabIndex = 5;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(23, 58);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(145, 17);
            this.labelSize.TabIndex = 6;
            this.labelSize.Text = "Skriv in din skostorlek";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(23, 107);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(144, 17);
            this.labelGender.TabIndex = 7;
            this.labelGender.Text = "Dam eller herrmodel?";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(26, 224);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(0, 17);
            this.labelAnswer.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxShoes);
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.labelShoes);
            this.Controls.Add(this.buttonShoes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShoes;
        private System.Windows.Forms.Label labelShoes;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.TextBox textBoxShoes;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAnswer;
    }
}

