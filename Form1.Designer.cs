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
            this.grp_detecter = new XanderUI.XUICustomGroupbox();
            this.detecterbanner = new XanderUI.XUISuperButton();
            this.form.WorkingArea.SuspendLayout();
            this.form.SuspendLayout();
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
            this.form.WorkingArea.Controls.Add(this.grp_detecter);
            this.form.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.form.WorkingArea.Name = "WorkingArea";
            this.form.WorkingArea.Size = new System.Drawing.Size(517, 303);
            this.form.WorkingArea.TabIndex = 0;
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
            this.form.WorkingArea.ResumeLayout(false);
            this.form.ResumeLayout(false);
            this.grp_detecter.ResumeLayout(false);
            this.grp_detecter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign form;
        private XanderUI.XUICustomGroupbox grp_detecter;
        private XanderUI.XUISuperButton detecterbanner;
    }
}

