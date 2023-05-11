
namespace Ticket_Reservation_Football
{
    partial class Lichdau
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
            this.btntuketluotdi = new System.Windows.Forms.Button();
            this.btntuketluotve = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // btntuketluotdi
            // 
            this.btntuketluotdi.Location = new System.Drawing.Point(130, 292);
            this.btntuketluotdi.Name = "btntuketluotdi";
            this.btntuketluotdi.Size = new System.Drawing.Size(111, 48);
            this.btntuketluotdi.TabIndex = 1;
            this.btntuketluotdi.Text = "Tứ kết lượt đi";
            this.btntuketluotdi.UseVisualStyleBackColor = true;
            this.btntuketluotdi.Click += new System.EventHandler(this.btntuketluotdi_Click);
            // 
            // btntuketluotve
            // 
            this.btntuketluotve.Location = new System.Drawing.Point(466, 292);
            this.btntuketluotve.Name = "btntuketluotve";
            this.btntuketluotve.Size = new System.Drawing.Size(111, 48);
            this.btntuketluotve.TabIndex = 2;
            this.btntuketluotve.Text = "Tứ kết lượt về";
            this.btntuketluotve.UseVisualStyleBackColor = true;
            this.btntuketluotve.Click += new System.EventHandler(this.btntuketluotve_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(257, 365);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(185, 49);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Lichdau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntuketluotve);
            this.Controls.Add(this.btntuketluotdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lichdau";
            this.Text = "Lichdau";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntuketluotdi;
        private System.Windows.Forms.Button btntuketluotve;
        private System.Windows.Forms.Button btnthoat;
    }
}