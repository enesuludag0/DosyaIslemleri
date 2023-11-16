namespace DosyaIslemleri
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
            this.bttnFolderBrowserDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bttnOpenFileDialog = new System.Windows.Forms.Button();
            this.bttnSaveFileDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtBelgeYolu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnKonumSec = new System.Windows.Forms.Button();
            this.bttnDosyaOlustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBelgeAdi = new System.Windows.Forms.TextBox();
            this.bttnOku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bttnYazdir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // bttnFolderBrowserDialog
            // 
            this.bttnFolderBrowserDialog.Location = new System.Drawing.Point(467, 12);
            this.bttnFolderBrowserDialog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttnFolderBrowserDialog.Name = "bttnFolderBrowserDialog";
            this.bttnFolderBrowserDialog.Size = new System.Drawing.Size(215, 37);
            this.bttnFolderBrowserDialog.TabIndex = 1;
            this.bttnFolderBrowserDialog.Text = "Folder Browser Dialog";
            this.bttnFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.bttnFolderBrowserDialog.Click += new System.EventHandler(this.bttnFolderBrowserDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bttnOpenFileDialog
            // 
            this.bttnOpenFileDialog.Location = new System.Drawing.Point(467, 55);
            this.bttnOpenFileDialog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttnOpenFileDialog.Name = "bttnOpenFileDialog";
            this.bttnOpenFileDialog.Size = new System.Drawing.Size(215, 37);
            this.bttnOpenFileDialog.TabIndex = 2;
            this.bttnOpenFileDialog.Text = "Open File Dialog";
            this.bttnOpenFileDialog.UseVisualStyleBackColor = true;
            this.bttnOpenFileDialog.Click += new System.EventHandler(this.bttnOpenFileDialog_Click);
            // 
            // bttnSaveFileDialog
            // 
            this.bttnSaveFileDialog.Location = new System.Drawing.Point(467, 98);
            this.bttnSaveFileDialog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttnSaveFileDialog.Name = "bttnSaveFileDialog";
            this.bttnSaveFileDialog.Size = new System.Drawing.Size(215, 37);
            this.bttnSaveFileDialog.TabIndex = 3;
            this.bttnSaveFileDialog.Text = "Save File Dialog";
            this.bttnSaveFileDialog.UseVisualStyleBackColor = true;
            this.bttnSaveFileDialog.Click += new System.EventHandler(this.bttnSaveFileDialog_Click);
            // 
            // txtBelgeYolu
            // 
            this.txtBelgeYolu.Location = new System.Drawing.Point(119, 16);
            this.txtBelgeYolu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBelgeYolu.Name = "txtBelgeYolu";
            this.txtBelgeYolu.Size = new System.Drawing.Size(217, 28);
            this.txtBelgeYolu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Belge Yolu:";
            // 
            // bttnKonumSec
            // 
            this.bttnKonumSec.Location = new System.Drawing.Point(467, 142);
            this.bttnKonumSec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttnKonumSec.Name = "bttnKonumSec";
            this.bttnKonumSec.Size = new System.Drawing.Size(215, 37);
            this.bttnKonumSec.TabIndex = 6;
            this.bttnKonumSec.Text = "Konum Seç";
            this.bttnKonumSec.UseVisualStyleBackColor = true;
            this.bttnKonumSec.Click += new System.EventHandler(this.bttnKonumSec_Click);
            // 
            // bttnDosyaOlustur
            // 
            this.bttnDosyaOlustur.Location = new System.Drawing.Point(467, 184);
            this.bttnDosyaOlustur.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttnDosyaOlustur.Name = "bttnDosyaOlustur";
            this.bttnDosyaOlustur.Size = new System.Drawing.Size(215, 37);
            this.bttnDosyaOlustur.TabIndex = 7;
            this.bttnDosyaOlustur.Text = "Dosya Oluştur";
            this.bttnDosyaOlustur.UseVisualStyleBackColor = true;
            this.bttnDosyaOlustur.Click += new System.EventHandler(this.bttnDosyaOlustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Belge Adı:";
            // 
            // txtBelgeAdi
            // 
            this.txtBelgeAdi.Location = new System.Drawing.Point(119, 59);
            this.txtBelgeAdi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBelgeAdi.Name = "txtBelgeAdi";
            this.txtBelgeAdi.Size = new System.Drawing.Size(217, 28);
            this.txtBelgeAdi.TabIndex = 8;
            // 
            // bttnOku
            // 
            this.bttnOku.Location = new System.Drawing.Point(467, 227);
            this.bttnOku.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttnOku.Name = "bttnOku";
            this.bttnOku.Size = new System.Drawing.Size(215, 37);
            this.bttnOku.TabIndex = 10;
            this.bttnOku.Text = "Oku";
            this.bttnOku.UseVisualStyleBackColor = true;
            this.bttnOku.Click += new System.EventHandler(this.bttnOku_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(25, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 48);
            this.listBox1.TabIndex = 11;
            // 
            // bttnYazdir
            // 
            this.bttnYazdir.Location = new System.Drawing.Point(467, 270);
            this.bttnYazdir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttnYazdir.Name = "bttnYazdir";
            this.bttnYazdir.Size = new System.Drawing.Size(215, 37);
            this.bttnYazdir.TabIndex = 12;
            this.bttnYazdir.Text = "Yazdır";
            this.bttnYazdir.UseVisualStyleBackColor = true;
            this.bttnYazdir.Click += new System.EventHandler(this.bttnYazdir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(311, 216);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 416);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bttnYazdir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bttnOku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBelgeAdi);
            this.Controls.Add(this.bttnDosyaOlustur);
            this.Controls.Add(this.bttnKonumSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBelgeYolu);
            this.Controls.Add(this.bttnSaveFileDialog);
            this.Controls.Add(this.bttnOpenFileDialog);
            this.Controls.Add(this.bttnFolderBrowserDialog);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bttnOpenFileDialog;
        private System.Windows.Forms.Button bttnSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtBelgeYolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnKonumSec;
        private System.Windows.Forms.Button bttnDosyaOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBelgeAdi;
        private System.Windows.Forms.Button bttnOku;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bttnYazdir;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

