namespace WindowsFormsApp9
{
    partial class FormGiris
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
            this.aba = new System.Windows.Forms.Label();
            this.lblkul = new System.Windows.Forms.TextBox();
            this.caba = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aba
            // 
            this.aba.AutoSize = true;
            this.aba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aba.Location = new System.Drawing.Point(137, 148);
            this.aba.Name = "aba";
            this.aba.Size = new System.Drawing.Size(138, 24);
            this.aba.TabIndex = 0;
            this.aba.Text = "Kullanıcı Adı :";
            // 
            // lblkul
            // 
            this.lblkul.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkul.Location = new System.Drawing.Point(332, 131);
            this.lblkul.Name = "lblkul";
            this.lblkul.Size = new System.Drawing.Size(182, 41);
            this.lblkul.TabIndex = 1;
            // 
            // caba
            // 
            this.caba.AutoSize = true;
            this.caba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.caba.Location = new System.Drawing.Point(137, 241);
            this.caba.Name = "caba";
            this.caba.Size = new System.Drawing.Size(64, 24);
            this.caba.TabIndex = 2;
            this.caba.Text = "Şifre :";
            // 
            // lblsifre
            // 
            this.lblsifre.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(332, 224);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(182, 41);
            this.lblsifre.TabIndex = 3;
            this.lblsifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(181, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 57);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Takip Sistemi ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(332, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.caba);
            this.Controls.Add(this.lblkul);
            this.Controls.Add(this.aba);
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aba;
        private System.Windows.Forms.TextBox lblkul;
        private System.Windows.Forms.Label caba;
        private System.Windows.Forms.TextBox lblsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}