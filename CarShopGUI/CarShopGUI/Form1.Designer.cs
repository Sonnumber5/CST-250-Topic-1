namespace CarShopGUI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(53, 46);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Make:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(53, 99);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 1;
            label2.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(53, 156);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientInactiveCaption;
            textBox1.Location = new Point(137, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientInactiveCaption;
            textBox2.Location = new Point(137, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.GradientInactiveCaption;
            textBox3.Location = new Point(137, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(358, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 587);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Car Inventory:";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveBorder;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(19, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(378, 516);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox2);
            groupBox2.ForeColor = SystemColors.Highlight;
            groupBox2.Location = new Point(1012, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(415, 587);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Shopping Cart:";
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.InactiveBorder;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(17, 38);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(378, 516);
            listBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(158, 366);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "Create Car";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(817, 320);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 9;
            button2.Text = "Add To Cart";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1138, 636);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 10;
            button3.Text = "Checkout";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(1156, 704);
            label5.Name = "label5";
            label5.Size = new Size(133, 32);
            label5.TabIndex = 11;
            label5.Text = "Total Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(1026, 704);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 12;
            label4.Text = "Total Cost:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.GradientInactiveCaption;
            textBox4.Location = new Point(137, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(53, 224);
            label6.Name = "label6";
            label6.Size = new Size(67, 32);
            label6.TabIndex = 14;
            label6.Text = "New:";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.GradientInactiveCaption;
            textBox5.Location = new Point(137, 272);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 39);
            textBox5.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(53, 275);
            label7.Name = "label7";
            label7.Size = new Size(76, 32);
            label7.TabIndex = 16;
            label7.Text = "Color:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1458, 758);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label4;
        private ListBox listBox2;
        private ListBox listBox1;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        public Button button3;
    }
}
