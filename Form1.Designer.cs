namespace Assignment_4._1._2
{
    partial class Calculator
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
            ResulttextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonAdd = new Button();
            buttonminus = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonmultiply = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            buttondivide = new Button();
            buttonzero = new Button();
            buttondecimal = new Button();
            buttonclear = new Button();
            buttonequal = new Button();
            SuspendLayout();
            // 
            // ResulttextBox
            // 
            ResulttextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResulttextBox.Location = new Point(22, 29);
            ResulttextBox.Name = "ResulttextBox";
            ResulttextBox.Size = new Size(371, 43);
            ResulttextBox.TabIndex = 0;
            ResulttextBox.Text = "0";
            ResulttextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(63, 334);
            button1.Name = "button1";
            button1.Size = new Size(73, 70);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(142, 334);
            button2.Name = "button2";
            button2.Size = new Size(73, 70);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(221, 334);
            button3.Name = "button3";
            button3.Size = new Size(73, 70);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(300, 334);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(77, 70);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonminus
            // 
            buttonminus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonminus.Location = new Point(300, 258);
            buttonminus.Name = "buttonminus";
            buttonminus.Size = new Size(77, 70);
            buttonminus.TabIndex = 8;
            buttonminus.Text = "-";
            buttonminus.UseVisualStyleBackColor = true;
            buttonminus.Click += buttonminus_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(221, 258);
            button6.Name = "button6";
            button6.Size = new Size(73, 70);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(142, 258);
            button5.Name = "button5";
            button5.Size = new Size(73, 70);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(63, 258);
            button4.Name = "button4";
            button4.Size = new Size(73, 70);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonmultiply
            // 
            buttonmultiply.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonmultiply.Location = new Point(300, 182);
            buttonmultiply.Name = "buttonmultiply";
            buttonmultiply.Size = new Size(77, 70);
            buttonmultiply.TabIndex = 12;
            buttonmultiply.Text = "*";
            buttonmultiply.UseVisualStyleBackColor = true;
            buttonmultiply.Click += buttonmultiply_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(221, 182);
            button9.Name = "button9";
            button9.Size = new Size(73, 70);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(142, 182);
            button8.Name = "button8";
            button8.Size = new Size(73, 70);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(63, 182);
            button7.Name = "button7";
            button7.Size = new Size(73, 70);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // buttondivide
            // 
            buttondivide.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondivide.Location = new Point(300, 106);
            buttondivide.Name = "buttondivide";
            buttondivide.Size = new Size(77, 70);
            buttondivide.TabIndex = 16;
            buttondivide.Text = "/";
            buttondivide.UseVisualStyleBackColor = true;
            buttondivide.Click += buttondivide_Click;
            // 
            // buttonzero
            // 
            buttonzero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonzero.Location = new Point(221, 106);
            buttonzero.Name = "buttonzero";
            buttonzero.Size = new Size(73, 70);
            buttonzero.TabIndex = 15;
            buttonzero.Text = "0";
            buttonzero.UseVisualStyleBackColor = true;
            buttonzero.Click += buttonzero_Click;
            // 
            // buttondecimal
            // 
            buttondecimal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondecimal.Location = new Point(142, 106);
            buttondecimal.Name = "buttondecimal";
            buttondecimal.Size = new Size(73, 70);
            buttondecimal.TabIndex = 14;
            buttondecimal.Text = ".";
            buttondecimal.UseVisualStyleBackColor = true;
            buttondecimal.Click += buttondecimal_Click;
            // 
            // buttonclear
            // 
            buttonclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonclear.Location = new Point(63, 106);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(73, 70);
            buttonclear.TabIndex = 13;
            buttonclear.Text = "C";
            buttonclear.UseVisualStyleBackColor = true;
            buttonclear.Click += buttonclear_Click;
            // 
            // buttonequal
            // 
            buttonequal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonequal.Location = new Point(63, 410);
            buttonequal.Name = "buttonequal";
            buttonequal.Size = new Size(314, 58);
            buttonequal.TabIndex = 17;
            buttonequal.Text = "=";
            buttonequal.UseVisualStyleBackColor = true;
            buttonequal.Click += buttonequal_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 513);
            Controls.Add(buttonequal);
            Controls.Add(buttondivide);
            Controls.Add(buttonzero);
            Controls.Add(buttondecimal);
            Controls.Add(buttonclear);
            Controls.Add(buttonmultiply);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(buttonminus);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonAdd);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ResulttextBox);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ResulttextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonAdd;
        private Button buttonminus;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonmultiply;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button buttondivide;
        private Button buttonzero;
        private Button buttondecimal;
        private Button buttonclear;
        private Button buttonequal;
    }
}
