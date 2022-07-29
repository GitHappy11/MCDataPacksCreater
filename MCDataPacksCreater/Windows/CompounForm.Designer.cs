namespace MCDataPacksCreater.Windows
{
    partial class CompounForm
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
            this.GoodsItmeOne = new System.Windows.Forms.ComboBox();
            this.GoodsItemTwo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GoodsItmeOne
            // 
            this.GoodsItmeOne.FormattingEnabled = true;
            this.GoodsItmeOne.Location = new System.Drawing.Point(34, 50);
            this.GoodsItmeOne.Name = "GoodsItmeOne";
            this.GoodsItmeOne.Size = new System.Drawing.Size(121, 25);
            this.GoodsItmeOne.TabIndex = 0;
            this.GoodsItmeOne.SelectedIndexChanged += new System.EventHandler(this.GoodsItmeOne_SelectedIndexChanged);
            this.GoodsItmeOne.TextUpdate += new System.EventHandler(this.GoodsItmeOne_TextUpdate);
            // 
            // GoodsItemTwo
            // 
            this.GoodsItemTwo.FormattingEnabled = true;
            this.GoodsItemTwo.Location = new System.Drawing.Point(34, 92);
            this.GoodsItemTwo.Name = "GoodsItemTwo";
            this.GoodsItemTwo.Size = new System.Drawing.Size(121, 25);
            this.GoodsItemTwo.TabIndex = 1;
            // 
            // CompounForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoodsItemTwo);
            this.Controls.Add(this.GoodsItmeOne);
            this.Name = "CompounForm";
            this.Text = "CompoundWindow";
            this.Load += new System.EventHandler(this.CompounForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox GoodsItmeOne;
        private ComboBox GoodsItemTwo;
    }
}