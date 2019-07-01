namespace DisconnectedMimari1
{
    partial class Kategoriler
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
            this.kategorileriListele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcatname = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResimEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kategorileriListele)).BeginInit();
            this.SuspendLayout();
            // 
            // kategorileriListele
            // 
            this.kategorileriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategorileriListele.Location = new System.Drawing.Point(12, 150);
            this.kategorileriListele.Name = "kategorileriListele";
            this.kategorileriListele.Size = new System.Drawing.Size(567, 288);
            this.kategorileriListele.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tanımı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KategoriAdı";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcatname
            // 
            this.txtcatname.Location = new System.Drawing.Point(51, 83);
            this.txtcatname.Name = "txtcatname";
            this.txtcatname.Size = new System.Drawing.Size(100, 20);
            this.txtcatname.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(209, 83);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 2;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(495, 73);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(84, 39);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Picture";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(342, 76);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(83, 33);
            this.btnResimEkle.TabIndex = 4;
            this.btnResimEkle.Text = "Resim Bul";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtcatname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategorileriListele);
            this.Name = "Kategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategorileriListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kategorileriListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcatname;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResimEkle;
    }
}