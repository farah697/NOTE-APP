namespace TarihliHatirlatmalarUygulamasi
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
            btnKaydet = new Button();
            btnYukle = new Button();
            txtNot = new TextBox();
            txtTarihEkle = new TextBox();
            listBox1 = new ListBox();
            txtTarih1 = new TextBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(12, 290);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 36);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnYukle
            // 
            btnYukle.Location = new Point(632, 285);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(94, 36);
            btnYukle.TabIndex = 1;
            btnYukle.Text = "Yükle";
            btnYukle.UseVisualStyleBackColor = true;
            btnYukle.Click += btnYukle_Click;
            // 
            // txtNot
            // 
            txtNot.Font = new Font("Segoe UI", 12F);
            txtNot.Location = new Point(12, 12);
            txtNot.Multiline = true;
            txtNot.Name = "txtNot";
            txtNot.PlaceholderText = "Notlarınız";
            txtNot.Size = new Size(332, 232);
            txtNot.TabIndex = 3;
            // 
            // txtTarihEkle
            // 
            txtTarihEkle.Font = new Font("Segoe UI", 12F);
            txtTarihEkle.Location = new Point(12, 250);
            txtTarihEkle.Name = "txtTarihEkle";
            txtTarihEkle.PlaceholderText = "Tarih";
            txtTarihEkle.Size = new Size(210, 34);
            txtTarihEkle.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(350, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(373, 264);
            listBox1.TabIndex = 5;
            // 
            // txtTarih1
            // 
            txtTarih1.Font = new Font("Segoe UI", 12F);
            txtTarih1.Location = new Point(416, 287);
            txtTarih1.Name = "txtTarih1";
            txtTarih1.PlaceholderText = "Tarih";
            txtTarih1.Size = new Size(210, 34);
            txtTarih1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 333);
            Controls.Add(txtTarih1);
            Controls.Add(listBox1);
            Controls.Add(txtTarihEkle);
            Controls.Add(txtNot);
            Controls.Add(btnYukle);
            Controls.Add(btnKaydet);
            Name = "Form1";
            Text = "Tarihli Hatırlatmalar Uygulaması";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Button btnYukle;
        private TextBox txtNot;
        private TextBox txtTarihEkle;
        private ListBox listBox1;
        private TextBox txtTarih1;
    }
}
