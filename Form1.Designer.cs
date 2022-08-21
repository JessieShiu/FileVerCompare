namespace FileVerCompare
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnSelSrv = new System.Windows.Forms.Button();
            this.btnSelSrc = new System.Windows.Forms.Button();
            this.txtServerPath = new System.Windows.Forms.TextBox();
            this.txtSrcPath = new System.Windows.Forms.TextBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.IsUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrcVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnSelBk = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(819, 12);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(66, 45);
            this.btnCompare.TabIndex = 16;
            this.btnCompare.Text = "比對";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnSelSrv
            // 
            this.btnSelSrv.Location = new System.Drawing.Point(705, 48);
            this.btnSelSrv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelSrv.Name = "btnSelSrv";
            this.btnSelSrv.Size = new System.Drawing.Size(90, 30);
            this.btnSelSrv.TabIndex = 15;
            this.btnSelSrv.Text = "選取";
            this.btnSelSrv.UseVisualStyleBackColor = true;
            this.btnSelSrv.Click += new System.EventHandler(this.btnSelDest_Click);
            // 
            // btnSelSrc
            // 
            this.btnSelSrc.Location = new System.Drawing.Point(705, 12);
            this.btnSelSrc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelSrc.Name = "btnSelSrc";
            this.btnSelSrc.Size = new System.Drawing.Size(90, 30);
            this.btnSelSrc.TabIndex = 14;
            this.btnSelSrc.Text = "選取";
            this.btnSelSrc.UseVisualStyleBackColor = true;
            this.btnSelSrc.Click += new System.EventHandler(this.btnSelSrc_Click);
            // 
            // txtServerPath
            // 
            this.txtServerPath.Location = new System.Drawing.Point(102, 49);
            this.txtServerPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServerPath.Name = "txtServerPath";
            this.txtServerPath.Size = new System.Drawing.Size(595, 29);
            this.txtServerPath.TabIndex = 13;
            // 
            // txtSrcPath
            // 
            this.txtSrcPath.Location = new System.Drawing.Point(102, 13);
            this.txtSrcPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSrcPath.Name = "txtSrcPath";
            this.txtSrcPath.Size = new System.Drawing.Size(595, 29);
            this.txtSrcPath.TabIndex = 12;
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsUpdate,
            this.Image,
            this.FName,
            this.SrcVer,
            this.DestVer,
            this.FullPath});
            this.dgvResult.Location = new System.Drawing.Point(12, 215);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(984, 502);
            this.dgvResult.TabIndex = 17;
            this.dgvResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResult_CellFormatting);
            this.dgvResult.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvResult_DataBindingComplete);
            // 
            // IsUpdate
            // 
            this.IsUpdate.DataPropertyName = "IsUpdate";
            this.IsUpdate.HeaderText = "更新";
            this.IsUpdate.Name = "IsUpdate";
            this.IsUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsUpdate.Width = 70;
            // 
            // Image
            // 
            this.Image.HeaderText = "";
            this.Image.Image = global::FileVerCompare.Properties.Resources.file_icon;
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Image.Width = 50;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "Name";
            this.FName.HeaderText = "名稱";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Width = 250;
            // 
            // SrcVer
            // 
            this.SrcVer.DataPropertyName = "SrcVer";
            this.SrcVer.HeaderText = "更新包版號";
            this.SrcVer.Name = "SrcVer";
            this.SrcVer.ReadOnly = true;
            this.SrcVer.Width = 150;
            // 
            // DestVer
            // 
            this.DestVer.DataPropertyName = "DestVer";
            this.DestVer.HeaderText = "Server版號";
            this.DestVer.Name = "DestVer";
            this.DestVer.ReadOnly = true;
            this.DestVer.Width = 150;
            // 
            // FullPath
            // 
            this.FullPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullPath.DataPropertyName = "FullPath";
            this.FullPath.HeaderText = "FullPath";
            this.FullPath.Name = "FullPath";
            this.FullPath.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "來源路徑";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Server路徑";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "備份路徑";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(102, 84);
            this.txtBackupPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(595, 29);
            this.txtBackupPath.TabIndex = 20;
            // 
            // btnSelBk
            // 
            this.btnSelBk.Location = new System.Drawing.Point(705, 83);
            this.btnSelBk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelBk.Name = "btnSelBk";
            this.btnSelBk.Size = new System.Drawing.Size(90, 30);
            this.btnSelBk.TabIndex = 22;
            this.btnSelBk.Text = "選取";
            this.btnSelBk.UseVisualStyleBackColor = true;
            this.btnSelBk.Click += new System.EventHandler(this.btnSelBk_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(819, 68);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(66, 45);
            this.btnBackup.TabIndex = 23;
            this.btnBackup.Text = "備份";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(900, 12);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 101);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::FileVerCompare.Properties.Resources.merge_icon;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMsg.ForeColor = System.Drawing.Color.Red;
            this.txtMsg.Location = new System.Drawing.Point(101, 123);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMsg.Size = new System.Drawing.Size(895, 84);
            this.txtMsg.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "訊息";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnSelBk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnSelSrv);
            this.Controls.Add(this.btnSelSrc);
            this.Controls.Add(this.txtServerPath);
            this.Controls.Add(this.txtSrcPath);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "檔案版號比對";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnSelSrv;
        private System.Windows.Forms.Button btnSelSrc;
        private System.Windows.Forms.TextBox txtServerPath;
        private System.Windows.Forms.TextBox txtSrcPath;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnSelBk;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsUpdate;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrcVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPath;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label4;
    }
}

