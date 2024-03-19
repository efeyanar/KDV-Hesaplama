namespace KDV
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gidakontrol = new System.Windows.Forms.CheckBox();
            this.tekstilkontrol = new System.Windows.Forms.CheckBox();
            this.esyakontrol = new System.Windows.Forms.CheckBox();
            this.buton = new System.Windows.Forms.Button();
            this.gidalabel = new System.Windows.Forms.Label();
            this.tekstillabel = new System.Windows.Forms.Label();
            this.esyalabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALIŞVERİŞ TUTARI GİRİNİZ : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(235, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 1;
            // 
            // gidakontrol
            // 
            this.gidakontrol.AutoSize = true;
            this.gidakontrol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gidakontrol.Location = new System.Drawing.Point(16, 83);
            this.gidakontrol.Name = "gidakontrol";
            this.gidakontrol.Size = new System.Drawing.Size(15, 14);
            this.gidakontrol.TabIndex = 2;
            this.gidakontrol.UseVisualStyleBackColor = true;
            // 
            // tekstilkontrol
            // 
            this.tekstilkontrol.AutoSize = true;
            this.tekstilkontrol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tekstilkontrol.Location = new System.Drawing.Point(16, 121);
            this.tekstilkontrol.Name = "tekstilkontrol";
            this.tekstilkontrol.Size = new System.Drawing.Size(15, 14);
            this.tekstilkontrol.TabIndex = 3;
            this.tekstilkontrol.UseVisualStyleBackColor = true;
            // 
            // esyakontrol
            // 
            this.esyakontrol.AutoSize = true;
            this.esyakontrol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esyakontrol.Location = new System.Drawing.Point(16, 159);
            this.esyakontrol.Name = "esyakontrol";
            this.esyakontrol.Size = new System.Drawing.Size(15, 14);
            this.esyakontrol.TabIndex = 4;
            this.esyakontrol.UseVisualStyleBackColor = true;
            // 
            // buton
            // 
            this.buton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton.Location = new System.Drawing.Point(12, 195);
            this.buton.Name = "buton";
            this.buton.Size = new System.Drawing.Size(136, 33);
            this.buton.TabIndex = 5;
            this.buton.Text = "HESAPLA";
            this.buton.UseVisualStyleBackColor = true;
            this.buton.Click += new System.EventHandler(this.buton_Click);
            // 
            // gidalabel
            // 
            this.gidalabel.AutoSize = true;
            this.gidalabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gidalabel.Location = new System.Drawing.Point(231, 80);
            this.gidalabel.Name = "gidalabel";
            this.gidalabel.Size = new System.Drawing.Size(145, 19);
            this.gidalabel.TabIndex = 6;
            this.gidalabel.Text = "KDV\'Lİ FİYATI : ___";
            // 
            // tekstillabel
            // 
            this.tekstillabel.AutoSize = true;
            this.tekstillabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tekstillabel.Location = new System.Drawing.Point(231, 118);
            this.tekstillabel.Name = "tekstillabel";
            this.tekstillabel.Size = new System.Drawing.Size(145, 19);
            this.tekstillabel.TabIndex = 6;
            this.tekstillabel.Text = "KDV\'Lİ FİYATI : ___";
            // 
            // esyalabel
            // 
            this.esyalabel.AutoSize = true;
            this.esyalabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esyalabel.Location = new System.Drawing.Point(231, 156);
            this.esyalabel.Name = "esyalabel";
            this.esyalabel.Size = new System.Drawing.Size(145, 19);
            this.esyalabel.TabIndex = 6;
            this.esyalabel.Text = "KDV\'Lİ FİYATI : ___";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(235, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "TEMEL GIDA ÜRÜNÜ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "TEKSTİL ÜRÜNÜ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "BEYAZ EŞYA ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 267);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.esyalabel);
            this.Controls.Add(this.tekstillabel);
            this.Controls.Add(this.gidalabel);
            this.Controls.Add(this.buton);
            this.Controls.Add(this.esyakontrol);
            this.Controls.Add(this.tekstilkontrol);
            this.Controls.Add(this.gidakontrol);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox gidakontrol;
        private System.Windows.Forms.CheckBox tekstilkontrol;
        private System.Windows.Forms.CheckBox esyakontrol;
        private System.Windows.Forms.Button buton;
        private System.Windows.Forms.Label gidalabel;
        private System.Windows.Forms.Label tekstillabel;
        private System.Windows.Forms.Label esyalabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

