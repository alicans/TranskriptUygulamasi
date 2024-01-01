namespace TranskriptUygulamasi
{
    partial class OgrenciEkleForm
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
            txtOgrenciNumarasi = new TextBox();
            label3 = new Label();
            txtOgrenciSoyadi = new TextBox();
            label2 = new Label();
            txtOgrenciAdi = new TextBox();
            label1 = new Label();
            btnOgrenciEkle = new Button();
            btnOgrenciDuzenle = new Button();
            btnOgrenciSil = new Button();
            dgvOgrenciler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOgrenciNumarasi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtOgrenciSoyadi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtOgrenciAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnOgrenciEkle);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 160);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // txtOgrenciNumarasi
            // 
            txtOgrenciNumarasi.Location = new Point(151, 22);
            txtOgrenciNumarasi.Name = "txtOgrenciNumarasi";
            txtOgrenciNumarasi.Size = new Size(191, 23);
            txtOgrenciNumarasi.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 25);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 10;
            label3.Text = "Öğrenci Numarası:";
            // 
            // txtOgrenciSoyadi
            // 
            txtOgrenciSoyadi.Location = new Point(151, 80);
            txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            txtOgrenciSoyadi.Size = new Size(191, 23);
            txtOgrenciSoyadi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 83);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 7;
            label2.Text = "Öğrenci Soyadı:";
            // 
            // txtOgrenciAdi
            // 
            txtOgrenciAdi.Location = new Point(151, 51);
            txtOgrenciAdi.Name = "txtOgrenciAdi";
            txtOgrenciAdi.Size = new Size(191, 23);
            txtOgrenciAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 54);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = "Öğrenci Adı:";
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Location = new Point(21, 109);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(321, 42);
            btnOgrenciEkle.TabIndex = 3;
            btnOgrenciEkle.Text = "Öğrenci Ekle >>";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // btnOgrenciDuzenle
            // 
            btnOgrenciDuzenle.Location = new Point(6, 22);
            btnOgrenciDuzenle.Name = "btnOgrenciDuzenle";
            btnOgrenciDuzenle.Size = new Size(150, 50);
            btnOgrenciDuzenle.TabIndex = 4;
            btnOgrenciDuzenle.Text = "Seçileni Düzenle";
            btnOgrenciDuzenle.UseVisualStyleBackColor = true;
            btnOgrenciDuzenle.Click += btnOgrenciDuzenle_Click;
            // 
            // btnOgrenciSil
            // 
            btnOgrenciSil.ForeColor = Color.Red;
            btnOgrenciSil.Location = new Point(200, 22);
            btnOgrenciSil.Name = "btnOgrenciSil";
            btnOgrenciSil.Size = new Size(150, 50);
            btnOgrenciSil.TabIndex = 5;
            btnOgrenciSil.Text = "Seçileni Sil";
            btnOgrenciSil.UseVisualStyleBackColor = true;
            btnOgrenciSil.Click += btnOgrenciSil_Click;
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.AllowUserToAddRows = false;
            dgvOgrenciler.AllowUserToDeleteRows = false;
            dgvOgrenciler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgrenciler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvOgrenciler.Location = new Point(374, 12);
            dgvOgrenciler.MultiSelect = false;
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.ReadOnly = true;
            dgvOgrenciler.RowHeadersVisible = false;
            dgvOgrenciler.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvOgrenciler.RowTemplate.Height = 25;
            dgvOgrenciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenciler.ShowEditingIcon = false;
            dgvOgrenciler.Size = new Size(414, 344);
            dgvOgrenciler.TabIndex = 0;
            dgvOgrenciler.CellMouseClick += dgvOgrenciler_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Numara";
            Column1.HeaderText = "Öğrenci No";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Ad";
            Column2.HeaderText = "Öğrenci Adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Soyad";
            Column3.HeaderText = "Öğrenci Soyadı";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOgrenciDuzenle);
            groupBox2.Controls.Add(btnOgrenciSil);
            groupBox2.Location = new Point(12, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 83);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veri İşlemleri";
            // 
            // OgrenciEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(792, 448);
            Controls.Add(groupBox2);
            Controls.Add(dgvOgrenciler);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OgrenciEkleForm";
            ShowIcon = false;
            Text = "Öğrenci İşlemleri";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtOgrenciAdi;
        private Button btnOgrenciSil;
        private Label label1;
        private Button btnOgrenciEkle;
        private TextBox txtOgrenciSoyadi;
        private Label label2;
        private Button btnOgrenciDuzenle;
        private DataGridView dgvOgrenciler;
        private TextBox txtOgrenciNumarasi;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox2;
    }
}