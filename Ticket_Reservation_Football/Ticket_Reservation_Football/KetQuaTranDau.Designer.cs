
namespace Ticket_Reservation_Football
{
    partial class KetQuaTranDau
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
            this.btntuketluondi = new System.Windows.Forms.Button();
            this.btntuketluotve = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnketqua = new System.Windows.Forms.Button();
            this.btndanhsach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // btntuketluondi
            // 
            this.btntuketluondi.Location = new System.Drawing.Point(99, 269);
            this.btntuketluondi.Name = "btntuketluondi";
            this.btntuketluondi.Size = new System.Drawing.Size(130, 60);
            this.btntuketluondi.TabIndex = 1;
            this.btntuketluondi.Text = "Vòng 1/8 lượt đi";
            this.btntuketluondi.UseVisualStyleBackColor = true;
            this.btntuketluondi.Click += new System.EventHandler(this.btntuketluondi_Click);
            // 
            // btntuketluotve
            // 
            this.btntuketluotve.Location = new System.Drawing.Point(268, 269);
            this.btntuketluotve.Name = "btntuketluotve";
            this.btntuketluotve.Size = new System.Drawing.Size(128, 60);
            this.btntuketluotve.TabIndex = 2;
            this.btntuketluotve.Text = "Vòng 1/8 lượt về";
            this.btntuketluotve.UseVisualStyleBackColor = true;
            this.btntuketluotve.Click += new System.EventHandler(this.btntuketluotve_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(238, 352);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(227, 57);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnketqua
            // 
            this.btnketqua.Location = new System.Drawing.Point(439, 269);
            this.btnketqua.Name = "btnketqua";
            this.btnketqua.Size = new System.Drawing.Size(128, 60);
            this.btnketqua.TabIndex = 4;
            this.btnketqua.Text = "Kết quả chung cuộc";
            this.btnketqua.UseVisualStyleBackColor = true;
            this.btnketqua.Click += new System.EventHandler(this.btnketqua_Click);
            // 
            // btndanhsach
            // 
            this.btndanhsach.Location = new System.Drawing.Point(613, 269);
            this.btndanhsach.Name = "btndanhsach";
            this.btndanhsach.Size = new System.Drawing.Size(128, 60);
            this.btndanhsach.TabIndex = 5;
            this.btndanhsach.Text = "Danh sách vào vòng trong";
            this.btndanhsach.UseVisualStyleBackColor = true;
            this.btndanhsach.Click += new System.EventHandler(this.btndanhsach_Click);
            // 
            // KetQuaTranDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndanhsach);
            this.Controls.Add(this.btnketqua);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntuketluotve);
            this.Controls.Add(this.btntuketluondi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KetQuaTranDau";
            this.Text = "KetQuaTranDau";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntuketluondi;
        private System.Windows.Forms.Button btntuketluotve;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnketqua;
        private System.Windows.Forms.Button btndanhsach;
    }
}