namespace zastoneV77Desktop
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
            this.button1 = new System.Windows.Forms.Button();
            this.rawDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processedDataGrid = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.readRadioConfiguration_Btn);
            // 
            // rawDataGrid
            // 
            this.rawDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.rawDataGrid.Location = new System.Drawing.Point(13, 43);
            this.rawDataGrid.Name = "rawDataGrid";
            this.rawDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawDataGrid.Size = new System.Drawing.Size(1073, 239);
            this.rawDataGrid.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Command Direction";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Command";
            this.Column2.Name = "Column2";
            this.Column2.Width = 600;
            // 
            // processedDataGrid
            // 
            this.processedDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.processedDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.processedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processedDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.processedDataGrid.Location = new System.Drawing.Point(12, 288);
            this.processedDataGrid.Name = "processedDataGrid";
            this.processedDataGrid.Size = new System.Drawing.Size(1073, 150);
            this.processedDataGrid.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RX Frequency (MHz)";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tone Dec";
            this.Column4.Name = "Column4";
            this.Column4.Width = 74;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TX Frequency (MHz)";
            this.Column5.Name = "Column5";
            this.Column5.Width = 119;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tone Enc";
            this.Column6.Name = "Column6";
            this.Column6.Width = 73;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Scan Add";
            this.Column7.Name = "Column7";
            this.Column7.Width = 73;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "W/N";
            this.Column8.Name = "Column8";
            this.Column8.Width = 56;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "TX Power";
            this.Column9.Name = "Column9";
            this.Column9.Width = 73;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Busy Lock";
            this.Column10.Name = "Column10";
            this.Column10.Width = 76;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Scramble";
            this.Column11.Name = "Column11";
            this.Column11.Width = 76;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Compander";
            this.Column12.Name = "Column12";
            this.Column12.Width = 86;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "PTT ID";
            this.Column13.Name = "Column13";
            this.Column13.Width = 62;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.processedDataGrid);
            this.Controls.Add(this.rawDataGrid);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView rawDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView processedDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}

