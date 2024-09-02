namespace Registro_Elettronico
{
    partial class Form3
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
            this.p3cii = new System.Windows.Forms.Panel();
            this.lblTerzacii = new System.Windows.Forms.Label();
            this.p4cii = new System.Windows.Forms.Panel();
            this.lblQuartacii = new System.Windows.Forms.Label();
            this.p5cii = new System.Windows.Forms.Panel();
            this.lblQuintacii = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pHome = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.p3cii.SuspendLayout();
            this.p4cii.SuspendLayout();
            this.p5cii.SuspendLayout();
            this.pHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // p3cii
            // 
            this.p3cii.BackColor = System.Drawing.Color.Linen;
            this.p3cii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p3cii.Controls.Add(this.lblTerzacii);
            this.p3cii.Location = new System.Drawing.Point(569, 407);
            this.p3cii.Name = "p3cii";
            this.p3cii.Size = new System.Drawing.Size(261, 372);
            this.p3cii.TabIndex = 0;
            this.p3cii.Click += new System.EventHandler(this.p3cii_Click);
            // 
            // lblTerzacii
            // 
            this.lblTerzacii.AutoSize = true;
            this.lblTerzacii.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerzacii.Location = new System.Drawing.Point(12, 113);
            this.lblTerzacii.Name = "lblTerzacii";
            this.lblTerzacii.Size = new System.Drawing.Size(241, 133);
            this.lblTerzacii.TabIndex = 2;
            this.lblTerzacii.Text = "3CII";
            // 
            // p4cii
            // 
            this.p4cii.BackColor = System.Drawing.Color.Linen;
            this.p4cii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p4cii.Controls.Add(this.lblQuartacii);
            this.p4cii.Location = new System.Drawing.Point(861, 407);
            this.p4cii.Name = "p4cii";
            this.p4cii.Size = new System.Drawing.Size(261, 372);
            this.p4cii.TabIndex = 1;
            this.p4cii.Click += new System.EventHandler(this.p4cii_Click);
            // 
            // lblQuartacii
            // 
            this.lblQuartacii.AutoSize = true;
            this.lblQuartacii.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuartacii.Location = new System.Drawing.Point(12, 113);
            this.lblQuartacii.Name = "lblQuartacii";
            this.lblQuartacii.Size = new System.Drawing.Size(241, 133);
            this.lblQuartacii.TabIndex = 3;
            this.lblQuartacii.Text = "4CII";
            // 
            // p5cii
            // 
            this.p5cii.BackColor = System.Drawing.Color.Linen;
            this.p5cii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p5cii.Controls.Add(this.lblQuintacii);
            this.p5cii.Location = new System.Drawing.Point(1154, 407);
            this.p5cii.Name = "p5cii";
            this.p5cii.Size = new System.Drawing.Size(261, 372);
            this.p5cii.TabIndex = 1;
            this.p5cii.Click += new System.EventHandler(this.p5cii_Click);
            // 
            // lblQuintacii
            // 
            this.lblQuintacii.AutoSize = true;
            this.lblQuintacii.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuintacii.Location = new System.Drawing.Point(12, 113);
            this.lblQuintacii.Name = "lblQuintacii";
            this.lblQuintacii.Size = new System.Drawing.Size(241, 133);
            this.lblQuintacii.TabIndex = 4;
            this.lblQuintacii.Text = "5CII";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(953, 133);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleziona la classe";
            // 
            // pHome
            // 
            this.pHome.Controls.Add(this.button1);
            this.pHome.Controls.Add(this.label1);
            this.pHome.Controls.Add(this.p5cii);
            this.pHome.Controls.Add(this.p3cii);
            this.pHome.Controls.Add(this.p4cii);
            this.pHome.Location = new System.Drawing.Point(12, 12);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(1872, 941);
            this.pHome.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 88);
            this.button1.TabIndex = 4;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pHome);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.p3cii.ResumeLayout(false);
            this.p3cii.PerformLayout();
            this.p4cii.ResumeLayout(false);
            this.p4cii.PerformLayout();
            this.p5cii.ResumeLayout(false);
            this.p5cii.PerformLayout();
            this.pHome.ResumeLayout(false);
            this.pHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p3cii;
        private System.Windows.Forms.Panel p4cii;
        private System.Windows.Forms.Panel p5cii;
        private System.Windows.Forms.Label lblTerzacii;
        private System.Windows.Forms.Label lblQuartacii;
        private System.Windows.Forms.Label lblQuintacii;
        private System.Windows.Forms.Panel pHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}