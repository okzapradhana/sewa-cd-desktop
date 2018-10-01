namespace Project_SewaCD
{
    partial class ListPeminjamanUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPeminjamanUserControl));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_kembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuThinButtonTampilkan = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.stock,
            this.price,
            this.tgl_kembali,
            this.harga,
            this.denda,
            this.diskon,
            this.total});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Honeydew;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(101, 19);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(441, 294);
            this.bunifuCustomDataGrid1.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "cd_id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // title
            // 
            this.title.HeaderText = "id_pinjam";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "tgl_pinjam";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "batas_pinjam";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // tgl_kembali
            // 
            this.tgl_kembali.HeaderText = "tgl_kembali";
            this.tgl_kembali.Name = "tgl_kembali";
            this.tgl_kembali.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.HeaderText = "harga";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // denda
            // 
            this.denda.HeaderText = "denda";
            this.denda.Name = "denda";
            this.denda.ReadOnly = true;
            // 
            // diskon
            // 
            this.diskon.HeaderText = "diskon";
            this.diskon.Name = "diskon";
            this.diskon.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // bunifuThinButtonTampilkan
            // 
            this.bunifuThinButtonTampilkan.ActiveBorderThickness = 1;
            this.bunifuThinButtonTampilkan.ActiveCornerRadius = 20;
            this.bunifuThinButtonTampilkan.ActiveFillColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuThinButtonTampilkan.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButtonTampilkan.ActiveLineColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuThinButtonTampilkan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuThinButtonTampilkan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButtonTampilkan.BackgroundImage")));
            this.bunifuThinButtonTampilkan.ButtonText = "Tampilkan";
            this.bunifuThinButtonTampilkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButtonTampilkan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButtonTampilkan.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuThinButtonTampilkan.IdleBorderThickness = 1;
            this.bunifuThinButtonTampilkan.IdleCornerRadius = 20;
            this.bunifuThinButtonTampilkan.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButtonTampilkan.IdleForecolor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuThinButtonTampilkan.IdleLineColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuThinButtonTampilkan.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bunifuThinButtonTampilkan.Location = new System.Drawing.Point(229, 347);
            this.bunifuThinButtonTampilkan.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButtonTampilkan.Name = "bunifuThinButtonTampilkan";
            this.bunifuThinButtonTampilkan.Size = new System.Drawing.Size(181, 37);
            this.bunifuThinButtonTampilkan.TabIndex = 10;
            this.bunifuThinButtonTampilkan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButtonTampilkan.Click += new System.EventHandler(this.bunifuThinButtonTampilkan_Click);
            // 
            // ListPeminjamanUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.bunifuThinButtonTampilkan);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "ListPeminjamanUserControl";
            this.Size = new System.Drawing.Size(625, 397);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_kembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn denda;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButtonTampilkan;
    }
}
