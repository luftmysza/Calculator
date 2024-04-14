namespace OneMoreCalculator
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
            one = new Button();
            two = new Button();
            three = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            plus = new Button();
            devide = new Button();
            multiply = new Button();
            minus = new Button();
            zero = new Button();
            Input = new TextBox();
            equals = new Button();
            SuspendLayout();
            // 
            // one
            // 
            one.Location = new Point(83, 79);
            one.Name = "one";
            one.Size = new Size(75, 23);
            one.TabIndex = 1;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // two
            // 
            two.Location = new Point(164, 79);
            two.Name = "two";
            two.Size = new Size(75, 23);
            two.TabIndex = 2;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // three
            // 
            three.Location = new Point(245, 79);
            three.Name = "three";
            three.Size = new Size(75, 23);
            three.TabIndex = 3;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // four
            // 
            four.Location = new Point(83, 108);
            four.Name = "four";
            four.Size = new Size(75, 23);
            four.TabIndex = 4;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // five
            // 
            five.Location = new Point(164, 108);
            five.Name = "five";
            five.Size = new Size(75, 23);
            five.TabIndex = 6;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // six
            // 
            six.Location = new Point(245, 108);
            six.Name = "six";
            six.Size = new Size(75, 23);
            six.TabIndex = 5;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // seven
            // 
            seven.Location = new Point(83, 137);
            seven.Name = "seven";
            seven.Size = new Size(75, 23);
            seven.TabIndex = 8;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // eight
            // 
            eight.Location = new Point(164, 137);
            eight.Name = "eight";
            eight.Size = new Size(75, 23);
            eight.TabIndex = 7;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // nine
            // 
            nine.Location = new Point(245, 137);
            nine.Name = "nine";
            nine.Size = new Size(75, 23);
            nine.TabIndex = 9;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // plus
            // 
            plus.Location = new Point(326, 79);
            plus.Name = "plus";
            plus.Size = new Size(47, 23);
            plus.TabIndex = 10;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // devide
            // 
            devide.Location = new Point(326, 166);
            devide.Name = "devide";
            devide.Size = new Size(47, 23);
            devide.TabIndex = 11;
            devide.Text = "/";
            devide.UseVisualStyleBackColor = true;
            devide.Click += devide_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(326, 137);
            multiply.Name = "multiply";
            multiply.Size = new Size(47, 23);
            multiply.TabIndex = 12;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // minus
            // 
            minus.Location = new Point(326, 108);
            minus.Name = "minus";
            minus.Size = new Size(47, 23);
            minus.TabIndex = 13;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // zero
            // 
            zero.Location = new Point(83, 166);
            zero.Name = "zero";
            zero.Size = new Size(75, 23);
            zero.TabIndex = 14;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // Input
            // 
            Input.Location = new Point(83, 25);
            Input.Name = "Input";
            Input.Size = new Size(290, 23);
            Input.TabIndex = 15;
            Input.KeyDown += Input_KeyDown;
            // 
            // equals
            // 
            equals.Location = new Point(164, 166);
            equals.Name = "equals";
            equals.Size = new Size(156, 23);
            equals.TabIndex = 16;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(equals);
            Controls.Add(Input);
            Controls.Add(zero);
            Controls.Add(minus);
            Controls.Add(multiply);
            Controls.Add(devide);
            Controls.Add(plus);
            Controls.Add(nine);
            Controls.Add(seven);
            Controls.Add(eight);
            Controls.Add(five);
            Controls.Add(six);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button plus;
        private Button devide;
        private Button multiply;
        private Button minus;
        private Button zero;
        private TextBox Input;
        private Button equals;
    }
}
