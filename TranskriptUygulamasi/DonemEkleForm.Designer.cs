namespace TranskriptUygulamasi
{
    partial class DonemEkleForm
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
            txtDonemNo = new TextBox();
            label2 = new Label();
            txtDonemAdi = new TextBox();
            label1 = new Label();
            btnDonemEkle = new Button();
            btnDonemDuzenle = new Button();
            btnDonemSil = new Button();
            dgvDonemler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonemler).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDonemNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDonemAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDonemEkle);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 132);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dönem Bilgileri";
            // 
            // txtDonemNo
            // 
            txtDonemNo.Location = new Point(151, 22);
            txtDonemNo.Name = "txtDonemNo";
            txtDonemNo.Size = new Size(191, 23);
            txtDonemNo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 25);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 5;
            label2.Text = "Dönem Numarası:";
            // 
            // txtDonemAdi
            // 
            txtDonemAdi.Location = new Point(151, 51);
            txtDonemAdi.Name = "txtDonemAdi";
            txtDonemAdi.Size = new Size(191, 23);
            txtDonemAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 54);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "Dönem Adı:";
            // 
            // btnDonemEkle
            // 
            btnDonemEkle.Location = new Point(21, 80);
            btnDonemEkle.Name = "btnDonemEkle";
            btnDonemEkle.Size = new Size(321, 42);
            btnDonemEkle.TabIndex = 2;
            btnDonemEkle.Text = "Dönem Ekle >>";
            btnDonemEkle.UseVisualStyleBackColor = true;
            btnDonemEkle.Click += btnDonemEkle_Click;
            // 
            // btnDonemDuzenle
            // 
            btnDonemDuzenle.Location = new Point(6, 22);
            btnDonemDuzenle.Name = "btnDonemDuzenle";
            btnDonemDuzenle.Size = new Size(150, 50);
            btnDonemDuzenle.TabIndex = 3;
            btnDonemDuzenle.Text = "Seçileni Düzenle";
            btnDonemDuzenle.UseVisualStyleBackColor = true;
            btnDonemDuzenle.Click += btnDonemDuzenle_Click;
            // 
            // btnDonemSil
            // 
            btnDonemSil.ForeColor = Color.Red;
            btnDonemSil.Location = new Point(200, 22);
            btnDonemSil.Name = "btnDonemSil";
            btnDonemSil.Size = new Size(150, 50);
            btnDonemSil.TabIndex = 4;
            btnDonemSil.Text = "Seçileni Sil";
            btnDonemSil.UseVisualStyleBackColor = true;
            btnDonemSil.Click += btnDonemSil_Click;
            // 
            // dgvDonemler
            // 
            dgvDonemler.AllowUserToAddRows = false;
            dgvDonemler.AllowUserToDeleteRows = false;
            dgvDonemler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDonemler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonemler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDonemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonemler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvDonemler.Location = new Point(374, 12);
            dgvDonemler.MultiSelect = false;
            dgvDonemler.Name = "dgvDonemler";
            dgvDonemler.ReadOnly = true;
            dgvDonemler.RowHeadersVisible = false;
            dgvDonemler.RowTemplate.Height = 25;
            dgvDonemler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonemler.ShowEditingIcon = false;
            dgvDonemler.Size = new Size(414, 344);
            dgvDonemler.TabIndex = 0;
            dgvDonemler.CellMouseClick += dgvDonemler_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "No";
            Column1.HeaderText = "Dönem Numarası";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Ad";
            Column2.HeaderText = "Dönem Adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDonemDuzenle);
            groupBox2.Controls.Add(btnDonemSil);
            groupBox2.Location = new Point(12, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 85);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veri İşlemleri";
            // 
            // DonemEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 448);
            Controls.Add(groupBox2);
            Controls.Add(dgvDonemler);
            Controls.Add(groupBox1);
            Name = "DonemEkleForm";
            ShowIcon = false;
            Text = "Dönem Ekleme İşlemleri";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonemler).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDonemDuzenle;
        private TextBox txtDonemNo;
        private Label label2;
        private TextBox txtDonemAdi;
        private Button btnDonemSil;
        private Label label1;
        private Button btnDonemEkle;
        private DataGridView dgvDonemler;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox groupBox2;
    }
}