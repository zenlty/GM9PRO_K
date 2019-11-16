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
            this.tab2 = new System.Windows.Forms.TabPage();
            this.grp_detecter = new XanderUI.XUICustomGroupbox();
            this.detecterbanner = new XanderUI.XUISuperButton();
            this.log = new iTalk.iTalk_RichTextBox();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            this.combo_oem = new iTalk.iTalk_ComboBox();
            this.btn_oem = new iTalk.iTalk_Button_1();
            this.iTalk_Button_12 = new iTalk.iTalk_Button_1();
            this.iTalk_ComboBox1 = new iTalk.iTalk_ComboBox();
            this.iTalk_RadioButton1 = new iTalk.iTalk_RadioButton();
            this.iTalk_RadioButton2 = new iTalk.iTalk_RadioButton();
            this.iTalk_Button_13 = new iTalk.iTalk_Button_1();
            this.iTalk_Button_14 = new iTalk.iTalk_Button_1();
            this.progress_xml = new System.Windows.Forms.ProgressBar();
            this.iTalk_ComboBox2 = new iTalk.iTalk_ComboBox();
            this.iTalk_Button_15 = new iTalk.iTalk_Button_1();
            this.iTalk_Button_16 = new iTalk.iTalk_Button_1();
            this.iTalk_ComboBox3 = new iTalk.iTalk_ComboBox();
            this.form.WorkingArea.SuspendLayout();
            this.form.SuspendLayout();
            this.tab.SuspendLayout();
            this.tab1.SuspendLayout();
            this.grp_detecter.SuspendLayout();
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
            this.form.WorkingArea.Controls.Add(this.log);
            this.form.WorkingArea.Controls.Add(this.tab);
            this.form.WorkingArea.Controls.Add(this.grp_detecter);
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
            this.tab1.Controls.Add(this.iTalk_Button_16);
            this.tab1.Controls.Add(this.iTalk_ComboBox3);
            this.tab1.Controls.Add(this.iTalk_Button_15);
            this.tab1.Controls.Add(this.iTalk_ComboBox2);
            this.tab1.Controls.Add(this.progress_xml);
            this.tab1.Controls.Add(this.iTalk_Button_14);
            this.tab1.Controls.Add(this.iTalk_Button_13);
            this.tab1.Controls.Add(this.iTalk_RadioButton2);
            this.tab1.Controls.Add(this.iTalk_RadioButton1);
            this.tab1.Controls.Add(this.iTalk_Button_12);
            this.tab1.Controls.Add(this.iTalk_ComboBox1);
            this.tab1.Controls.Add(this.btn_oem);
            this.tab1.Controls.Add(this.combo_oem);
            this.tab1.Controls.Add(this.iTalk_Button_11);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(323, 228);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Tools";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(323, 228);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Root Tools";
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
            this.grp_detecter.Text = "GM 9 PRO Device Detecter";
            this.grp_detecter.TextColor = System.Drawing.Color.Brown;
            // 
            // detecterbanner
            // 
            this.detecterbanner.BackgroundColor = System.Drawing.Color.Brown;
            this.detecterbanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.detecterbanner.ButtonImage = ((System.Drawing.Image)(resources.GetObject("detecterbanner.ButtonImage")));
            this.detecterbanner.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.detecterbanner.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.detecterbanner.ButtonText = "GM 9 PRO Not Detected";
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
            this.log.Font = new System.Drawing.Font("Tahoma", 10F);
            this.log.ForeColor = System.Drawing.Color.DimGray;
            this.log.Location = new System.Drawing.Point(334, 28);
            this.log.Name = "log";
            this.log.ReadOnly = false;
            this.log.Size = new System.Drawing.Size(178, 228);
            this.log.TabIndex = 0;
            this.log.WordWrap = true;
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(5, 33);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(311, 27);
            this.iTalk_Button_11.TabIndex = 0;
            this.iTalk_Button_11.Text = "Read Informations";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
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
            "Unlock Bootloader",
            "Lock Bootloader"});
            this.combo_oem.Location = new System.Drawing.Point(6, 66);
            this.combo_oem.Name = "combo_oem";
            this.combo_oem.Size = new System.Drawing.Size(245, 26);
            this.combo_oem.StartIndex = 0;
            this.combo_oem.TabIndex = 1;
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
            this.btn_oem.Text = "Set";
            this.btn_oem.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // iTalk_Button_12
            // 
            this.iTalk_Button_12.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_12.Image = null;
            this.iTalk_Button_12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_12.Location = new System.Drawing.Point(257, 98);
            this.iTalk_Button_12.Name = "iTalk_Button_12";
            this.iTalk_Button_12.Size = new System.Drawing.Size(56, 26);
            this.iTalk_Button_12.TabIndex = 4;
            this.iTalk_Button_12.Text = "Flash";
            this.iTalk_Button_12.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // iTalk_ComboBox1
            // 
            this.iTalk_ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.iTalk_ComboBox1.DropDownHeight = 100;
            this.iTalk_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iTalk_ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iTalk_ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ComboBox1.FormattingEnabled = true;
            this.iTalk_ComboBox1.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.iTalk_ComboBox1.IntegralHeight = false;
            this.iTalk_ComboBox1.ItemHeight = 20;
            this.iTalk_ComboBox1.Items.AddRange(new object[] {
            "Android 8.1 Oreo Stock Rom",
            "Android 8.1 Oreo Stock Rom (Root)",
            "Android 9.0 Pie Stock Rom",
            "Android 9.0 Pie Stock Rom (Root)",
            "Generic System Image Roms"});
            this.iTalk_ComboBox1.Location = new System.Drawing.Point(6, 98);
            this.iTalk_ComboBox1.Name = "iTalk_ComboBox1";
            this.iTalk_ComboBox1.Size = new System.Drawing.Size(245, 26);
            this.iTalk_ComboBox1.StartIndex = 0;
            this.iTalk_ComboBox1.TabIndex = 3;
            // 
            // iTalk_RadioButton1
            // 
            this.iTalk_RadioButton1.Checked = false;
            this.iTalk_RadioButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_RadioButton1.Location = new System.Drawing.Point(77, 12);
            this.iTalk_RadioButton1.Name = "iTalk_RadioButton1";
            this.iTalk_RadioButton1.Size = new System.Drawing.Size(80, 15);
            this.iTalk_RadioButton1.TabIndex = 5;
            this.iTalk_RadioButton1.Text = "Single Sim";
            // 
            // iTalk_RadioButton2
            // 
            this.iTalk_RadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_RadioButton2.Checked = false;
            this.iTalk_RadioButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_RadioButton2.Location = new System.Drawing.Point(163, 12);
            this.iTalk_RadioButton2.Name = "iTalk_RadioButton2";
            this.iTalk_RadioButton2.Size = new System.Drawing.Size(75, 15);
            this.iTalk_RadioButton2.TabIndex = 6;
            this.iTalk_RadioButton2.Text = "Dual Sim";
            // 
            // iTalk_Button_13
            // 
            this.iTalk_Button_13.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_13.Image = null;
            this.iTalk_Button_13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_13.Location = new System.Drawing.Point(6, 130);
            this.iTalk_Button_13.Name = "iTalk_Button_13";
            this.iTalk_Button_13.Size = new System.Drawing.Size(96, 26);
            this.iTalk_Button_13.TabIndex = 7;
            this.iTalk_Button_13.Text = "Select XML";
            this.iTalk_Button_13.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // iTalk_Button_14
            // 
            this.iTalk_Button_14.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_14.Image = null;
            this.iTalk_Button_14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_14.Location = new System.Drawing.Point(257, 130);
            this.iTalk_Button_14.Name = "iTalk_Button_14";
            this.iTalk_Button_14.Size = new System.Drawing.Size(56, 26);
            this.iTalk_Button_14.TabIndex = 9;
            this.iTalk_Button_14.Text = "Flash";
            this.iTalk_Button_14.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // progress_xml
            // 
            this.progress_xml.Location = new System.Drawing.Point(108, 130);
            this.progress_xml.Name = "progress_xml";
            this.progress_xml.Size = new System.Drawing.Size(143, 26);
            this.progress_xml.TabIndex = 10;
            // 
            // iTalk_ComboBox2
            // 
            this.iTalk_ComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.iTalk_ComboBox2.DropDownHeight = 100;
            this.iTalk_ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iTalk_ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iTalk_ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ComboBox2.FormattingEnabled = true;
            this.iTalk_ComboBox2.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.iTalk_ComboBox2.IntegralHeight = false;
            this.iTalk_ComboBox2.ItemHeight = 20;
            this.iTalk_ComboBox2.Items.AddRange(new object[] {
            "Dialer",
            "VoLTE (Some Roms)",
            "Dialer Sound",
            "Always On Display",
            "Internal Storage",
            "Google Play Services"});
            this.iTalk_ComboBox2.Location = new System.Drawing.Point(6, 162);
            this.iTalk_ComboBox2.Name = "iTalk_ComboBox2";
            this.iTalk_ComboBox2.Size = new System.Drawing.Size(245, 26);
            this.iTalk_ComboBox2.StartIndex = 0;
            this.iTalk_ComboBox2.TabIndex = 11;
            // 
            // iTalk_Button_15
            // 
            this.iTalk_Button_15.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_15.Image = null;
            this.iTalk_Button_15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_15.Location = new System.Drawing.Point(257, 162);
            this.iTalk_Button_15.Name = "iTalk_Button_15";
            this.iTalk_Button_15.Size = new System.Drawing.Size(56, 26);
            this.iTalk_Button_15.TabIndex = 12;
            this.iTalk_Button_15.Text = "Fix";
            this.iTalk_Button_15.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // iTalk_Button_16
            // 
            this.iTalk_Button_16.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_16.Image = null;
            this.iTalk_Button_16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_16.Location = new System.Drawing.Point(257, 194);
            this.iTalk_Button_16.Name = "iTalk_Button_16";
            this.iTalk_Button_16.Size = new System.Drawing.Size(56, 26);
            this.iTalk_Button_16.TabIndex = 14;
            this.iTalk_Button_16.Text = "Ok";
            this.iTalk_Button_16.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // iTalk_ComboBox3
            // 
            this.iTalk_ComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.iTalk_ComboBox3.DropDownHeight = 100;
            this.iTalk_ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iTalk_ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iTalk_ComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_ComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ComboBox3.FormattingEnabled = true;
            this.iTalk_ComboBox3.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.iTalk_ComboBox3.IntegralHeight = false;
            this.iTalk_ComboBox3.ItemHeight = 20;
            this.iTalk_ComboBox3.Items.AddRange(new object[] {
            "Reboot Normal",
            "Reboot Recovery",
            "Reboot Bootloader"});
            this.iTalk_ComboBox3.Location = new System.Drawing.Point(5, 194);
            this.iTalk_ComboBox3.Name = "iTalk_ComboBox3";
            this.iTalk_ComboBox3.Size = new System.Drawing.Size(245, 26);
            this.iTalk_ComboBox3.StartIndex = 0;
            this.iTalk_ComboBox3.TabIndex = 13;
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
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign form;
        private XanderUI.XUICustomGroupbox grp_detecter;
        private XanderUI.XUISuperButton detecterbanner;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private iTalk.iTalk_RichTextBox log;
        private iTalk.iTalk_RadioButton iTalk_RadioButton2;
        private iTalk.iTalk_RadioButton iTalk_RadioButton1;
        private iTalk.iTalk_Button_1 iTalk_Button_12;
        private iTalk.iTalk_ComboBox iTalk_ComboBox1;
        private iTalk.iTalk_Button_1 btn_oem;
        private iTalk.iTalk_ComboBox combo_oem;
        private iTalk.iTalk_Button_1 iTalk_Button_11;
        private iTalk.iTalk_Button_1 iTalk_Button_16;
        private iTalk.iTalk_ComboBox iTalk_ComboBox3;
        private iTalk.iTalk_Button_1 iTalk_Button_15;
        private iTalk.iTalk_ComboBox iTalk_ComboBox2;
        private System.Windows.Forms.ProgressBar progress_xml;
        private iTalk.iTalk_Button_1 iTalk_Button_14;
        private iTalk.iTalk_Button_1 iTalk_Button_13;
    }
}

