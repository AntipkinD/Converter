namespace Converter
{
    partial class Converter
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
        void InitializeComponent()
        {
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(184, 258);
            button1.Name = "button1";
            button1.Size = new Size(424, 96);
            button1.TabIndex = 0;
            button1.Text = "КОНВЕРТИРОВАТЬ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(184, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 1;
            comboBox1.TabStop = false;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 53);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 2;
            label1.Text = "Русский размер";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(184, 144);
            label2.Name = "label2";
            label2.Size = new Size(179, 23);
            label2.TabIndex = 3;
            label2.Text = "Японский размер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(487, 54);
            label4.Name = "label4";
            label4.Size = new Size(43, 23);
            label4.TabIndex = 5;
            label4.Text = "пол";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Cursor = Cursors.Hand;
            radioButton1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(487, 78);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 23);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "мужской";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Cursor = Cursors.Hand;
            radioButton2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(487, 105);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(98, 23);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "женский";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(184, 178);
            label3.Name = "label3";
            label3.Size = new Size(0, 36);
            label3.TabIndex = 8;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(345, 360);
            button2.Name = "button2";
            button2.Size = new Size(108, 49);
            button2.TabIndex = 9;
            button2.Text = "ПОМЕНЯТЬ МЕСТАМИ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Converter";
            Text = "Converter (RU, JP)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        internal ComboBox comboBox1;
        private Button button2;
    }
}