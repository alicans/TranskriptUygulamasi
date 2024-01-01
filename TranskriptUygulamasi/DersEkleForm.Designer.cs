namespace TranskriptUygulamasi
{
    partial class DersEkleForm
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
            nudDersKredi = new NumericUpDown();
            label3 = new Label();
            txtDersAdi = new TextBox();
            label2 = new Label();
            txtDersKodu = new TextBox();
            label1 = new Label();
            btnDersEkle = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            dgvDersler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDersKredi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudDersKredi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDersAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDersKodu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDersEkle);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 161);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Bilgileri";
            // 
            // nudDersKredi
            // 
            nudDersKredi.DecimalPlaces = 1;
            nudDersKredi.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudDersKredi.Location = new Point(151, 81);
            nudDersKredi.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            nudDersKredi.Name = "nudDersKredi";
            nudDersKredi.Size = new Size(191, 23);
            nudDersKredi.TabIndex = 2;
            nudDersKredi.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 83);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "Dersin Kredisi:";
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(151, 51);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(191, 23);
            txtDersAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 54);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Ders Adı:";
            // 
            // txtDersKodu
            // 
            txtDersKodu.Location = new Point(151, 22);
            txtDersKodu.Name = "txtDersKodu";
            txtDersKodu.Size = new Size(191, 23);
            txtDersKodu.TabIndex = 0;
            txtDersKodu.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 6;
            label1.Text = "Ders Kodu:";
            // 
            // btnDersEkle
            // 
            btnDersEkle.Location = new Point(21, 110);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(321, 42);
            btnDersEkle.TabIndex = 3;
            btnDersEkle.Text = "Ders Ekle >>";
            btnDersEkle.UseVisualStyleBackColor = true;
            btnDersEkle.Click += btnDersEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(6, 22);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(150, 50);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "Seçileni Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.ForeColor = Color.Red;
            btnSil.Location = new Point(200, 22);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 50);
            btnSil.TabIndex = 5;
            btnSil.Text = "Seçileni Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvDersler
            // 
            dgvDersler.AllowUserToAddRows = false;
            dgvDersler.AllowUserToDeleteRows = false;
            dgvDersler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDersler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvDersler.Location = new Point(374, 12);
            dgvDersler.MultiSelect = false;
            dgvDersler.Name = "dgvDersler";
            dgvDersler.ReadOnly = true;
            dgvDersler.RowHeadersVisible = false;
            dgvDersler.RowTemplate.Height = 25;
            dgvDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDersler.ShowEditingIcon = false;
            dgvDersler.Size = new Size(414, 344);
            dgvDersler.TabIndex = 0;
            dgvDersler.CellMouseClick += dgvDersler_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Kodu";
            Column1.HeaderText = "Ders Kodu";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Adi";
            Column2.HeaderText = "Ders Adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Kredi";
            Column3.HeaderText = "Dersin Kredisi";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnDuzenle);
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 85);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veri İşlemleri";
            // 
            // DersEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 448);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvDersler);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DersEkleForm";
            ShowIcon = false;
            Text = "Ders Ekleme İşlemleri";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDersKredi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDuzenle;
        private Label label3;
        private TextBox txtDersAdi;
        private Label label2;
        private TextBox txtDersKodu;
        private Button btnSil;
        private Label label1;
        private Button btnDersEkle;
        private DataGridView dgvDersler;
        private NumericUpDown nudDersKredi;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox2;
    }
}