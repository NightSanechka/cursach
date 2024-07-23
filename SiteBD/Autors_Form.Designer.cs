namespace SiteBD
{
    partial class Autors_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonSiteAutors = new System.Windows.Forms.Button();
            this.buttonThems = new System.Windows.Forms.Button();
            this.buttonUpdating = new System.Windows.Forms.Button();
            this.buttonWebPageInfo = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(623, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(259, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация об авторах сайта";
            // 
            // buttonStaff
            // 
            this.buttonStaff.Location = new System.Drawing.Point(54, 311);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(125, 23);
            this.buttonStaff.TabIndex = 2;
            this.buttonStaff.Text = "Сотрудники ";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonSiteAutors
            // 
            this.buttonSiteAutors.Location = new System.Drawing.Point(208, 311);
            this.buttonSiteAutors.Name = "buttonSiteAutors";
            this.buttonSiteAutors.Size = new System.Drawing.Size(125, 23);
            this.buttonSiteAutors.TabIndex = 3;
            this.buttonSiteAutors.Text = "Сайты и авторы";
            this.buttonSiteAutors.UseVisualStyleBackColor = true;
            this.buttonSiteAutors.Click += new System.EventHandler(this.buttonSiteAutors_Click);
            // 
            // buttonThems
            // 
            this.buttonThems.Location = new System.Drawing.Point(355, 311);
            this.buttonThems.Name = "buttonThems";
            this.buttonThems.Size = new System.Drawing.Size(125, 23);
            this.buttonThems.TabIndex = 4;
            this.buttonThems.Text = "Сайты и темы";
            this.buttonThems.UseVisualStyleBackColor = true;
            this.buttonThems.Click += new System.EventHandler(this.buttonThems_Click);
            // 
            // buttonUpdating
            // 
            this.buttonUpdating.Location = new System.Drawing.Point(500, 311);
            this.buttonUpdating.Name = "buttonUpdating";
            this.buttonUpdating.Size = new System.Drawing.Size(125, 23);
            this.buttonUpdating.TabIndex = 5;
            this.buttonUpdating.Text = "Обновления сайтов";
            this.buttonUpdating.UseVisualStyleBackColor = true;
            this.buttonUpdating.Click += new System.EventHandler(this.buttonUpdating_Click);
            // 
            // buttonWebPageInfo
            // 
            this.buttonWebPageInfo.Location = new System.Drawing.Point(643, 311);
            this.buttonWebPageInfo.Name = "buttonWebPageInfo";
            this.buttonWebPageInfo.Size = new System.Drawing.Size(145, 23);
            this.buttonWebPageInfo.TabIndex = 6;
            this.buttonWebPageInfo.Text = "Информация о страницах";
            this.buttonWebPageInfo.UseVisualStyleBackColor = true;
            this.buttonWebPageInfo.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(704, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Autors_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonWebPageInfo);
            this.Controls.Add(this.buttonUpdating);
            this.Controls.Add(this.buttonThems);
            this.Controls.Add(this.buttonSiteAutors);
            this.Controls.Add(this.buttonStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Autors_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Autors_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonSiteAutors;
        private System.Windows.Forms.Button buttonThems;
        private System.Windows.Forms.Button buttonUpdating;
        private System.Windows.Forms.Button buttonWebPageInfo;
        private System.Windows.Forms.Button buttonBack;
    }
}