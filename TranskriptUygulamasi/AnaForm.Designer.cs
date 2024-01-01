namespace TranskriptUygulamasi
{
    partial class AnaForm
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
            menuStrip1 = new MenuStrip();
            tsOgrenciIslemleri = new ToolStripMenuItem();
            tsmOgrenciTanimla = new ToolStripMenuItem();
            tsmNotAtama = new ToolStripMenuItem();
            tsDersIslemleri = new ToolStripMenuItem();
            tsmDersEkle = new ToolStripMenuItem();
            tsmDonemEkle = new ToolStripMenuItem();
            tsTranskriptIslemleri = new ToolStripMenuItem();
            tsmTranskript = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsOgrenciIslemleri, tsDersIslemleri, tsTranskriptIslemleri });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(932, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsOgrenciIslemleri
            // 
            tsOgrenciIslemleri.DropDownItems.AddRange(new ToolStripItem[] { tsmOgrenciTanimla, tsmNotAtama });
            tsOgrenciIslemleri.Name = "tsOgrenciIslemleri";
            tsOgrenciIslemleri.Size = new Size(108, 20);
            tsOgrenciIslemleri.Text = "Öğrenci İşlemleri";
            // 
            // tsmOgrenciTanimla
            // 
            tsmOgrenciTanimla.Name = "tsmOgrenciTanimla";
            tsmOgrenciTanimla.Size = new Size(236, 22);
            tsmOgrenciTanimla.Text = "Öğrenci Tanımlama İşlemleri";
            tsmOgrenciTanimla.Click += tsmOgrenciTanimla_Click;
            // 
            // tsmNotAtama
            // 
            tsmNotAtama.Name = "tsmNotAtama";
            tsmNotAtama.Size = new Size(236, 22);
            tsmNotAtama.Text = "Öğrenciye Not Atama İşlemleri";
            tsmNotAtama.Click += tsmNotAtama_Click;
            // 
            // tsDersIslemleri
            // 
            tsDersIslemleri.DropDownItems.AddRange(new ToolStripItem[] { tsmDersEkle, tsmDonemEkle });
            tsDersIslemleri.Name = "tsDersIslemleri";
            tsDersIslemleri.Size = new Size(89, 20);
            tsDersIslemleri.Text = "Ders İşlemleri";
            // 
            // tsmDersEkle
            // 
            tsmDersEkle.Name = "tsmDersEkle";
            tsmDersEkle.Size = new Size(137, 22);
            tsmDersEkle.Text = "Ders Ekle";
            tsmDersEkle.Click += tsmDersEkle_Click;
            // 
            // tsmDonemEkle
            // 
            tsmDonemEkle.Name = "tsmDonemEkle";
            tsmDonemEkle.Size = new Size(137, 22);
            tsmDonemEkle.Text = "Dönem Ekle";
            tsmDonemEkle.Click += tsmDonemEkle_Click;
            // 
            // tsTranskriptIslemleri
            // 
            tsTranskriptIslemleri.DropDownItems.AddRange(new ToolStripItem[] { tsmTranskript });
            tsTranskriptIslemleri.Name = "tsTranskriptIslemleri";
            tsTranskriptIslemleri.Size = new Size(117, 20);
            tsTranskriptIslemleri.Text = "Transkript İşlemleri";
            // 
            // tsmTranskript
            // 
            tsmTranskript.Name = "tsmTranskript";
            tsmTranskript.Size = new Size(180, 22);
            tsmTranskript.Text = "Transkript İzleme";
            tsmTranskript.Click += tsmTranskript_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 608);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            Text = "Öğrenci İşleri Otomasyonu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsOgrenciIslemleri;
        private ToolStripMenuItem tsmOgrenciTanimla;
        private ToolStripMenuItem tsDersIslemleri;
        private ToolStripMenuItem tsmNotAtama;
        private ToolStripMenuItem tsmDersEkle;
        private ToolStripMenuItem tsmDonemEkle;
        private ToolStripMenuItem tsTranskriptIslemleri;
        private ToolStripMenuItem tsmTranskript;
    }
}