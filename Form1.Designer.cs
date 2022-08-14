namespace FileVerCompare1
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
            this.btnExec = new System.Windows.Forms.Button();
            this.btnSelDest = new System.Windows.Forms.Button();
            this.btnSelSrc = new System.Windows.Forms.Button();
            this.txtDestPath = new System.Windows.Forms.TextBox();
            this.txtSrcPath = new System.Windows.Forms.TextBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IsUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrcVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(819, 12);
            this.btnExec.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(73, 72);
            this.btnExec.TabIndex = 16;
            this.btnExec.Text = "比對";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnSelDest
            // 
            this.btnSelDest.Location = new System.Drawing.Point(705, 54);
            this.btnSelDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelDest.Name = "btnSelDest";
            this.btnSelDest.Size = new System.Drawing.Size(90, 30);
            this.btnSelDest.TabIndex = 15;
            this.btnSelDest.Text = "選取";
            this.btnSelDest.UseVisualStyleBackColor = true;
            this.btnSelDest.Click += new System.EventHandler(this.btnSelDest_Click);
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
            // txtDestPath
            // 
            this.txtDestPath.Location = new System.Drawing.Point(87, 55);
            this.txtDestPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestPath.Name = "txtDestPath";
            this.txtDestPath.Size = new System.Drawing.Size(610, 29);
            this.txtDestPath.TabIndex = 13;
            // 
            // txtSrcPath
            // 
            this.txtSrcPath.Location = new System.Drawing.Point(87, 13);
            this.txtSrcPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSrcPath.Name = "txtSrcPath";
            this.txtSrcPath.Size = new System.Drawing.Size(610, 29);
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
            this.FName,
            this.SrcVer,
            this.DestVer,
            this.FullPath});
            this.dgvResult.Location = new System.Drawing.Point(12, 104);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(984, 613);
            this.dgvResult.TabIndex = 17;
            this.dgvResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResult_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "來源路徑";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "目的路徑";
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
            this.SrcVer.HeaderText = "來源版號";
            this.SrcVer.Name = "SrcVer";
            this.SrcVer.ReadOnly = true;
            this.SrcVer.Width = 150;
            // 
            // DestVer
            // 
            this.DestVer.DataPropertyName = "DestVer";
            this.DestVer.HeaderText = "目的版號";
            this.DestVer.Name = "DestVer";
            this.DestVer.ReadOnly = true;
            this.DestVer.Width = 150;
            // 
            // FullPath
            // 
            this.FullPath.DataPropertyName = "FullPath";
            this.FullPath.HeaderText = "FullPath";
            this.FullPath.Name = "FullPath";
            this.FullPath.ReadOnly = true;
            this.FullPath.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.btnSelDest);
            this.Controls.Add(this.btnSelSrc);
            this.Controls.Add(this.txtDestPath);
            this.Controls.Add(this.txtSrcPath);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "檔案版號比對";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnSelDest;
        private System.Windows.Forms.Button btnSelSrc;
        private System.Windows.Forms.TextBox txtDestPath;
        private System.Windows.Forms.TextBox txtSrcPath;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrcVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPath;
    }
}

