namespace fatu
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
            this.button1 = new System.Windows.Forms.Button();
            this.vergikimlik = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.unvan = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.TextBox();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vergidairesi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.toplamTutarLabel = new System.Windows.Forms.Label();
            this.hesaplananKDVlabel = new System.Windows.Forms.Label();
            this.vergilerDahilLabel = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.UnvanComboBox = new System.Windows.Forms.ComboBox();
            this.kimeKesilecek = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 122);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // vergikimlik
            // 
            this.vergikimlik.Location = new System.Drawing.Point(161, 95);
            this.vergikimlik.Name = "vergikimlik";
            this.vergikimlik.Size = new System.Drawing.Size(180, 23);
            this.vergikimlik.TabIndex = 3;
            // 
            // tarih
            // 
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.Location = new System.Drawing.Point(161, 66);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(180, 23);
            this.tarih.TabIndex = 2;
            // 
            // unvan
            // 
            this.unvan.Location = new System.Drawing.Point(161, 124);
            this.unvan.Name = "unvan";
            this.unvan.Size = new System.Drawing.Size(180, 23);
            this.unvan.TabIndex = 4;
            // 
            // adi
            // 
            this.adi.Location = new System.Drawing.Point(161, 153);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(180, 23);
            this.adi.TabIndex = 5;
            // 
            // soyadi
            // 
            this.soyadi.Location = new System.Drawing.Point(161, 182);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(180, 23);
            this.soyadi.TabIndex = 6;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(512, 69);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adres.Size = new System.Drawing.Size(180, 79);
            this.adres.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fatura Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "T.C. / Vergi Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ünvan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vergi Dairesi:";
            // 
            // vergidairesi
            // 
            this.vergidairesi.Location = new System.Drawing.Point(512, 153);
            this.vergidairesi.Name = "vergidairesi";
            this.vergidairesi.Size = new System.Drawing.Size(180, 23);
            this.vergidairesi.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(347, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(37, 232);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(180, 23);
            this.TextBox1.TabIndex = 9;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(223, 232);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(42, 23);
            this.TextBox2.TabIndex = 10;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(347, 232);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(70, 23);
            this.TextBox3.TabIndex = 12;
            this.TextBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox3_KeyUp);
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(499, 232);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(138, 23);
            this.TextBox6.TabIndex = 14;
            this.TextBox6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox6_KeyUp);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Gün",
            "Ay",
            "Yıl",
            "Saat",
            "Dakika",
            "Saniye",
            "Adet",
            "Paket",
            "Kutu",
            "mg",
            "g",
            "kg",
            "lt",
            "ton",
            "Net Ton",
            "Gross ton",
            "mm",
            "cm",
            "m",
            "km",
            "ml",
            "mm3",
            "cm2",
            "m2",
            "m3",
            "kj",
            "cl",
            "KARAT",
            "MWH",
            "MWH"});
            this.ComboBox1.Location = new System.Drawing.Point(271, 232);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(70, 23);
            this.ComboBox1.TabIndex = 11;
            this.ComboBox1.Text = "Adet";
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "8",
            "18"});
            this.ComboBox2.Location = new System.Drawing.Point(423, 232);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(70, 23);
            this.ComboBox2.TabIndex = 13;
            this.ComboBox2.Text = "18";
            this.ComboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(643, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(672, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "x";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mal/Hizmet Toplam Tutarı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hesaplanan KDV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Vergiler Dahil Toplam Tutar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 458);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ödenecek Tutar:";
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(558, 455);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(138, 23);
            this.TextBox4.TabIndex = 16;
            // 
            // toplamTutarLabel
            // 
            this.toplamTutarLabel.AutoSize = true;
            this.toplamTutarLabel.Location = new System.Drawing.Point(558, 383);
            this.toplamTutarLabel.Name = "toplamTutarLabel";
            this.toplamTutarLabel.Size = new System.Drawing.Size(13, 15);
            this.toplamTutarLabel.TabIndex = 2;
            this.toplamTutarLabel.Text = "0";
            // 
            // hesaplananKDVlabel
            // 
            this.hesaplananKDVlabel.AutoSize = true;
            this.hesaplananKDVlabel.Location = new System.Drawing.Point(558, 408);
            this.hesaplananKDVlabel.Name = "hesaplananKDVlabel";
            this.hesaplananKDVlabel.Size = new System.Drawing.Size(13, 15);
            this.hesaplananKDVlabel.TabIndex = 2;
            this.hesaplananKDVlabel.Text = "0";
            // 
            // vergilerDahilLabel
            // 
            this.vergilerDahilLabel.AutoSize = true;
            this.vergilerDahilLabel.Location = new System.Drawing.Point(558, 433);
            this.vergilerDahilLabel.Name = "vergilerDahilLabel";
            this.vergilerDahilLabel.Size = new System.Drawing.Size(13, 15);
            this.vergilerDahilLabel.TabIndex = 2;
            this.vergilerDahilLabel.Text = "0";
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(37, 484);
            this.TextBox5.Multiline = true;
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox5.Size = new System.Drawing.Size(659, 36);
            this.TextBox5.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(621, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 18;
            this.button4.Text = "Gönder";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UnvanComboBox
            // 
            this.UnvanComboBox.FormattingEnabled = true;
            this.UnvanComboBox.Location = new System.Drawing.Point(38, 24);
            this.UnvanComboBox.Name = "UnvanComboBox";
            this.UnvanComboBox.Size = new System.Drawing.Size(303, 23);
            this.UnvanComboBox.TabIndex = 0;
            // 
            // kimeKesilecek
            // 
            this.kimeKesilecek.FormattingEnabled = true;
            this.kimeKesilecek.Location = new System.Drawing.Point(393, 24);
            this.kimeKesilecek.Name = "kimeKesilecek";
            this.kimeKesilecek.Size = new System.Drawing.Size(303, 23);
            this.kimeKesilecek.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(38, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 11);
            this.label15.TabIndex = 2;
            this.label15.Text = "Mal ve Hizmet Açıklaması";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(223, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 11);
            this.label16.TabIndex = 2;
            this.label16.Text = "Miktar";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(271, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 11);
            this.label17.TabIndex = 2;
            this.label17.Text = "Birim";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(347, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 11);
            this.label18.TabIndex = 2;
            this.label18.Text = "KDV Hariç";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(423, 218);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 11);
            this.label19.TabIndex = 2;
            this.label19.Text = "KDV Oranı";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(499, 218);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 11);
            this.label20.TabIndex = 2;
            this.label20.Text = "Genel Toplam";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridView1.Location = new System.Drawing.Point(37, 261);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(659, 117);
            this.DataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mal / Hizmet";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Miktar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Birim";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tutar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "KDV";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(636, 582);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(742, 700);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.kimeKesilecek);
            this.Controls.Add(this.UnvanComboBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vergilerDahilLabel);
            this.Controls.Add(this.hesaplananKDVlabel);
            this.Controls.Add(this.toplamTutarLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.vergidairesi);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox6);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.unvan);
            this.Controls.Add(this.vergikimlik);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox vergikimlik;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.TextBox unvan;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vergidairesi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox6;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.ComboBox ComboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.Label toplamTutarLabel;
        private System.Windows.Forms.Label hesaplananKDVlabel;
        private System.Windows.Forms.Label vergilerDahilLabel;
        private System.Windows.Forms.TextBox TextBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox UnvanComboBox;
        private System.Windows.Forms.ComboBox kimeKesilecek;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
