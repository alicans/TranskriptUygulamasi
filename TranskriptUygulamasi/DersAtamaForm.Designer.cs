namespace TranskriptUygulamasi
{
    partial class DersAtamaForm
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
            groupBox1 = new GroupBox();
            cmbHarfNotlari = new ComboBox();
            label4 = new Label();
            cmbDonemler = new ComboBox();
            label3 = new Label();
            cmbDersAdlari = new ComboBox();
            cmbOgrenciler = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnAtamaYap = new Button();
            dgvAtanan = new DataGridView();
            groupBox2 = new GroupBox();
            btnAtamaSil = new Button();
            btnAtamaDuzenle = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtanan).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbHarfNotlari);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbDonemler);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbDersAdlari);
            groupBox1.Controls.Add(cmbOgrenciler);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAtamaYap);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 230);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Atama Bilgileri";
            // 
            // cmbHarfNotlari
            // 
            cmbHarfNotlari.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHarfNotlari.FormattingEnabled = true;
            cmbHarfNotlari.Location = new Point(151, 137);
            cmbHarfNotlari.Name = "cmbHarfNotlari";
            cmbHarfNotlari.Size = new Size(191, 23);
            cmbHarfNotlari.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 139);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 13;
            label4.Text = "Harf Notu:";
            // 
            // cmbDonemler
            // 
            cmbDonemler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonemler.FormattingEnabled = true;
            cmbDonemler.Location = new Point(151, 108);
            cmbDonemler.Name = "cmbDonemler";
            cmbDonemler.Size = new Size(191, 23);
            cmbDonemler.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 110);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 11;
            label3.Text = "Dönem:";
            // 
            // cmbDersAdlari
            // 
            cmbDersAdlari.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDersAdlari.FormattingEnabled = true;
            cmbDersAdlari.Location = new Point(151, 79);
            cmbDersAdlari.Name = "cmbDersAdlari";
            cmbDersAdlari.Size = new Size(191, 23);
            cmbDersAdlari.TabIndex = 10;
            // 
            // cmbOgrenciler
            // 
            cmbOgrenciler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgrenciler.FormattingEnabled = true;
            cmbOgrenciler.Location = new Point(151, 50);
            cmbOgrenciler.Name = "cmbOgrenciler";
            cmbOgrenciler.Size = new Size(191, 23);
            cmbOgrenciler.TabIndex = 9;
            cmbOgrenciler.SelectedIndexChanged += cmbOgrenciler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 81);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Ders Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 52);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci:";
            // 
            // btnAtamaYap
            // 
            btnAtamaYap.Location = new Point(21, 176);
            btnAtamaYap.Name = "btnAtamaYap";
            btnAtamaYap.Size = new Size(321, 42);
            btnAtamaYap.TabIndex = 2;
            btnAtamaYap.Text = "Atama Yap";
            btnAtamaYap.UseVisualStyleBackColor = true;
            btnAtamaYap.Click += btnAtamaYap_Click;
            // 
            // dgvAtanan
            // 
            dgvAtanan.AllowUserToAddRows = false;
            dgvAtanan.AllowUserToDeleteRows = false;
            dgvAtanan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAtanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAtanan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAtanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtanan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column5, Column2, Column3, Column4, Column6, Column7 });
            dgvAtanan.Location = new Point(374, 22);
            dgvAtanan.MultiSelect = false;
            dgvAtanan.Name = "dgvAtanan";
            dgvAtanan.ReadOnly = true;
            dgvAtanan.RowHeadersVisible = false;
            dgvAtanan.RowTemplate.Height = 25;
            dgvAtanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtanan.ShowEditingIcon = false;
            dgvAtanan.Size = new Size(555, 416);
            dgvAtanan.TabIndex = 4;
            dgvAtanan.MouseClick += dgvAtanan_MouseClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAtamaSil);
            groupBox2.Controls.Add(btnAtamaDuzenle);
            groupBox2.Location = new Point(12, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 67);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veri İşlemleri";
            // 
            // btnAtamaSil
            // 
            btnAtamaSil.ForeColor = Color.Red;
            btnAtamaSil.Location = new Point(213, 22);
            btnAtamaSil.Name = "btnAtamaSil";
            btnAtamaSil.Size = new Size(137, 39);
            btnAtamaSil.TabIndex = 1;
            btnAtamaSil.Text = "Atamayı Sil";
            btnAtamaSil.UseVisualStyleBackColor = true;
            btnAtamaSil.Click += btnAtamaSil_Click;
            // 
            // btnAtamaDuzenle
            // 
            btnAtamaDuzenle.Location = new Point(9, 22);
            btnAtamaDuzenle.Name = "btnAtamaDuzenle";
            btnAtamaDuzenle.Size = new Size(137, 39);
            btnAtamaDuzenle.TabIndex = 0;
            btnAtamaDuzenle.Text = "Atamayı Düzenle";
            btnAtamaDuzenle.UseVisualStyleBackColor = true;
            btnAtamaDuzenle.Click += btnAtamaDuzenle_Click;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Ogrenci";
            Column1.HeaderText = "Öğrenci";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "DersKodu";
            Column5.HeaderText = "Ders Kodu";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Ders";
            Column2.HeaderText = "Aldığı Ders";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Donem";
            Column3.HeaderText = "Aldığı Dönem";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "HarfNotu";
            Column4.HeaderText = "Harf Notu";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "DersKredi";
            Column6.HeaderText = "Kredisi";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Puan";
            Column7.HeaderText = "Puan";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            // 
            // DersAtamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 450);
            Controls.Add(groupBox2);
            Controls.Add(dgvAtanan);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DersAtamaForm";
            ShowIcon = false;
            Text = "Öğrenciye Not Atama İşlemleri";
            WindowState = FormWindowState.Maximized;
            Load += DersAtamaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtanan).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbOgrenciler;
        private Label label2;
        private Label label1;
        private Button btnAtamaYap;
        private ComboBox cmbHarfNotlari;
        private Label label4;
        private ComboBox cmbDonemler;
        private Label label3;
        private ComboBox cmbDersAdlari;
        private DataGridView dgvAtanan;
        private GroupBox groupBox2;
        private Button btnAtamaSil;
        private Button btnAtamaDuzenle;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}