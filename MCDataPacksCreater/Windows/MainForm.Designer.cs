namespace MCDataPacksCreater
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button BtnToCompounForm;
            this.BtnSure = new System.Windows.Forms.Button();
            this.IptFilePath = new System.Windows.Forms.TextBox();
            this.BtnFileBrowser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            BtnToCompounForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnToCompounForm
            // 
            BtnToCompounForm.Location = new System.Drawing.Point(757, 91);
            BtnToCompounForm.Name = "BtnToCompounForm";
            BtnToCompounForm.Size = new System.Drawing.Size(107, 23);
            BtnToCompounForm.TabIndex = 5;
            BtnToCompounForm.Text = "工作台模式";
            BtnToCompounForm.UseVisualStyleBackColor = true;
            BtnToCompounForm.Click += new System.EventHandler(this.BtnToCompounForm_Click);
            // 
            // BtnSure
            // 
            this.BtnSure.Location = new System.Drawing.Point(419, 311);
            this.BtnSure.Name = "BtnSure";
            this.BtnSure.Size = new System.Drawing.Size(102, 39);
            this.BtnSure.TabIndex = 0;
            this.BtnSure.Text = "确认";
            this.BtnSure.UseVisualStyleBackColor = true;
            this.BtnSure.Click += new System.EventHandler(this.BtnSure_Click);
            // 
            // IptFilePath
            // 
            this.IptFilePath.Location = new System.Drawing.Point(369, 172);
            this.IptFilePath.Name = "IptFilePath";
            this.IptFilePath.Size = new System.Drawing.Size(184, 23);
            this.IptFilePath.TabIndex = 2;
            // 
            // BtnFileBrowser
            // 
            this.BtnFileBrowser.Location = new System.Drawing.Point(585, 172);
            this.BtnFileBrowser.Name = "BtnFileBrowser";
            this.BtnFileBrowser.Size = new System.Drawing.Size(75, 23);
            this.BtnFileBrowser.TabIndex = 3;
            this.BtnFileBrowser.Text = "浏览文件";
            this.BtnFileBrowser.UseVisualStyleBackColor = true;
            this.BtnFileBrowser.Click += new System.EventHandler(this.BtnFileBrowser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(585, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(BtnToCompounForm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnFileBrowser);
            this.Controls.Add(this.IptFilePath);
            this.Controls.Add(this.BtnSure);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据包生成器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnSure;
        private TextBox IptFilePath;
        private Button BtnFileBrowser;
        private DataGridView dataGridView1;
        private Button BtnToCompounForm;
    }
}