namespace GM9PRO_Kit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.form = new XanderUI.XUIFormDesign();
            this.tab = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btn_reboot = new iTalk.iTalk_Button_1();
            this.combo_reboot = new iTalk.iTalk_ComboBox();
            this.btn_fix = new iTalk.iTalk_Button_1();
            this.combo_fix = new iTalk.iTalk_ComboBox();
            this.progress_xml = new System.Windows.Forms.ProgressBar();
            this.btn_xmlflash = new iTalk.iTalk_Button_1();
            this.btn_xml = new iTalk.iTalk_Button_1();
            this.rbtn_dual = new iTalk.iTalk_RadioButton();
            this.rbnt_single = new iTalk.iTalk_RadioButton();
            this.btn_flash = new iTalk.iTalk_Button_1();
            this.combo_rom = new iTalk.iTalk_ComboBox();
            this.btn_oem = new iTalk.iTalk_Button_1();
            this.combo_oem = new iTalk.iTalk_ComboBox();
            this.btn_read = new iTalk.iTalk_Button_1();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.grp_detecter = new XanderUI.XUICustomGroupbox();
            this.detecterbanner = new XanderUI.XUISuperButton();
            this.log = new iTalk.iTalk_RichTextBox();
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.form.WorkingArea.SuspendLayout();
            this.form.SuspendLayout();
            this.tab.SuspendLayout();
            this.tab1.SuspendLayout();
            this.grp_detecter.SuspendLayout();
            this.iTalk_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form
            // 
            this.form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.ExitApplication = true;
            this.form.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.form.Location = new System.Drawing.Point(0, 0);
            this.form.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.form.MaterialForeColor = System.Drawing.Color.White;
            this.form.Name = "form";
            this.form.ShowMaximize = false;
            this.form.ShowMinimize = true;
            this.form.Size = new System.Drawing.Size(517, 342);
            this.form.TabIndex = 0;
            this.form.TitleText = "GM 9 PRO KIT";
            // 
            // form.WorkingArea
            // 
            this.form.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.form.WorkingArea.Controls.Add(this.iTalk_GroupBox1);
            this.form.WorkingArea.Controls.Add(this.tab);
            this.form.WorkingArea.Controls.Add(this.grp_detecter);
            this.form.WorkingArea.Controls.Add(this.log);
            this.form.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.form.WorkingArea.Name = "WorkingArea";
            this.form.WorkingArea.Size = new System.Drawing.Size(517, 303);
            this.form.WorkingArea.TabIndex = 0;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab1);
            this.tab.Controls.Add(this.tab2);
            this.tab.Location = new System.Drawing.Point(3, 6);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(331, 254);
            this.tab.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btn_reboot);
            this.tab1.Controls.Add(this.combo_reboot);
            this.tab1.Controls.Add(this.btn_fix);
            this.tab1.Controls.Add(this.combo_fix);
            this.tab1.Controls.Add(this.progress_xml);
            this.tab1.Controls.Add(this.btn_xmlflash);
            this.tab1.Controls.Add(this.btn_xml);
            this.tab1.Controls.Add(this.rbtn_dual);
            this.tab1.Controls.Add(this.rbnt_single);
            this.tab1.Controls.Add(this.btn_flash);
            this.tab1.Controls.Add(this.combo_rom);
            this.tab1.Controls.Add(this.btn_oem);
            this.tab1.Controls.Add(this.combo_oem);
            this.tab1.Controls.Add(this.btn_read);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(323, 228);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Araçlar";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // btn_reboot
            // 
            this.btn_reboot.BackColor = System.Drawing.Color.Transparent;
            this.btn_reboot.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_reboot.Image = null;
            this.btn_reboot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reboot.Location = new System.Drawing.Point(257, 194);
            this.btn_reboot.Name = "btn_reboot";
            this.btn_reboot.Size = new System.Drawing.Size(56, 26);
            this.btn_reboot.TabIndex = 14;
            this.btn_reboot.Text = "Yap";
            this.btn_reboot.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // combo_reboot
            // 
            this.combo_reboot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combo_reboot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_reboot.DropDownHeight = 100;
            this.combo_reboot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_reboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_reboot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_reboot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combo_reboot.FormattingEnabled = true;
            this.combo_reboot.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.combo_reboot.IntegralHeight = false;
            this.combo_reboot.ItemHeight = 20;
            this.combo_reboot.Items.AddRange(new object[] {
            "Normal Yeniden Başlatma",
            "Kurtarıcı Yeniden Başlatma",
            "ÖnYükleyici Yeniden Başlatma"});
            this.combo_reboot.Location = new System.Drawing.Point(5, 194);
            this.combo_reboot.Name = "combo_reboot";
            this.combo_reboot.Size = new System.Drawing.Size(245, 26);
            this.combo_reboot.StartIndex = 0;
            this.combo_reboot.TabIndex = 13;
            // 
            // btn_fix
            // 
            this.btn_fix.BackColor = System.Drawing.Color.Transparent;
            this.btn_fix.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_fix.Image = null;
            this.btn_fix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fix.Location = new System.Drawing.Point(257, 162);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(56, 26);
            this.btn_fix.TabIndex = 12;
            this.btn_fix.Text = "Düzelt";
            this.btn_fix.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // combo_fix
            // 
            this.combo_fix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combo_fix.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_fix.DropDownHeight = 100;
            this.combo_fix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_fix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_fix.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_fix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combo_fix.FormattingEnabled = true;
            this.combo_fix.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.combo_fix.IntegralHeight = false;
            this.combo_fix.ItemHeight = 20;
            this.combo_fix.Items.AddRange(new object[] {
            "Ahize Sesi",
            "VoLTE (Bazı Romlar)",
            "Arama Sesi",
            "Her Zaman Açık Ekran",
            "Dahili Depolama",
            "Google Play Servisleri"});
            this.combo_fix.Location = new System.Drawing.Point(6, 162);
            this.combo_fix.Name = "combo_fix";
            this.combo_fix.Size = new System.Drawing.Size(245, 26);
            this.combo_fix.StartIndex = 0;
            this.combo_fix.TabIndex = 11;
            // 
            // progress_xml
            // 
            this.progress_xml.Location = new System.Drawing.Point(108, 130);
            this.progress_xml.Name = "progress_xml";
            this.progress_xml.Size = new System.Drawing.Size(143, 26);
            this.progress_xml.TabIndex = 10;
            // 
            // btn_xmlflash
            // 
            this.btn_xmlflash.BackColor = System.Drawing.Color.Transparent;
            this.btn_xmlflash.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_xmlflash.Image = null;
            this.btn_xmlflash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xmlflash.Location = new System.Drawing.Point(257, 130);
            this.btn_xmlflash.Name = "btn_xmlflash";
            this.btn_xmlflash.Size = new System.Drawing.Size(56, 26);
            this.btn_xmlflash.TabIndex = 9;
            this.btn_xmlflash.Text = "Yükle";
            this.btn_xmlflash.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_xml
            // 
            this.btn_xml.BackColor = System.Drawing.Color.Transparent;
            this.btn_xml.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_xml.Image = null;
            this.btn_xml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xml.Location = new System.Drawing.Point(6, 130);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(96, 26);
            this.btn_xml.TabIndex = 7;
            this.btn_xml.Text = "XML Seç";
            this.btn_xml.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // rbtn_dual
            // 
            this.rbtn_dual.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_dual.Checked = false;
            this.rbtn_dual.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbtn_dual.Location = new System.Drawing.Point(163, 12);
            this.rbtn_dual.Name = "rbtn_dual";
            this.rbtn_dual.Size = new System.Drawing.Size(75, 15);
            this.rbtn_dual.TabIndex = 6;
            this.rbtn_dual.Text = "Çift Sim";
            // 
            // rbnt_single
            // 
            this.rbnt_single.BackColor = System.Drawing.Color.Transparent;
            this.rbnt_single.Checked = true;
            this.rbnt_single.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbnt_single.Location = new System.Drawing.Point(77, 12);
            this.rbnt_single.Name = "rbnt_single";
            this.rbnt_single.Size = new System.Drawing.Size(80, 15);
            this.rbnt_single.TabIndex = 5;
            this.rbnt_single.Text = "Tek Sim";
            // 
            // btn_flash
            // 
            this.btn_flash.BackColor = System.Drawing.Color.Transparent;
            this.btn_flash.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_flash.Image = null;
            this.btn_flash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_flash.Location = new System.Drawing.Point(257, 98);
            this.btn_flash.Name = "btn_flash";
            this.btn_flash.Size = new System.Drawing.Size(56, 26);
            this.btn_flash.TabIndex = 4;
            this.btn_flash.Text = "Yükle";
            this.btn_flash.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // combo_rom
            // 
            this.combo_rom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combo_rom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_rom.DropDownHeight = 100;
            this.combo_rom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_rom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_rom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_rom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combo_rom.FormattingEnabled = true;
            this.combo_rom.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.combo_rom.IntegralHeight = false;
            this.combo_rom.ItemHeight = 20;
            this.combo_rom.Items.AddRange(new object[] {
            "Android 8.1 Oreo Orijinal Rom",
            "Android 8.1 Oreo Orijinal Rom (Root)",
            "Android 9.0 Pie Orijinal Rom",
            "Android 9.0 Pie Orijinal Rom (Root)",
            "Genel Sistem Imaj Romları"});
            this.combo_rom.Location = new System.Drawing.Point(6, 98);
            this.combo_rom.Name = "combo_rom";
            this.combo_rom.Size = new System.Drawing.Size(245, 26);
            this.combo_rom.StartIndex = 0;
            this.combo_rom.TabIndex = 3;
            // 
            // btn_oem
            // 
            this.btn_oem.BackColor = System.Drawing.Color.Transparent;
            this.btn_oem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_oem.Image = null;
            this.btn_oem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_oem.Location = new System.Drawing.Point(257, 66);
            this.btn_oem.Name = "btn_oem";
            this.btn_oem.Size = new System.Drawing.Size(56, 26);
            this.btn_oem.TabIndex = 2;
            this.btn_oem.Text = "Ayarla";
            this.btn_oem.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // combo_oem
            // 
            this.combo_oem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combo_oem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_oem.DropDownHeight = 100;
            this.combo_oem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_oem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_oem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_oem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combo_oem.FormattingEnabled = true;
            this.combo_oem.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.combo_oem.IntegralHeight = false;
            this.combo_oem.ItemHeight = 20;
            this.combo_oem.Items.AddRange(new object[] {
            "ÖnYükleyici Kilidini Aç",
            "ÖnYükleyici Kilidini Kapat"});
            this.combo_oem.Location = new System.Drawing.Point(6, 66);
            this.combo_oem.Name = "combo_oem";
            this.combo_oem.Size = new System.Drawing.Size(245, 26);
            this.combo_oem.StartIndex = 0;
            this.combo_oem.TabIndex = 1;
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.Color.Transparent;
            this.btn_read.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_read.Image = null;
            this.btn_read.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_read.Location = new System.Drawing.Point(5, 33);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(311, 27);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "Bilgileri Oku";
            this.btn_read.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(323, 228);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Rootlu Araçlar";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // grp_detecter
            // 
            this.grp_detecter.BorderColor = System.Drawing.Color.Brown;
            this.grp_detecter.BorderWidth = 1;
            this.grp_detecter.Controls.Add(this.detecterbanner);
            this.grp_detecter.Location = new System.Drawing.Point(-2, 266);
            this.grp_detecter.Name = "grp_detecter";
            this.grp_detecter.ShowText = true;
            this.grp_detecter.Size = new System.Drawing.Size(528, 43);
            this.grp_detecter.TabIndex = 0;
            this.grp_detecter.TabStop = false;
            this.grp_detecter.Text = "GM 9 PRO Cihaz Algılayıcı";
            this.grp_detecter.TextColor = System.Drawing.Color.Brown;
            // 
            // detecterbanner
            // 
            this.detecterbanner.BackgroundColor = System.Drawing.Color.Black;
            this.detecterbanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.detecterbanner.ButtonImage = ((System.Drawing.Image)(resources.GetObject("detecterbanner.ButtonImage")));
            this.detecterbanner.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.detecterbanner.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.detecterbanner.ButtonText = "GM 9 PRO Algılanmadı";
            this.detecterbanner.CornerRadius = 5;
            this.detecterbanner.Enabled = false;
            this.detecterbanner.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.detecterbanner.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.detecterbanner.HoverTextColor = System.Drawing.Color.White;
            this.detecterbanner.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.detecterbanner.Location = new System.Drawing.Point(-30, 14);
            this.detecterbanner.Name = "detecterbanner";
            this.detecterbanner.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.detecterbanner.SelectedTextColor = System.Drawing.Color.White;
            this.detecterbanner.Size = new System.Drawing.Size(582, 24);
            this.detecterbanner.SuperSelected = false;
            this.detecterbanner.TabIndex = 2;
            this.detecterbanner.TextColor = System.Drawing.Color.White;
            this.detecterbanner.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // log
            // 
            this.log.AutoWordSelection = false;
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Enabled = false;
            this.log.Font = new System.Drawing.Font("Tahoma", 10F);
            this.log.ForeColor = System.Drawing.Color.DimGray;
            this.log.Location = new System.Drawing.Point(334, 28);
            this.log.Name = "log";
            this.log.ReadOnly = false;
            this.log.Size = new System.Drawing.Size(178, 140);
            this.log.TabIndex = 0;
            this.log.WordWrap = true;
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.progressBar1);
            this.iTalk_GroupBox1.Controls.Add(this.label2);
            this.iTalk_GroupBox1.Controls.Add(this.label1);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(334, 174);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(178, 82);
            this.iTalk_GroupBox1.TabIndex = 2;
            this.iTalk_GroupBox1.Text = "Yükleme";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(162, 26);
            this.progressBar1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "İndirilen : 0 MB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Boyut :  0 MB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 342);
            this.Controls.Add(this.form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GM 9 PRO KIT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.form.WorkingArea.ResumeLayout(false);
            this.form.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.grp_detecter.ResumeLayout(false);
            this.grp_detecter.PerformLayout();
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign form;
        private XanderUI.XUICustomGroupbox grp_detecter;
        private XanderUI.XUISuperButton detecterbanner;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private iTalk.iTalk_RadioButton rbtn_dual;
        private iTalk.iTalk_RadioButton rbnt_single;
        private iTalk.iTalk_Button_1 btn_flash;
        private iTalk.iTalk_ComboBox combo_rom;
        private iTalk.iTalk_Button_1 btn_oem;
        private iTalk.iTalk_ComboBox combo_oem;
        private iTalk.iTalk_Button_1 btn_read;
        private iTalk.iTalk_Button_1 btn_reboot;
        private iTalk.iTalk_ComboBox combo_reboot;
        private iTalk.iTalk_Button_1 btn_fix;
        private iTalk.iTalk_ComboBox combo_fix;
        private System.Windows.Forms.ProgressBar progress_xml;
        private iTalk.iTalk_Button_1 btn_xmlflash;
        private iTalk.iTalk_Button_1 btn_xml;
        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private iTalk.iTalk_RichTextBox log;
    }
}

