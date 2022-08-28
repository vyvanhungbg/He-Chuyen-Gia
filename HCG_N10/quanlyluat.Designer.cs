
namespace HCG_N10
{
    partial class quanlyluat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlyluat));
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_maluat = new System.Windows.Forms.TextBox();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.dataLuat = new System.Windows.Forms.DataGridView();
            this.maluat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLuat)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_timkiem.Location = new System.Drawing.Point(140, 42);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(178, 30);
            this.txt_timkiem.TabIndex = 3;
            // 
            // txt_maluat
            // 
            this.txt_maluat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_maluat.Location = new System.Drawing.Point(140, 90);
            this.txt_maluat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_maluat.Name = "txt_maluat";
            this.txt_maluat.Size = new System.Drawing.Size(178, 30);
            this.txt_maluat.TabIndex = 4;
            // 
            // txt_noidung
            // 
            this.txt_noidung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_noidung.Location = new System.Drawing.Point(140, 134);
            this.txt_noidung.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_noidung.Size = new System.Drawing.Size(398, 54);
            this.txt_noidung.TabIndex = 5;
            // 
            // bt_tim
            // 
            this.bt_tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_tim.BackgroundImage")));
            this.bt_tim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_tim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_tim.Location = new System.Drawing.Point(398, 42);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(96, 36);
            this.bt_tim.TabIndex = 6;
            this.bt_tim.Text = "Tìm kiếm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_them.BackgroundImage")));
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_them.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_them.Location = new System.Drawing.Point(546, 42);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(94, 36);
            this.bt_them.TabIndex = 7;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sua.BackgroundImage")));
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.Location = new System.Drawing.Point(546, 92);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(94, 36);
            this.bt_sua.TabIndex = 8;
            this.bt_sua.Text = "Sửa ";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_xoa.BackgroundImage")));
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_xoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_xoa.Location = new System.Drawing.Point(546, 152);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(94, 36);
            this.bt_xoa.TabIndex = 9;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // dataLuat
            // 
            this.dataLuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maluat,
            this.noidung});
            this.dataLuat.Location = new System.Drawing.Point(140, 207);
            this.dataLuat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataLuat.Name = "dataLuat";
            this.dataLuat.RowHeadersWidth = 51;
            this.dataLuat.RowTemplate.Height = 29;
            this.dataLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLuat.ShowRowErrors = false;
            this.dataLuat.Size = new System.Drawing.Size(500, 230);
            this.dataLuat.TabIndex = 0;
            this.dataLuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCellclick);
            this.dataLuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLuat_CellContentClick);
            // 
            // maluat
            // 
            this.maluat.DataPropertyName = "maluat";
            this.maluat.HeaderText = "Mã Luật";
            this.maluat.MinimumWidth = 6;
            this.maluat.Name = "maluat";
            this.maluat.Width = 150;
            // 
            // noidung
            // 
            this.noidung.DataPropertyName = "noidung";
            this.noidung.HeaderText = "Nội Dung";
            this.noidung.MinimumWidth = 6;
            this.noidung.Name = "noidung";
            this.noidung.Width = 220;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nội dung";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã luật";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tìm kiếm";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // quanlyluat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(828, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataLuat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.txt_noidung);
            this.Controls.Add(this.txt_maluat);
            this.Controls.Add(this.txt_timkiem);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "quanlyluat";
            this.Text = "Quản lý luật";
            this.Load += new System.EventHandler(this.quanlyluat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_maluat;
        private System.Windows.Forms.TextBox txt_noidung;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.DataGridView dataLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maluat;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}