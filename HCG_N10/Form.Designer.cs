
namespace HCG_N10
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.bt_sukien = new System.Windows.Forms.Button();
            this.bt_luat = new System.Windows.Forms.Button();
            this.bt_tuvan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_sukien
            // 
            this.bt_sukien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sukien.BackgroundImage")));
            this.bt_sukien.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_sukien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sukien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_sukien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_sukien.Location = new System.Drawing.Point(517, 284);
            this.bt_sukien.Name = "bt_sukien";
            this.bt_sukien.Size = new System.Drawing.Size(163, 80);
            this.bt_sukien.TabIndex = 0;
            this.bt_sukien.Text = "Sự kiện";
            this.bt_sukien.UseVisualStyleBackColor = true;
            this.bt_sukien.Click += new System.EventHandler(this.bt_sukien_Click);
            // 
            // bt_luat
            // 
            this.bt_luat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_luat.BackgroundImage")));
            this.bt_luat.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_luat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_luat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_luat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_luat.Location = new System.Drawing.Point(320, 181);
            this.bt_luat.Name = "bt_luat";
            this.bt_luat.Size = new System.Drawing.Size(157, 80);
            this.bt_luat.TabIndex = 1;
            this.bt_luat.Text = "Luật";
            this.bt_luat.UseVisualStyleBackColor = true;
            this.bt_luat.Click += new System.EventHandler(this.bt_luat_Click);
            // 
            // bt_tuvan
            // 
            this.bt_tuvan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_tuvan.BackgroundImage")));
            this.bt_tuvan.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_tuvan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_tuvan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_tuvan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_tuvan.Location = new System.Drawing.Point(97, 93);
            this.bt_tuvan.Name = "bt_tuvan";
            this.bt_tuvan.Size = new System.Drawing.Size(167, 85);
            this.bt_tuvan.TabIndex = 2;
            this.bt_tuvan.Text = "Tư vấn ";
            this.bt_tuvan.UseVisualStyleBackColor = true;
            this.bt_tuvan.Click += new System.EventHandler(this.bt_tuvan_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.bt_tuvan);
            this.Controls.Add(this.bt_luat);
            this.Controls.Add(this.bt_sukien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Hệ chuyên gia tư vấn chọn sách - Nhóm 10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_sukien;
        private System.Windows.Forms.Button bt_luat;
        private System.Windows.Forms.Button bt_tuvan;
    }
}

