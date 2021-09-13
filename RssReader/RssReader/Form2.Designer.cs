
namespace RssReader {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.wbTitle = new System.Windows.Forms.WebBrowser();
            this.btReturn = new System.Windows.Forms.Button();
            this.btForward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbTitle
            // 
            this.wbTitle.Location = new System.Drawing.Point(12, 57);
            this.wbTitle.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTitle.Name = "wbTitle";
            this.wbTitle.ScriptErrorsSuppressed = true;
            this.wbTitle.Size = new System.Drawing.Size(911, 545);
            this.wbTitle.TabIndex = 0;
            this.wbTitle.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbTitle_DocumentCompleted);
            // 
            // btReturn
            // 
            this.btReturn.Enabled = false;
            this.btReturn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReturn.Location = new System.Drawing.Point(21, 12);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(108, 39);
            this.btReturn.TabIndex = 1;
            this.btReturn.Text = "return";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btForward
            // 
            this.btForward.Enabled = false;
            this.btForward.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btForward.Location = new System.Drawing.Point(171, 12);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(108, 39);
            this.btForward.TabIndex = 1;
            this.btForward.Text = "forward";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 614);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.wbTitle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbTitle;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btForward;
    }
}