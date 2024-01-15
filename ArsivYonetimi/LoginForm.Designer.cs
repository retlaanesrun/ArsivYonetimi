namespace ArsivYonetimi
{
    partial class LoginForm
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
            panel1 = new Panel();
            lblHata = new Label();
            btnGiris = new Button();
            panel2 = new Panel();
            txtParola = new TextBox();
            __label1 = new Label();
            __label2 = new Label();
            txtKullanici = new TextBox();
            __label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHata);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(__label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 501);
            panel1.TabIndex = 0;
            // 
            // lblHata
            // 
            lblHata.AutoSize = true;
            lblHata.Location = new Point(103, 325);
            lblHata.Name = "lblHata";
            lblHata.Size = new Size(169, 15);
            lblHata.TabIndex = 5;
            lblHata.Text = "Kullanıcı adı veya parola hatalı!";
            lblHata.Visible = false;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(197, 299);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(75, 23);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtParola);
            panel2.Controls.Add(__label1);
            panel2.Controls.Add(__label2);
            panel2.Controls.Add(txtKullanici);
            panel2.Location = new Point(66, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 58);
            panel2.TabIndex = 4;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(80, 32);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(126, 23);
            txtParola.TabIndex = 2;
            txtParola.UseSystemPasswordChar = true;
            txtParola.TextChanged += txtParola_TextChanged;
            txtParola.KeyDown += txtKullanici_KeyDown;
            // 
            // __label1
            // 
            __label1.AutoSize = true;
            __label1.Location = new Point(3, 11);
            __label1.Name = "__label1";
            __label1.Size = new Size(71, 15);
            __label1.TabIndex = 0;
            __label1.Text = "Kullanıcı adı";
            // 
            // __label2
            // 
            __label2.AutoSize = true;
            __label2.Location = new Point(3, 40);
            __label2.Name = "__label2";
            __label2.Size = new Size(40, 15);
            __label2.TabIndex = 0;
            __label2.Text = "Parola";
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(80, 3);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(126, 23);
            txtKullanici.TabIndex = 1;
            txtKullanici.KeyDown += txtKullanici_KeyDown;
            // 
            // __label3
            // 
            __label3.AutoSize = true;
            __label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            __label3.Location = new Point(85, 198);
            __label3.Name = "__label3";
            __label3.Size = new Size(174, 21);
            __label3.TabIndex = 3;
            __label3.Text = "Arşiv Kontrol Yazılımı";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 501);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "Arşiv Kontrol :: Giriş";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtParola;
        private Label __label1;
        private Label __label2;
        private TextBox txtKullanici;
        private Label __label3;
        private Button btnGiris;
        private Label lblHata;
    }
}