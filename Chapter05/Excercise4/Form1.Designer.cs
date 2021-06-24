
namespace Excercise4 {
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
            this.Button5_4 = new System.Windows.Forms.Button();
            this.Text5_4 = new System.Windows.Forms.TextBox();
            this.Text5_41 = new System.Windows.Forms.TextBox();
            this.Text5_42 = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.4";
            // 
            // Button5_4
            // 
            this.Button5_4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_4.Location = new System.Drawing.Point(45, 96);
            this.Button5_4.Name = "Button5_4";
            this.Button5_4.Size = new System.Drawing.Size(75, 35);
            this.Button5_4.TabIndex = 1;
            this.Button5_4.Text = "Q5.4";
            this.Button5_4.UseVisualStyleBackColor = true;
            this.Button5_4.Click += new System.EventHandler(this.Button5_4_Click);
            // 
            // Text5_4
            // 
            this.Text5_4.Location = new System.Drawing.Point(185, 110);
            this.Text5_4.Name = "Text5_4";
            this.Text5_4.Size = new System.Drawing.Size(418, 19);
            this.Text5_4.TabIndex = 2;
            // 
            // Text5_41
            // 
            this.Text5_41.Location = new System.Drawing.Point(185, 175);
            this.Text5_41.Name = "Text5_41";
            this.Text5_41.Size = new System.Drawing.Size(418, 19);
            this.Text5_41.TabIndex = 3;
            // 
            // Text5_42
            // 
            this.Text5_42.Location = new System.Drawing.Point(185, 244);
            this.Text5_42.Name = "Text5_42";
            this.Text5_42.Size = new System.Drawing.Size(418, 19);
            this.Text5_42.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(45, 73);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(558, 19);
            this.Title.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Text5_42);
            this.Controls.Add(this.Text5_41);
            this.Controls.Add(this.Text5_4);
            this.Controls.Add(this.Button5_4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button5_4;
        private System.Windows.Forms.TextBox Text5_4;
        private System.Windows.Forms.TextBox Text5_41;
        private System.Windows.Forms.TextBox Text5_42;
        private System.Windows.Forms.TextBox Title;
    }
}

