namespace kalkulatorProsty
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
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            plus = new Button();
            minus = new Button();
            divide = new Button();
            multiply = new Button();
            window = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 136);
            button3.Name = "button3";
            button3.Size = new Size(50, 29);
            button3.TabIndex = 2;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(68, 136);
            button1.Name = "button1";
            button1.Size = new Size(50, 29);
            button1.TabIndex = 3;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(124, 136);
            button2.Name = "button2";
            button2.Size = new Size(50, 29);
            button2.TabIndex = 4;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(124, 101);
            button4.Name = "button4";
            button4.Size = new Size(50, 29);
            button4.TabIndex = 7;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(68, 101);
            button5.Name = "button5";
            button5.Size = new Size(50, 29);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 101);
            button6.Name = "button6";
            button6.Size = new Size(50, 29);
            button6.TabIndex = 5;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(124, 66);
            button7.Name = "button7";
            button7.Size = new Size(50, 29);
            button7.TabIndex = 10;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(68, 66);
            button8.Name = "button8";
            button8.Size = new Size(50, 29);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(12, 66);
            button9.Name = "button9";
            button9.Size = new Size(50, 29);
            button9.TabIndex = 8;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(68, 171);
            button10.Name = "button10";
            button10.Size = new Size(50, 29);
            button10.TabIndex = 11;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // plus
            // 
            plus.BackColor = SystemColors.ControlLight;
            plus.Location = new Point(180, 66);
            plus.Name = "plus";
            plus.Size = new Size(50, 29);
            plus.TabIndex = 12;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.BackColor = SystemColors.ControlLight;
            minus.Location = new Point(180, 101);
            minus.Name = "minus";
            minus.Size = new Size(50, 29);
            minus.TabIndex = 13;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // divide
            // 
            divide.BackColor = SystemColors.ControlLight;
            divide.Location = new Point(180, 136);
            divide.Name = "divide";
            divide.Size = new Size(50, 29);
            divide.TabIndex = 14;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // multiply
            // 
            multiply.BackColor = SystemColors.ControlLight;
            multiply.Location = new Point(180, 171);
            multiply.Name = "multiply";
            multiply.Size = new Size(50, 29);
            multiply.TabIndex = 15;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += multiply_Click;
            // 
            // window
            // 
            window.Location = new Point(12, 33);
            window.Name = "window";
            window.Size = new Size(218, 27);
            window.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 248);
            Controls.Add(window);
            Controls.Add(multiply);
            Controls.Add(divide);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button plus;
        private Button minus;
        private Button divide;
        private Button multiply;
        private TextBox window;
    }
}
