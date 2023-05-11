
namespace QuanLy
{
    partial class DanhMucChinhSua
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
            this.btnvongdau = new System.Windows.Forms.Button();
            this.btntrandau = new System.Windows.Forms.Button();
            this.btntrove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnvongdau
            // 
            this.btnvongdau.BackgroundImage = global::QuanLy.Properties.Resources.mesi;
            this.btnvongdau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnvongdau.Font = new System.Drawing.Font("UTM Ambrose", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnvongdau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvongdau.Location = new System.Drawing.Point(6, 22);
            this.btnvongdau.Name = "btnvongdau";
            this.btnvongdau.Size = new System.Drawing.Size(117, 56);
            this.btnvongdau.TabIndex = 0;
            this.btnvongdau.Text = "Cập nhật vòng đấu";
            this.btnvongdau.UseVisualStyleBackColor = true;
            this.btnvongdau.Click += new System.EventHandler(this.btnvongdau_Click);
            // 
            // btntrandau
            // 
            this.btntrandau.BackgroundImage = global::QuanLy.Properties.Resources.mesi;
            this.btntrandau.Font = new System.Drawing.Font("UTM Ambrose", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntrandau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntrandau.Location = new System.Drawing.Point(129, 22);
            this.btntrandau.Name = "btntrandau";
            this.btntrandau.Size = new System.Drawing.Size(102, 56);
            this.btntrandau.TabIndex = 1;
            this.btntrandau.Text = "cập nhật trận đấu";
            this.btntrandau.UseVisualStyleBackColor = true;
            this.btntrandau.Click += new System.EventHandler(this.btntrandau_Click);
            // 
            // btntrove
            // 
            this.btntrove.BackgroundImage = global::QuanLy.Properties.Resources.mesi;
            this.btntrove.Font = new System.Drawing.Font("UTM Ambrose", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntrove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntrove.Location = new System.Drawing.Point(9, 84);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(222, 29);
            this.btntrove.TabIndex = 2;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLy.Properties.Resources.UEFA_CHAMPIONS_LEAGUE_FINAL_80;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btntrove);
            this.groupBox1.Controls.Add(this.btnvongdau);
            this.groupBox1.Controls.Add(this.btntrandau);
            this.groupBox1.Location = new System.Drawing.Point(3, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLy.Properties.Resources.category_1204_1460125128980;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Location = new System.Drawing.Point(3, -11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 339);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::QuanLy.Properties.Resources.top3cuthuhaynhatnamuefa;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Location = new System.Drawing.Point(240, -11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 458);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // DanhMucChinhSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DanhMucChinhSua";
            this.Text = "DanhMucChinhSua";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DanhMucChinhSua_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvongdau;
        private System.Windows.Forms.Button btntrandau;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}