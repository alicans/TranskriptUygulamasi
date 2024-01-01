namespace TranskriptUygulamasi
{
    partial class TranskriptForm
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
            label1 = new Label();
            cmbOgrenciSec = new ComboBox();
            pnlTranskript = new Panel();
            lblGno = new Label();
            label6 = new Label();
            lblDno = new Label();
            label5 = new Label();
            dgvTranskript = new DataGridView();
            lblSecilenDonem = new Label();
            label3 = new Label();
            btnTranskriptGoster = new Button();
            cmbDonemSec = new ComboBox();
            label2 = new Label();
            lblUyari = new Label();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            pnlTranskript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTranskript).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Seçiniz:";
            // 
            // cmbOgrenciSec
            // 
            cmbOgrenciSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgrenciSec.FormattingEnabled = true;
            cmbOgrenciSec.Location = new Point(109, 6);
            cmbOgrenciSec.Name = "cmbOgrenciSec";
            cmbOgrenciSec.Size = new Size(165, 23);
            cmbOgrenciSec.TabIndex = 1;
            // 
            // pnlTranskript
            // 
            pnlTranskript.Controls.Add(lblGno);
            pnlTranskript.Controls.Add(label6);
            pnlTranskript.Controls.Add(lblDno);
            pnlTranskript.Controls.Add(label5);
            pnlTranskript.Controls.Add(dgvTranskript);
            pnlTranskript.Controls.Add(lblSecilenDonem);
            pnlTranskript.Controls.Add(label3);
            pnlTranskript.Location = new Point(12, 35);
            pnlTranskript.Name = "pnlTranskript";
            pnlTranskript.Size = new Size(851, 423);
            pnlTranskript.TabIndex = 2;
            pnlTranskript.Visible = false;
            // 
            // lblGno
            // 
            lblGno.AutoSize = true;
            lblGno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblGno.Location = new Point(602, 379);
            lblGno.Name = "lblGno";
            lblGno.Size = new Size(0, 30);
            lblGno.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(532, 379);
            label6.Name = "label6";
            label6.Size = new Size(64, 30);
            label6.TabIndex = 5;
            label6.Text = "GNO:";
            // 
            // lblDno
            // 
            lblDno.AutoSize = true;
            lblDno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDno.Location = new Point(83, 379);
            lblDno.Name = "lblDno";
            lblDno.Size = new Size(0, 30);
            lblDno.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 379);
            label5.Name = "label5";
            label5.Size = new Size(65, 30);
            label5.TabIndex = 3;
            label5.Text = "DNO:";
            // 
            // dgvTranskript
            // 
            dgvTranskript.AllowUserToAddRows = false;
            dgvTranskript.AllowUserToDeleteRows = false;
            dgvTranskript.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTranskript.Columns.AddRange(new DataGridViewColumn[] { Column4, Column2, Column3, Column6, Column7, Column1, Column5 });
            dgvTranskript.Location = new Point(12, 46);
            dgvTranskript.Name = "dgvTranskript";
            dgvTranskript.ReadOnly = true;
            dgvTranskript.RowTemplate.Height = 25;
            dgvTranskript.Size = new Size(821, 320);
            dgvTranskript.TabIndex = 2;
            // 
            // lblSecilenDonem
            // 
            lblSecilenDonem.AutoSize = true;
            lblSecilenDonem.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSecilenDonem.Location = new Point(175, 13);
            lblSecilenDonem.Name = "lblSecilenDonem";
            lblSecilenDonem.Size = new Size(0, 30);
            lblSecilenDonem.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 13);
            label3.Name = "label3";
            label3.Size = new Size(157, 30);
            label3.TabIndex = 0;
            label3.Text = "Seçilen Dönem:";
            // 
            // btnTranskriptGoster
            // 
            btnTranskriptGoster.Location = new Point(544, 6);
            btnTranskriptGoster.Name = "btnTranskriptGoster";
            btnTranskriptGoster.Size = new Size(135, 23);
            btnTranskriptGoster.TabIndex = 3;
            btnTranskriptGoster.Text = "Transkript Göster";
            btnTranskriptGoster.UseVisualStyleBackColor = true;
            btnTranskriptGoster.Click += btnTranskriptGoster_Click;
            // 
            // cmbDonemSec
            // 
            cmbDonemSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonemSec.FormattingEnabled = true;
            cmbDonemSec.Location = new Point(377, 6);
            cmbDonemSec.Name = "cmbDonemSec";
            cmbDonemSec.Size = new Size(161, 23);
            cmbDonemSec.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "Dönem Seçiniz:";
            // 
            // lblUyari
            // 
            lblUyari.AutoSize = true;
            lblUyari.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUyari.Location = new Point(109, 127);
            lblUyari.Name = "lblUyari";
            lblUyari.Size = new Size(0, 37);
            lblUyari.TabIndex = 7;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Ders";
            Column4.HeaderText = "Ders Adı";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "DersKodu";
            Column2.HeaderText = "Ders Kodu";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "DersKredi";
            Column3.HeaderText = "Ders Kredisi";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "HarfNotu";
            Column6.HeaderText = "Harf Notu";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Puan";
            Column7.HeaderText = "Puan";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Ogrenci";
            Column1.HeaderText = "Öğrenci Adı";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Donem";
            Column5.HeaderText = "Dönem";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // TranskriptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 557);
            Controls.Add(lblUyari);
            Controls.Add(cmbDonemSec);
            Controls.Add(label2);
            Controls.Add(btnTranskriptGoster);
            Controls.Add(pnlTranskript);
            Controls.Add(cmbOgrenciSec);
            Controls.Add(label1);
            Name = "TranskriptForm";
            ShowIcon = false;
            Text = "Transkript";
            WindowState = FormWindowState.Maximized;
            Load += TranskriptForm_Load;
            pnlTranskript.ResumeLayout(false);
            pnlTranskript.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTranskript).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOgrenciSec;
        private Panel pnlTranskript;
        private Button btnTranskriptGoster;
        private ComboBox cmbDonemSec;
        private Label label2;
        private DataGridView dgvTranskript;
        private Label lblSecilenDonem;
        private Label label3;
        private Label lblGno;
        private Label label6;
        private Label lblDno;
        private Label label5;
        private Label lblUyari;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
    }
}