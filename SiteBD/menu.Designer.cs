namespace SiteBD
{
    partial class menu
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
            this.buttonSiteInfo = new System.Windows.Forms.Button();
            this.buttonStaffInfo = new System.Windows.Forms.Button();
            this.buttonIPSite = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSiteInfo
            // 
            this.buttonSiteInfo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSiteInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSiteInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSiteInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonSiteInfo.Location = new System.Drawing.Point(88, 120);
            this.buttonSiteInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSiteInfo.Name = "buttonSiteInfo";
            this.buttonSiteInfo.Size = new System.Drawing.Size(136, 46);
            this.buttonSiteInfo.TabIndex = 0;
            this.buttonSiteInfo.Text = "Информация о сайтах";
            this.buttonSiteInfo.UseVisualStyleBackColor = false;
            this.buttonSiteInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStaffInfo
            // 
            this.buttonStaffInfo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonStaffInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStaffInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStaffInfo.Location = new System.Drawing.Point(401, 120);
            this.buttonStaffInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStaffInfo.Name = "buttonStaffInfo";
            this.buttonStaffInfo.Size = new System.Drawing.Size(136, 46);
            this.buttonStaffInfo.TabIndex = 1;
            this.buttonStaffInfo.Text = "Информация об авторах сайта";
            this.buttonStaffInfo.UseVisualStyleBackColor = false;
            this.buttonStaffInfo.Click += new System.EventHandler(this.buttonStaffInfo_Click);
            // 
            // buttonIPSite
            // 
            this.buttonIPSite.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonIPSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIPSite.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIPSite.Location = new System.Drawing.Point(710, 120);
            this.buttonIPSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonIPSite.Name = "buttonIPSite";
            this.buttonIPSite.Size = new System.Drawing.Size(136, 46);
            this.buttonIPSite.TabIndex = 2;
            this.buttonIPSite.Text = "Количество сайтов у автора";
            this.buttonIPSite.UseVisualStyleBackColor = false;
            this.buttonIPSite.Click += new System.EventHandler(this.buttonIPSite_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Info;
            this.buttonExit.Location = new System.Drawing.Point(804, 455);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(95, 30);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(88, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Количество тем у сайта";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonIPSite);
            this.Controls.Add(this.buttonStaffInfo);
            this.Controls.Add(this.buttonSiteInfo);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSiteInfo;
        private System.Windows.Forms.Button buttonStaffInfo;
        private System.Windows.Forms.Button buttonIPSite;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
    }
}