
namespace E2 {
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
            this.tbOpen = new System.Windows.Forms.Button();
            this.btchage = new System.Windows.Forms.Button();
            this.btnum = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tbOpen
            // 
            this.tbOpen.Location = new System.Drawing.Point(29, 31);
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(75, 23);
            this.tbOpen.TabIndex = 0;
            this.tbOpen.Text = "開く";
            this.tbOpen.UseVisualStyleBackColor = true;
            this.tbOpen.Click += new System.EventHandler(this.tbOpen_Click);
            // 
            // btchage
            // 
            this.btchage.Location = new System.Drawing.Point(29, 99);
            this.btchage.Name = "btchage";
            this.btchage.Size = new System.Drawing.Size(75, 23);
            this.btchage.TabIndex = 0;
            this.btchage.Text = "変換先";
            this.btchage.UseVisualStyleBackColor = true;
            this.btchage.Click += new System.EventHandler(this.btchage_Click);
            // 
            // btnum
            // 
            this.btnum.Location = new System.Drawing.Point(29, 186);
            this.btnum.Name = "btnum";
            this.btnum.Size = new System.Drawing.Size(75, 23);
            this.btnum.TabIndex = 0;
            this.btnum.Text = "行番号";
            this.btnum.UseVisualStyleBackColor = true;
            this.btnum.Click += new System.EventHandler(this.btnum_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 236);
            this.Controls.Add(this.btnum);
            this.Controls.Add(this.btchage);
            this.Controls.Add(this.tbOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbOpen;
        private System.Windows.Forms.Button btchage;
        private System.Windows.Forms.Button btnum;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

