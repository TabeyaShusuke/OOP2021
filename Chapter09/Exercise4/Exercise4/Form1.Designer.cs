
namespace Exercise4 {
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
            this.btCopy = new System.Windows.Forms.Button();
            this.tbCopySouce = new System.Windows.Forms.TextBox();
            this.tbCopy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCopy
            // 
            this.btCopy.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCopy.Location = new System.Drawing.Point(499, 42);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(192, 68);
            this.btCopy.TabIndex = 0;
            this.btCopy.Text = "Copy";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // tbCopySouce
            // 
            this.tbCopySouce.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.tbCopySouce.Location = new System.Drawing.Point(39, 48);
            this.tbCopySouce.Multiline = true;
            this.tbCopySouce.Name = "tbCopySouce";
            this.tbCopySouce.Size = new System.Drawing.Size(394, 45);
            this.tbCopySouce.TabIndex = 1;
            // 
            // tbCopy
            // 
            this.tbCopy.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.tbCopy.Location = new System.Drawing.Point(39, 129);
            this.tbCopy.Multiline = true;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(394, 45);
            this.tbCopy.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 200);
            this.Controls.Add(this.tbCopy);
            this.Controls.Add(this.tbCopySouce);
            this.Controls.Add(this.btCopy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.TextBox tbCopySouce;
        private System.Windows.Forms.TextBox tbCopy;
    }
}

