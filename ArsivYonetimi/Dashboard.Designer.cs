namespace ArsivYonetimi
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            lblSaat = new Label();
            lblGreet = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlEvrakEkle = new Panel();
            __label2 = new Label();
            __pictureBox1 = new PictureBox();
            pnlEvrakListele = new Panel();
            __label3 = new Label();
            __pictureBox2 = new PictureBox();
            pnlErisimGecmisi = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            saat = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlEvrakEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)__pictureBox1).BeginInit();
            pnlEvrakListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)__pictureBox2).BeginInit();
            pnlErisimGecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblSaat);
            splitContainer1.Panel1.Controls.Add(lblGreet);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(621, 450);
            splitContainer1.SplitterDistance = 175;
            splitContainer1.TabIndex = 0;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(12, 426);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(105, 15);
            lblSaat.TabIndex = 1;
            lblSaat.Text = "Saat: {placeholder}";
            // 
            // lblGreet
            // 
            lblGreet.AutoSize = true;
            lblGreet.Location = new Point(12, 43);
            lblGreet.Name = "lblGreet";
            lblGreet.Size = new Size(133, 15);
            lblGreet.TabIndex = 1;
            lblGreet.Text = "Merhaba, {placeholder}.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 0;
            label1.Text = "Arşiv Kontrol";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pnlEvrakEkle);
            flowLayoutPanel1.Controls.Add(pnlEvrakListele);
            flowLayoutPanel1.Controls.Add(pnlErisimGecmisi);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(442, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlEvrakEkle
            // 
            pnlEvrakEkle.BackColor = Color.FromArgb(255, 192, 192);
            pnlEvrakEkle.BorderStyle = BorderStyle.FixedSingle;
            pnlEvrakEkle.Controls.Add(__label2);
            pnlEvrakEkle.Controls.Add(__pictureBox1);
            pnlEvrakEkle.Location = new Point(25, 25);
            pnlEvrakEkle.Margin = new Padding(25);
            pnlEvrakEkle.Name = "pnlEvrakEkle";
            pnlEvrakEkle.Size = new Size(150, 150);
            pnlEvrakEkle.TabIndex = 0;
            pnlEvrakEkle.Click += pnlEvrakEkle_Click;
            // 
            // __label2
            // 
            __label2.AutoSize = true;
            __label2.ForeColor = Color.Black;
            __label2.Location = new Point(46, 113);
            __label2.Name = "__label2";
            __label2.Size = new Size(59, 15);
            __label2.TabIndex = 1;
            __label2.Text = "Evrak Ekle";
            __label2.Click += pnlEvrakEkle_Click;
            // 
            // __pictureBox1
            // 
            __pictureBox1.Image = Properties.Resources.icons8_create_document_48;
            __pictureBox1.Location = new Point(37, 32);
            __pictureBox1.Name = "__pictureBox1";
            __pictureBox1.Size = new Size(76, 78);
            __pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            __pictureBox1.TabIndex = 0;
            __pictureBox1.TabStop = false;
            __pictureBox1.Click += pnlEvrakEkle_Click;
            // 
            // pnlEvrakListele
            // 
            pnlEvrakListele.BackColor = Color.FromArgb(192, 255, 192);
            pnlEvrakListele.BorderStyle = BorderStyle.FixedSingle;
            pnlEvrakListele.Controls.Add(__label3);
            pnlEvrakListele.Controls.Add(__pictureBox2);
            pnlEvrakListele.Location = new Point(200, 25);
            pnlEvrakListele.Margin = new Padding(0, 25, 25, 25);
            pnlEvrakListele.Name = "pnlEvrakListele";
            pnlEvrakListele.Size = new Size(150, 150);
            pnlEvrakListele.TabIndex = 1;
            pnlEvrakListele.Click += pnlEvrakListele_Click;
            // 
            // __label3
            // 
            __label3.AutoSize = true;
            __label3.ForeColor = Color.Black;
            __label3.Location = new Point(40, 113);
            __label3.Name = "__label3";
            __label3.Size = new Size(71, 15);
            __label3.TabIndex = 1;
            __label3.Text = "Evrak Listele";
            __label3.Click += pnlEvrakListele_Click;
            // 
            // __pictureBox2
            // 
            __pictureBox2.Image = Properties.Resources.icons8_documents_48;
            __pictureBox2.Location = new Point(37, 32);
            __pictureBox2.Name = "__pictureBox2";
            __pictureBox2.Size = new Size(76, 78);
            __pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            __pictureBox2.TabIndex = 0;
            __pictureBox2.TabStop = false;
            __pictureBox2.Click += pnlEvrakListele_Click;
            // 
            // pnlErisimGecmisi
            // 
            pnlErisimGecmisi.BackColor = Color.FromArgb(192, 192, 255);
            pnlErisimGecmisi.BorderStyle = BorderStyle.FixedSingle;
            pnlErisimGecmisi.Controls.Add(label2);
            pnlErisimGecmisi.Controls.Add(pictureBox1);
            pnlErisimGecmisi.Location = new Point(25, 200);
            pnlErisimGecmisi.Margin = new Padding(25, 0, 25, 25);
            pnlErisimGecmisi.Name = "pnlErisimGecmisi";
            pnlErisimGecmisi.Size = new Size(150, 150);
            pnlErisimGecmisi.TabIndex = 2;
            pnlErisimGecmisi.Click += pnlErisimGecmisi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(33, 113);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Erişim Geçmişi";
            label2.Click += pnlErisimGecmisi_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_laptop_analytic_48;
            pictureBox1.Location = new Point(37, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pnlErisimGecmisi_Click;
            // 
            // saat
            // 
            saat.Interval = 60000;
            saat.Tick += saat_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            Text = "Arşiv Kontrol :: Dashboard";
            Load += Dashboard_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            pnlEvrakEkle.ResumeLayout(false);
            pnlEvrakEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)__pictureBox1).EndInit();
            pnlEvrakListele.ResumeLayout(false);
            pnlEvrakListele.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)__pictureBox2).EndInit();
            pnlErisimGecmisi.ResumeLayout(false);
            pnlErisimGecmisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label lblGreet;
        private Label lblSaat;
        private System.Windows.Forms.Timer saat;
        private Panel pnlEvrakEkle;
        private Label __label2;
        private PictureBox __pictureBox1;
        private Panel pnlEvrakListele;
        private Label __label3;
        private PictureBox __pictureBox2;
        private Panel pnlErisimGecmisi;
        private Label label2;
        private PictureBox pictureBox1;
    }
}