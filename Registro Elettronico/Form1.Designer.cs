namespace Registro_Elettronico
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgDocente = new System.Windows.Forms.PictureBox();
            this.imgStudente = new System.Windows.Forms.PictureBox();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblStudente = new System.Windows.Forms.Label();
            this.RegistroElettronico = new System.Windows.Forms.Label();
            this.pHome = new System.Windows.Forms.Panel();
            this.loginStudente = new System.Windows.Forms.Panel();
            this.btnBackStudente = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLoginStudente = new System.Windows.Forms.Button();
            this.lblPasswordStudente = new System.Windows.Forms.Label();
            this.passwordStudente = new System.Windows.Forms.TextBox();
            this.lblUsernameStudente = new System.Windows.Forms.Label();
            this.usernameStudente = new System.Windows.Forms.TextBox();
            this.loginDocente = new System.Windows.Forms.Panel();
            this.btnBackDocente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoginDocente = new System.Windows.Forms.Button();
            this.lblPasswordDocente = new System.Windows.Forms.Label();
            this.passwordDocente = new System.Windows.Forms.TextBox();
            this.lblUsernameDocente = new System.Windows.Forms.Label();
            this.usernameDocente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudente)).BeginInit();
            this.pHome.SuspendLayout();
            this.loginStudente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.loginDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDocente
            // 
            this.imgDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDocente.Image = global::Registro_Elettronico.Properties.Resources.docente;
            this.imgDocente.Location = new System.Drawing.Point(288, 172);
            this.imgDocente.Margin = new System.Windows.Forms.Padding(4);
            this.imgDocente.Name = "imgDocente";
            this.imgDocente.Size = new System.Drawing.Size(267, 246);
            this.imgDocente.TabIndex = 0;
            this.imgDocente.TabStop = false;
            this.imgDocente.Click += new System.EventHandler(this.imgDocente_Click);
            // 
            // imgStudente
            // 
            this.imgStudente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgStudente.Image = global::Registro_Elettronico.Properties.Resources.studente;
            this.imgStudente.Location = new System.Drawing.Point(584, 172);
            this.imgStudente.Margin = new System.Windows.Forms.Padding(4);
            this.imgStudente.Name = "imgStudente";
            this.imgStudente.Size = new System.Drawing.Size(267, 246);
            this.imgStudente.TabIndex = 1;
            this.imgStudente.TabStop = false;
            this.imgStudente.Click += new System.EventHandler(this.imgStudente_Click);
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.BackColor = System.Drawing.Color.SeaShell;
            this.lblDocente.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocente.Location = new System.Drawing.Point(327, 422);
            this.lblDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(172, 46);
            this.lblDocente.TabIndex = 2;
            this.lblDocente.Text = "DOCENTE";
            // 
            // lblStudente
            // 
            this.lblStudente.AutoSize = true;
            this.lblStudente.BackColor = System.Drawing.Color.SeaShell;
            this.lblStudente.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudente.Location = new System.Drawing.Point(619, 422);
            this.lblStudente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudente.Name = "lblStudente";
            this.lblStudente.Size = new System.Drawing.Size(187, 46);
            this.lblStudente.TabIndex = 3;
            this.lblStudente.Text = "STUDENTE";
            // 
            // RegistroElettronico
            // 
            this.RegistroElettronico.AutoSize = true;
            this.RegistroElettronico.BackColor = System.Drawing.Color.SeaShell;
            this.RegistroElettronico.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroElettronico.Location = new System.Drawing.Point(59, 15);
            this.RegistroElettronico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegistroElettronico.Name = "RegistroElettronico";
            this.RegistroElettronico.Size = new System.Drawing.Size(982, 106);
            this.RegistroElettronico.TabIndex = 4;
            this.RegistroElettronico.Text = "REGISTRO ELETTRONICO";
            // 
            // pHome
            // 
            this.pHome.Controls.Add(this.loginStudente);
            this.pHome.Controls.Add(this.loginDocente);
            this.pHome.Controls.Add(this.RegistroElettronico);
            this.pHome.Controls.Add(this.imgDocente);
            this.pHome.Controls.Add(this.lblStudente);
            this.pHome.Controls.Add(this.imgStudente);
            this.pHome.Controls.Add(this.lblDocente);
            this.pHome.Location = new System.Drawing.Point(470, 50);
            this.pHome.Margin = new System.Windows.Forms.Padding(4);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(1277, 537);
            this.pHome.TabIndex = 5;
            // 
            // loginStudente
            // 
            this.loginStudente.BackColor = System.Drawing.Color.SeaShell;
            this.loginStudente.Controls.Add(this.btnBackStudente);
            this.loginStudente.Controls.Add(this.pictureBox2);
            this.loginStudente.Controls.Add(this.btnLoginStudente);
            this.loginStudente.Controls.Add(this.lblPasswordStudente);
            this.loginStudente.Controls.Add(this.passwordStudente);
            this.loginStudente.Controls.Add(this.lblUsernameStudente);
            this.loginStudente.Controls.Add(this.usernameStudente);
            this.loginStudente.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginStudente.Location = new System.Drawing.Point(831, 231);
            this.loginStudente.Margin = new System.Windows.Forms.Padding(4);
            this.loginStudente.Name = "loginStudente";
            this.loginStudente.Size = new System.Drawing.Size(387, 402);
            this.loginStudente.TabIndex = 7;
            // 
            // btnBackStudente
            // 
            this.btnBackStudente.BackColor = System.Drawing.Color.Linen;
            this.btnBackStudente.Location = new System.Drawing.Point(16, 7);
            this.btnBackStudente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackStudente.Name = "btnBackStudente";
            this.btnBackStudente.Size = new System.Drawing.Size(84, 48);
            this.btnBackStudente.TabIndex = 9;
            this.btnBackStudente.Text = "BACK";
            this.btnBackStudente.UseVisualStyleBackColor = false;
            this.btnBackStudente.Click += new System.EventHandler(this.btnBackStudente_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Registro_Elettronico.Properties.Resources.studente;
            this.pictureBox2.Location = new System.Drawing.Point(112, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 246);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnLoginStudente
            // 
            this.btnLoginStudente.BackColor = System.Drawing.Color.Linen;
            this.btnLoginStudente.Location = new System.Drawing.Point(112, 351);
            this.btnLoginStudente.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginStudente.Name = "btnLoginStudente";
            this.btnLoginStudente.Size = new System.Drawing.Size(267, 48);
            this.btnLoginStudente.TabIndex = 4;
            this.btnLoginStudente.Text = "LOGIN";
            this.btnLoginStudente.UseVisualStyleBackColor = false;
            this.btnLoginStudente.Click += new System.EventHandler(this.btnLoginStudente_Click);
            // 
            // lblPasswordStudente
            // 
            this.lblPasswordStudente.AutoSize = true;
            this.lblPasswordStudente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStudente.Location = new System.Drawing.Point(12, 308);
            this.lblPasswordStudente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordStudente.Name = "lblPasswordStudente";
            this.lblPasswordStudente.Size = new System.Drawing.Size(82, 23);
            this.lblPasswordStudente.TabIndex = 3;
            this.lblPasswordStudente.Text = "Password";
            // 
            // passwordStudente
            // 
            this.passwordStudente.Location = new System.Drawing.Point(112, 308);
            this.passwordStudente.Margin = new System.Windows.Forms.Padding(4);
            this.passwordStudente.Name = "passwordStudente";
            this.passwordStudente.Size = new System.Drawing.Size(265, 22);
            this.passwordStudente.TabIndex = 2;
            // 
            // lblUsernameStudente
            // 
            this.lblUsernameStudente.AutoSize = true;
            this.lblUsernameStudente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameStudente.Location = new System.Drawing.Point(12, 276);
            this.lblUsernameStudente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameStudente.Name = "lblUsernameStudente";
            this.lblUsernameStudente.Size = new System.Drawing.Size(87, 23);
            this.lblUsernameStudente.TabIndex = 1;
            this.lblUsernameStudente.Text = "Username";
            // 
            // usernameStudente
            // 
            this.usernameStudente.Location = new System.Drawing.Point(112, 276);
            this.usernameStudente.Margin = new System.Windows.Forms.Padding(4);
            this.usernameStudente.Name = "usernameStudente";
            this.usernameStudente.Size = new System.Drawing.Size(265, 22);
            this.usernameStudente.TabIndex = 0;
            // 
            // loginDocente
            // 
            this.loginDocente.BackColor = System.Drawing.Color.SeaShell;
            this.loginDocente.Controls.Add(this.btnBackDocente);
            this.loginDocente.Controls.Add(this.pictureBox1);
            this.loginDocente.Controls.Add(this.btnLoginDocente);
            this.loginDocente.Controls.Add(this.lblPasswordDocente);
            this.loginDocente.Controls.Add(this.passwordDocente);
            this.loginDocente.Controls.Add(this.lblUsernameDocente);
            this.loginDocente.Controls.Add(this.usernameDocente);
            this.loginDocente.Location = new System.Drawing.Point(830, 231);
            this.loginDocente.Margin = new System.Windows.Forms.Padding(4);
            this.loginDocente.Name = "loginDocente";
            this.loginDocente.Size = new System.Drawing.Size(401, 399);
            this.loginDocente.TabIndex = 6;
            // 
            // btnBackDocente
            // 
            this.btnBackDocente.BackColor = System.Drawing.Color.Linen;
            this.btnBackDocente.Location = new System.Drawing.Point(16, 7);
            this.btnBackDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackDocente.Name = "btnBackDocente";
            this.btnBackDocente.Size = new System.Drawing.Size(84, 48);
            this.btnBackDocente.TabIndex = 8;
            this.btnBackDocente.Text = "BACK";
            this.btnBackDocente.UseVisualStyleBackColor = false;
            this.btnBackDocente.Click += new System.EventHandler(this.btnBackDocente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Registro_Elettronico.Properties.Resources.docente;
            this.pictureBox1.Location = new System.Drawing.Point(112, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 246);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoginDocente
            // 
            this.btnLoginDocente.BackColor = System.Drawing.Color.Linen;
            this.btnLoginDocente.Location = new System.Drawing.Point(112, 351);
            this.btnLoginDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginDocente.Name = "btnLoginDocente";
            this.btnLoginDocente.Size = new System.Drawing.Size(267, 48);
            this.btnLoginDocente.TabIndex = 4;
            this.btnLoginDocente.Text = "LOGIN";
            this.btnLoginDocente.UseVisualStyleBackColor = false;
            this.btnLoginDocente.Click += new System.EventHandler(this.btnLoginDocente_Click);
            // 
            // lblPasswordDocente
            // 
            this.lblPasswordDocente.AutoSize = true;
            this.lblPasswordDocente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordDocente.Location = new System.Drawing.Point(12, 308);
            this.lblPasswordDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordDocente.Name = "lblPasswordDocente";
            this.lblPasswordDocente.Size = new System.Drawing.Size(82, 23);
            this.lblPasswordDocente.TabIndex = 3;
            this.lblPasswordDocente.Text = "Password";
            // 
            // passwordDocente
            // 
            this.passwordDocente.Location = new System.Drawing.Point(112, 308);
            this.passwordDocente.Margin = new System.Windows.Forms.Padding(4);
            this.passwordDocente.Name = "passwordDocente";
            this.passwordDocente.Size = new System.Drawing.Size(265, 22);
            this.passwordDocente.TabIndex = 2;
            // 
            // lblUsernameDocente
            // 
            this.lblUsernameDocente.AutoSize = true;
            this.lblUsernameDocente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameDocente.Location = new System.Drawing.Point(12, 276);
            this.lblUsernameDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameDocente.Name = "lblUsernameDocente";
            this.lblUsernameDocente.Size = new System.Drawing.Size(87, 23);
            this.lblUsernameDocente.TabIndex = 1;
            this.lblUsernameDocente.Text = "Username";
            // 
            // usernameDocente
            // 
            this.usernameDocente.Location = new System.Drawing.Point(112, 276);
            this.usernameDocente.Margin = new System.Windows.Forms.Padding(4);
            this.usernameDocente.Name = "usernameDocente";
            this.usernameDocente.Size = new System.Drawing.Size(265, 22);
            this.usernameDocente.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudente)).EndInit();
            this.pHome.ResumeLayout(false);
            this.pHome.PerformLayout();
            this.loginStudente.ResumeLayout(false);
            this.loginStudente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.loginDocente.ResumeLayout(false);
            this.loginDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDocente;
        private System.Windows.Forms.PictureBox imgStudente;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblStudente;
        private System.Windows.Forms.Label RegistroElettronico;
        private System.Windows.Forms.Panel pHome;
        private System.Windows.Forms.Panel loginDocente;
        private System.Windows.Forms.TextBox usernameDocente;
        private System.Windows.Forms.Label lblUsernameDocente;
        private System.Windows.Forms.Button btnLoginDocente;
        private System.Windows.Forms.Label lblPasswordDocente;
        private System.Windows.Forms.TextBox passwordDocente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBackDocente;
        private System.Windows.Forms.Panel loginStudente;
        private System.Windows.Forms.Button btnBackStudente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLoginStudente;
        private System.Windows.Forms.Label lblPasswordStudente;
        private System.Windows.Forms.TextBox passwordStudente;
        private System.Windows.Forms.Label lblUsernameStudente;
        private System.Windows.Forms.TextBox usernameStudente;
    }
}

