namespace ArsivYonetimi
{
    partial class EvrakListele
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
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            lblSaat = new ToolStripLabel();
            button1 = new Button();
            cmbEvrakTuru = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 106);
            panel1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(109, 38);
            label5.Name = "label5";
            label5.Size = new Size(134, 30);
            label5.TabIndex = 7;
            label5.Text = "Evrak Listele";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_create_document_48;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblSaat });
            toolStrip1.Location = new Point(0, 387);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(329, 25);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // lblSaat
            // 
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(105, 22);
            lblSaat.Text = "Saat: {placeholder}";
            // 
            // button1
            // 
            button1.Location = new Point(246, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbEvrakTuru
            // 
            cmbEvrakTuru.FormattingEnabled = true;
            cmbEvrakTuru.Location = new Point(110, 205);
            cmbEvrakTuru.Name = "cmbEvrakTuru";
            cmbEvrakTuru.Size = new Size(211, 23);
            cmbEvrakTuru.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 208);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Evrak türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 179);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 7;
            label3.Text = "Evrak konumu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 150);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 8;
            label2.Text = "Evrak sahibi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 121);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 9;
            label1.Text = "Evrak adı";
            // 
            // EvrakListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 412);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(button1);
            Controls.Add(cmbEvrakTuru);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EvrakListele";
            Text = "EvrakListle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private ToolStripLabel lblSaat;
        private Button button1;
        private ComboBox cmbEvrakTuru;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}