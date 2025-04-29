namespace Bubble_Sort
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            txtInput4 = new TextBox();
            txtInput3 = new TextBox();
            txtInput2 = new TextBox();
            txtInput1 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            lbOutput1 = new Label();
            lbOutput2 = new Label();
            txtInput = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtInput4);
            groupBox1.Controls.Add(txtInput3);
            groupBox1.Controls.Add(txtInput2);
            groupBox1.Controls.Add(txtInput1);
            groupBox1.Location = new Point(65, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "陣列排序";
            // 
            // button1
            // 
            button1.Location = new Point(48, 110);
            button1.Name = "button1";
            button1.Size = new Size(171, 23);
            button1.TabIndex = 4;
            button1.Text = "排序：從小到大";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(299, 110);
            button2.Name = "button2";
            button2.Size = new Size(171, 23);
            button2.TabIndex = 5;
            button2.Text = "排序：從大到小";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtInput4
            // 
            txtInput4.Location = new Point(396, 51);
            txtInput4.Name = "txtInput4";
            txtInput4.Size = new Size(100, 23);
            txtInput4.TabIndex = 3;
            // 
            // txtInput3
            // 
            txtInput3.Location = new Point(268, 51);
            txtInput3.Name = "txtInput3";
            txtInput3.Size = new Size(100, 23);
            txtInput3.TabIndex = 2;
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(145, 51);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(100, 23);
            txtInput2.TabIndex = 1;
            // 
            // txtInput1
            // 
            txtInput1.Location = new Point(20, 51);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(100, 23);
            txtInput1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lbOutput1);
            groupBox2.Controls.Add(lbOutput2);
            groupBox2.Controls.Add(txtInput);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(65, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(533, 134);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "輸入隨機產生的亂數數量";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 30);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 4;
            label2.Text = "輸入亂數數量: ";
            // 
            // lbOutput1
            // 
            lbOutput1.AutoSize = true;
            lbOutput1.Location = new Point(20, 66);
            lbOutput1.Name = "lbOutput1";
            lbOutput1.Size = new Size(73, 15);
            lbOutput1.TabIndex = 3;
            lbOutput1.Text = "未排序亂數: ";
            // 
            // lbOutput2
            // 
            lbOutput2.AutoSize = true;
            lbOutput2.Location = new Point(20, 100);
            lbOutput2.Name = "lbOutput2";
            lbOutput2.Size = new Size(73, 15);
            lbOutput2.TabIndex = 2;
            lbOutput2.Text = "已排序亂數: ";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(145, 25);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(293, 26);
            button3.Name = "button3";
            button3.Size = new Size(116, 23);
            button3.TabIndex = 0;
            button3.Text = "排序: 從小到大";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtInput4;
        private TextBox txtInput3;
        private TextBox txtInput2;
        private TextBox txtInput1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button button3;
        private TextBox txtInput;
        private Label lbOutput2;
        private Label lbOutput1;
        private Label label2;
    }
}
