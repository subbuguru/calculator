namespace calculator
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
            btn_num = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_Plus = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_Equal = new Button();
            btn_Minus = new Button();
            btn_Mult = new Button();
            btn_Div = new Button();
            textBox1 = new TextBox();
            btn_0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btn_num
            // 
            btn_num.Location = new Point(12, 76);
            btn_num.Name = "btn_num";
            btn_num.Size = new Size(75, 64);
            btn_num.TabIndex = 0;
            btn_num.Text = "1";
            btn_num.UseVisualStyleBackColor = true;
            btn_num.Click += numButton_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(93, 76);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(75, 64);
            btn_2.TabIndex = 1;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += numButton_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(174, 76);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(75, 64);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += numButton_Click;
            // 
            // btn_Plus
            // 
            btn_Plus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Plus.Location = new Point(255, 76);
            btn_Plus.Name = "btn_Plus";
            btn_Plus.Size = new Size(75, 64);
            btn_Plus.TabIndex = 6;
            btn_Plus.Text = "+";
            btn_Plus.UseVisualStyleBackColor = true;
            btn_Plus.Click += operButton_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(174, 216);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(75, 64);
            btn_9.TabIndex = 7;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += numButton_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(93, 216);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(75, 64);
            btn_8.TabIndex = 8;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += numButton_Click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(12, 216);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(75, 64);
            btn_7.TabIndex = 9;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += numButton_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(174, 146);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(75, 64);
            btn_6.TabIndex = 10;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += numButton_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(93, 146);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(75, 64);
            btn_5.TabIndex = 11;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += numButton_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(12, 146);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(75, 64);
            btn_4.TabIndex = 12;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += numButton_Click;
            // 
            // btn_Equal
            // 
            btn_Equal.Location = new Point(174, 286);
            btn_Equal.Name = "btn_Equal";
            btn_Equal.Size = new Size(75, 64);
            btn_Equal.TabIndex = 15;
            btn_Equal.Text = "=";
            btn_Equal.UseVisualStyleBackColor = true;
            btn_Equal.Click += equalButton_Click;
            // 
            // btn_Minus
            // 
            btn_Minus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Minus.Location = new Point(255, 146);
            btn_Minus.Name = "btn_Minus";
            btn_Minus.Size = new Size(75, 64);
            btn_Minus.TabIndex = 17;
            btn_Minus.Text = "-";
            btn_Minus.UseVisualStyleBackColor = true;
            btn_Minus.Click += operButton_Click;
            // 
            // btn_Mult
            // 
            btn_Mult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Mult.Location = new Point(255, 216);
            btn_Mult.Name = "btn_Mult";
            btn_Mult.Size = new Size(75, 64);
            btn_Mult.TabIndex = 18;
            btn_Mult.Text = "x";
            btn_Mult.UseVisualStyleBackColor = true;
            btn_Mult.Click += operButton_Click;
            // 
            // btn_Div
            // 
            btn_Div.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Div.Location = new Point(255, 286);
            btn_Div.Name = "btn_Div";
            btn_Div.Size = new Size(75, 64);
            btn_Div.TabIndex = 19;
            btn_Div.Text = "/";
            btn_Div.UseVisualStyleBackColor = true;
            btn_Div.Click += operButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(318, 50);
            textBox1.TabIndex = 20;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(12, 286);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(75, 64);
            btn_0.TabIndex = 16;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += numButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(174, 354);
            button1.Name = "button1";
            button1.Size = new Size(156, 64);
            button1.TabIndex = 21;
            button1.Text = "AC";
            button1.UseVisualStyleBackColor = true;
            button1.Click += resetButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 64);
            button2.TabIndex = 22;
            button2.Text = ".";
            button2.UseVisualStyleBackColor = true;
            button2.Click += numButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 354);
            button3.Name = "button3";
            button3.Size = new Size(156, 64);
            button3.TabIndex = 23;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 430);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(btn_Div);
            Controls.Add(btn_Mult);
            Controls.Add(btn_Minus);
            Controls.Add(btn_0);
            Controls.Add(btn_Equal);
            Controls.Add(btn_4);
            Controls.Add(btn_5);
            Controls.Add(btn_6);
            Controls.Add(btn_7);
            Controls.Add(btn_8);
            Controls.Add(btn_9);
            Controls.Add(btn_Plus);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_num);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_num;
        private Button btn_2;
        private Button btn_3;
        private Button button6;
        private Button btn_Plus;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button button4;
        private Button button5;
        private Button btn_Equal;
        private Button btn_Minus;
        private Button btn_Mult;
        private Button btn_Div;
        private TextBox textBox1;
        private Button btn_0;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}