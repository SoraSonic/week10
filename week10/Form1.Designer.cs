namespace week10
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
            this.question_number = new System.Windows.Forms.Label();
            this.question_content = new System.Windows.Forms.Label();
            this.A_radioButton = new System.Windows.Forms.RadioButton();
            this.B_radioButton = new System.Windows.Forms.RadioButton();
            this.C_radioButton = new System.Windows.Forms.RadioButton();
            this.D_radioButton = new System.Windows.Forms.RadioButton();
            this.Next_button = new System.Windows.Forms.Button();
            this.Check_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question_number
            // 
            this.question_number.AutoSize = true;
            this.question_number.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_number.Location = new System.Drawing.Point(216, 73);
            this.question_number.Name = "question_number";
            this.question_number.Size = new System.Drawing.Size(46, 19);
            this.question_number.TabIndex = 0;
            this.question_number.Text = "Cau 0";
            // 
            // question_content
            // 
            this.question_content.AutoSize = true;
            this.question_content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_content.Location = new System.Drawing.Point(319, 73);
            this.question_content.Name = "question_content";
            this.question_content.Size = new System.Drawing.Size(103, 19);
            this.question_content.TabIndex = 1;
            this.question_content.Text = "Are you ready?";
            // 
            // A_radioButton
            // 
            this.A_radioButton.AutoSize = true;
            this.A_radioButton.Location = new System.Drawing.Point(323, 140);
            this.A_radioButton.Name = "A_radioButton";
            this.A_radioButton.Size = new System.Drawing.Size(32, 17);
            this.A_radioButton.TabIndex = 2;
            this.A_radioButton.TabStop = true;
            this.A_radioButton.Text = "A";
            this.A_radioButton.UseVisualStyleBackColor = true;
            // 
            // B_radioButton
            // 
            this.B_radioButton.AutoSize = true;
            this.B_radioButton.Location = new System.Drawing.Point(323, 179);
            this.B_radioButton.Name = "B_radioButton";
            this.B_radioButton.Size = new System.Drawing.Size(32, 17);
            this.B_radioButton.TabIndex = 3;
            this.B_radioButton.TabStop = true;
            this.B_radioButton.Text = "B";
            this.B_radioButton.UseVisualStyleBackColor = true;
            // 
            // C_radioButton
            // 
            this.C_radioButton.AutoSize = true;
            this.C_radioButton.Location = new System.Drawing.Point(323, 219);
            this.C_radioButton.Name = "C_radioButton";
            this.C_radioButton.Size = new System.Drawing.Size(32, 17);
            this.C_radioButton.TabIndex = 4;
            this.C_radioButton.TabStop = true;
            this.C_radioButton.Text = "C";
            this.C_radioButton.UseVisualStyleBackColor = true;
            // 
            // D_radioButton
            // 
            this.D_radioButton.AutoSize = true;
            this.D_radioButton.Location = new System.Drawing.Point(323, 259);
            this.D_radioButton.Name = "D_radioButton";
            this.D_radioButton.Size = new System.Drawing.Size(33, 17);
            this.D_radioButton.TabIndex = 5;
            this.D_radioButton.TabStop = true;
            this.D_radioButton.Text = "D";
            this.D_radioButton.UseVisualStyleBackColor = true;
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(523, 320);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(75, 23);
            this.Next_button.TabIndex = 6;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Check_button
            // 
            this.Check_button.Location = new System.Drawing.Point(333, 320);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(75, 23);
            this.Check_button.TabIndex = 7;
            this.Check_button.Text = "Check";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 380);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.D_radioButton);
            this.Controls.Add(this.C_radioButton);
            this.Controls.Add(this.B_radioButton);
            this.Controls.Add(this.A_radioButton);
            this.Controls.Add(this.question_content);
            this.Controls.Add(this.question_number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question_number;
        private System.Windows.Forms.Label question_content;
        private System.Windows.Forms.RadioButton A_radioButton;
        private System.Windows.Forms.RadioButton B_radioButton;
        private System.Windows.Forms.RadioButton C_radioButton;
        private System.Windows.Forms.RadioButton D_radioButton;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Check_button;
    }
}

