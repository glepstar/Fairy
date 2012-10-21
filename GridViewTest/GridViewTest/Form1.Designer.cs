namespace GridViewTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_Human = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dg_Human = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Human)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Human
            // 
            this.cb_Human.FormattingEnabled = true;
            this.cb_Human.Location = new System.Drawing.Point(12, 168);
            this.cb_Human.Name = "cb_Human";
            this.cb_Human.Size = new System.Drawing.Size(367, 20);
            this.cb_Human.TabIndex = 1;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(12, 212);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(367, 38);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // dg_Human
            // 
            this.dg_Human.AllowUserToAddRows = false;
            this.dg_Human.AllowUserToDeleteRows = false;
            this.dg_Human.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Human.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.AgeCol,
            this.SexCol});
            this.dg_Human.Location = new System.Drawing.Point(13, 13);
            this.dg_Human.Name = "dg_Human";
            this.dg_Human.ReadOnly = true;
            this.dg_Human.RowTemplate.Height = 21;
            this.dg_Human.Size = new System.Drawing.Size(366, 150);
            this.dg_Human.TabIndex = 3;
            // 
            // NameCol
            // 
            this.NameCol.DataPropertyName = "Name";
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AgeCol
            // 
            this.AgeCol.DataPropertyName = "Age";
            this.AgeCol.HeaderText = "Age";
            this.AgeCol.Name = "AgeCol";
            this.AgeCol.ReadOnly = true;
            // 
            // SexCol
            // 
            this.SexCol.DataPropertyName = "Sex";
            this.SexCol.HeaderText = "Sex";
            this.SexCol.Name = "SexCol";
            this.SexCol.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 262);
            this.Controls.Add(this.dg_Human);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cb_Human);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Human)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Human;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridView dg_Human;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexCol;
    }
}

