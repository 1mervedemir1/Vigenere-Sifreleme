namespace Vigenere_Sifreleme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnahtarKelime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYaziSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifrelenenYazi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDesifreYazi = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anahtar Kelime:";
            // 
            // txtAnahtarKelime
            // 
            this.txtAnahtarKelime.Location = new System.Drawing.Point(265, 45);
            this.txtAnahtarKelime.Multiline = true;
            this.txtAnahtarKelime.Name = "txtAnahtarKelime";
            this.txtAnahtarKelime.Size = new System.Drawing.Size(457, 64);
            this.txtAnahtarKelime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifrelenecek Yazı:";
            // 
            // txtYaziSifre
            // 
            this.txtYaziSifre.Location = new System.Drawing.Point(265, 154);
            this.txtYaziSifre.Multiline = true;
            this.txtYaziSifre.Name = "txtYaziSifre";
            this.txtYaziSifre.Size = new System.Drawing.Size(457, 69);
            this.txtYaziSifre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifrelenmiş Hali:";
            // 
            // txtSifrelenenYazi
            // 
            this.txtSifrelenenYazi.Location = new System.Drawing.Point(265, 288);
            this.txtSifrelenenYazi.Multiline = true;
            this.txtSifrelenenYazi.Name = "txtSifrelenenYazi";
            this.txtSifrelenenYazi.Size = new System.Drawing.Size(457, 77);
            this.txtSifrelenenYazi.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(770, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDesifreYazi
            // 
            this.txtDesifreYazi.Location = new System.Drawing.Point(265, 429);
            this.txtDesifreYazi.Multiline = true;
            this.txtDesifreYazi.Name = "txtDesifreYazi";
            this.txtDesifreYazi.Size = new System.Drawing.Size(457, 89);
            this.txtDesifreYazi.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 47);
            this.button3.TabIndex = 10;
            this.button3.Text = "Desifre Et";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(770, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 47);
            this.button4.TabIndex = 11;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 622);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDesifreYazi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSifrelenenYazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYaziSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnahtarKelime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnahtarKelime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYaziSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifrelenenYazi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDesifreYazi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

