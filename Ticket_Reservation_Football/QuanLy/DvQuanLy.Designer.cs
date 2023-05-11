
namespace QuanLy
{
    partial class DvQuanLy
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
            this.btnchinhsua = new System.Windows.Forms.Button();
            this.Btnquanlyve = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnchinhsua
            // 
            this.btnchinhsua.BackgroundImage = global::QuanLy.Properties.Resources.mesi;
            this.btnchinhsua.Font = new System.Drawing.Font("UTM Ambrose", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnchinhsua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnchinhsua.Location = new System.Drawing.Point(4, 22);
            this.btnchinhsua.Name = "btnchinhsua";
            this.btnchinhsua.Size = new System.Drawing.Size(124, 73);
            this.btnchinhsua.TabIndex = 0;
            this.btnchinhsua.Text = "Quản lý trận đấu";
            this.btnchinhsua.UseVisualStyleBackColor = true;
            this.btnchinhsua.Click += new System.EventHandler(this.btnchinhsua_Click);
            // 
            // Btnquanlyve
            // 
            this.Btnquanlyve.BackgroundImage = global::QuanLy.Properties.Resources.mesi;
            this.Btnquanlyve.Font = new System.Drawing.Font("UTM Ambrose", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btnquanlyve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btnquanlyve.Location = new System.Drawing.Point(4, 110);
            this.Btnquanlyve.Name = "Btnquanlyve";
            this.Btnquanlyve.Size = new System.Drawing.Size(123, 73);
            this.Btnquanlyve.TabIndex = 1;
            this.Btnquanlyve.Text = "Thống kê doanh số";
            this.Btnquanlyve.UseVisualStyleBackColor = true;
            this.Btnquanlyve.Click += new System.EventHandler(this.Btnquanlyve_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = global::QuanLy.Properties.Resources.mesi;
            this.btnthoat.Font = new System.Drawing.Font("UTM Ambrose", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(5, 201);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(123, 57);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLy.Properties.Resources.UEFA_CHAMPIONS_LEAGUE_FINAL_80;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.btnchinhsua);
            this.groupBox2.Controls.Add(this.Btnquanlyve);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Location = new System.Drawing.Point(1, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 281);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLy.Properties.Resources.category_1204_1460125128980;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Location = new System.Drawing.Point(1, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 185);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::QuanLy.Properties.Resources.krestovsky;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Location = new System.Drawing.Point(135, -8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 458);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // DvQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "DvQuanLy";
            this.Text = "DvQuanLy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DvQuanLy_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnchinhsua;
        private System.Windows.Forms.Button Btnquanlyve;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}