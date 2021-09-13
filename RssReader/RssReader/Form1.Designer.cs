
namespace RssReader {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.btWeb = new System.Windows.Forms.Button();
            this.lbDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(233, 54);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(586, 27);
            this.tbUrl.TabIndex = 1;
            // 
            // btRead
            // 
            this.btRead.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRead.Location = new System.Drawing.Point(857, 50);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 34);
            this.btRead.TabIndex = 2;
            this.btRead.Text = "読込";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lbTitles
            // 
            this.lbTitles.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 23;
            this.lbTitles.Location = new System.Drawing.Point(13, 93);
            this.lbTitles.Margin = new System.Windows.Forms.Padding(4);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(340, 556);
            this.lbTitles.TabIndex = 2;
            this.lbTitles.Click += new System.EventHandler(this.lbTitles_Click);
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDate.Location = new System.Drawing.Point(391, 146);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(567, 98);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "a";
            // 
            // btWeb
            // 
            this.btWeb.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeb.Location = new System.Drawing.Point(823, 596);
            this.btWeb.Name = "btWeb";
            this.btWeb.Size = new System.Drawing.Size(109, 53);
            this.btWeb.TabIndex = 8;
            this.btWeb.Text = "WEB表示";
            this.btWeb.UseVisualStyleBackColor = true;
            this.btWeb.Click += new System.EventHandler(this.btWeb_Click);
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDescription.Location = new System.Drawing.Point(391, 275);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(567, 243);
            this.lbDescription.TabIndex = 9;
            this.lbDescription.Text = "b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 662);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.btWeb);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "32261";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btWeb;
        private System.Windows.Forms.Label lbDescription;
    }
}

