
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
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.tmLevolution = new System.Windows.Forms.Timer(this.components);
            this.btReset = new System.Windows.Forms.Button();
            this.btRap = new System.Windows.Forms.Button();
            this.lbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start.Location = new System.Drawing.Point(38, 99);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(108, 89);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stop.Location = new System.Drawing.Point(38, 229);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(108, 94);
            this.stop.TabIndex = 1;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb1.Location = new System.Drawing.Point(30, 12);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(266, 46);
            this.lb1.TabIndex = 3;
            // 
            // tmLevolution
            // 
            this.tmLevolution.Enabled = true;
            this.tmLevolution.Interval = 1;
            this.tmLevolution.Tick += new System.EventHandler(this.tmLevolution_Tick);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btReset.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReset.Location = new System.Drawing.Point(188, 99);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(108, 89);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btRap
            // 
            this.btRap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRap.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRap.Location = new System.Drawing.Point(188, 229);
            this.btRap.Name = "btRap";
            this.btRap.Size = new System.Drawing.Size(108, 94);
            this.btRap.TabIndex = 5;
            this.btRap.Text = "rap";
            this.btRap.UseVisualStyleBackColor = false;
            this.btRap.Click += new System.EventHandler(this.btRap_Click);
            // 
            // lbox
            // 
            this.lbox.AllowDrop = true;
            this.lbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbox.ForeColor = System.Drawing.SystemColors.Control;
            this.lbox.FormattingEnabled = true;
            this.lbox.ItemHeight = 24;
            this.lbox.Location = new System.Drawing.Point(313, 12);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(241, 316);
            this.lbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(571, 337);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.btRap);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Timer tmLevolution;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btRap;
        private System.Windows.Forms.ListBox lbox;
    }
}

