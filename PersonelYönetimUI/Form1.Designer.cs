namespace PersonelYönetimUI
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblPersonelCount = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblPersonelCount);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Oluştur";
            // 
            // button1
            // 
            button1.Location = new Point(34, 114);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 3;
            button1.Text = "personel oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 68);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "soyad";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 39);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ad";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // lblPersonelCount
            // 
            lblPersonelCount.AutoSize = true;
            lblPersonelCount.Location = new Point(156, 19);
            lblPersonelCount.Name = "lblPersonelCount";
            lblPersonelCount.Size = new Size(13, 15);
            lblPersonelCount.TabIndex = 0;
            lblPersonelCount.Text = "0";
            // 
            // button2
            // 
            button2.Location = new Point(252, 51);
            button2.Name = "button2";
            button2.Size = new Size(157, 88);
            button2.TabIndex = 1;
            button2.Text = "grup oluştur";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(267, 156);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(87, 222);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(301, 199);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 448);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblPersonelCount;
        private Button button2;
        private ComboBox comboBox1;
        private ListBox listBox1;
    }
}