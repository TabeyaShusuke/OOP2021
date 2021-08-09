
namespace Exercise2 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(48, 185);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNumber.Multiline = true;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(940, 450);
            this.tbNumber.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt1.Location = new System.Drawing.Point(48, 69);
            this.bt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(156, 61);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "open";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 670);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tbNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}

