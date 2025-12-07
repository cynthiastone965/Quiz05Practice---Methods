namespace Quiz05Practice___Methods
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            outputLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            q2Button = new Button();
            label4 = new Label();
            q3Button = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            q01Button = new Button();
            SuspendLayout();
            // 
            // outputLabel
            // 
            outputLabel.BorderStyle = BorderStyle.FixedSingle;
            outputLabel.Location = new Point(258, 414);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(372, 115);
            outputLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 25);
            label1.TabIndex = 1;
            label1.Text = "Q01 - using a built in method (2 marks)";
            // 
            // label2
            // 
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(365, 67);
            label2.TabIndex = 2;
            label2.Text = "When the user hits the button, a random number between 1 and 100 will be displayed in outputLabel.";
            // 
            // label3
            // 
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 192);
            label3.Name = "label3";
            label3.Size = new Size(365, 56);
            label3.TabIndex = 4;
            label3.Text = "Q02 - creating and calling on a method that is designed by the coder (3 marks)";
            // 
            // q2Button
            // 
            q2Button.BackColor = Color.Maroon;
            q2Button.ForeColor = Color.White;
            q2Button.Location = new Point(12, 370);
            q2Button.Name = "q2Button";
            q2Button.Size = new Size(350, 41);
            q2Button.TabIndex = 6;
            q2Button.Text = "Code Me!";
            q2Button.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(365, 119);
            label4.TabIndex = 5;
            label4.Text = resources.GetString("label4.Text");
            // 
            // q3Button
            // 
            q3Button.BackColor = Color.Maroon;
            q3Button.ForeColor = Color.White;
            q3Button.Location = new Point(493, 370);
            q3Button.Name = "q3Button";
            q3Button.Size = new Size(350, 41);
            q3Button.TabIndex = 9;
            q3Button.Text = "Code Me!";
            q3Button.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(493, 79);
            label5.Name = "label5";
            label5.Size = new Size(365, 238);
            label5.TabIndex = 8;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(493, 9);
            label6.Name = "label6";
            label6.Size = new Size(365, 61);
            label6.TabIndex = 7;
            label6.Text = "Q03 - creating a method that will return a value to the main program.  ICS3U ONLY!  (5 marks)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(493, 338);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(620, 338);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 26);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(743, 338);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 26);
            textBox3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(534, 316);
            label7.Name = "label7";
            label7.Size = new Size(18, 19);
            label7.TabIndex = 13;
            label7.Text = "a";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(664, 316);
            label8.Name = "label8";
            label8.Size = new Size(18, 19);
            label8.TabIndex = 14;
            label8.Text = "b";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(785, 316);
            label9.Name = "label9";
            label9.Size = new Size(18, 19);
            label9.TabIndex = 15;
            label9.Text = "c";
            // 
            // q01Button
            // 
            q01Button.BackColor = Color.Maroon;
            q01Button.ForeColor = Color.White;
            q01Button.Location = new Point(3, 104);
            q01Button.Name = "q01Button";
            q01Button.Size = new Size(350, 41);
            q01Button.TabIndex = 16;
            q01Button.Text = "Code Me!";
            q01Button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(905, 545);
            Controls.Add(q01Button);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(q3Button);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(q2Button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outputLabel);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Green;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Quiz 05 Methods Practice";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label outputLabel;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button q2Button;
        private Label label4;
        private Button q3Button;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button q01Button;
    }
}
