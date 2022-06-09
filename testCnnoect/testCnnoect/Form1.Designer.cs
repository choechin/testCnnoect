namespace testCnnoect
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_test = new System.Windows.Forms.Button();
            this.lbl_light = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_test.Location = new System.Drawing.Point(122, 30);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(130, 96);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "測試";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // lbl_light
            // 
            this.lbl_light.AutoSize = true;
            this.lbl_light.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_light.Location = new System.Drawing.Point(31, 60);
            this.lbl_light.Name = "lbl_light";
            this.lbl_light.Size = new System.Drawing.Size(69, 48);
            this.lbl_light.TabIndex = 1;
            this.lbl_light.Text = "●";
            this.lbl_light.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(280, 163);
            this.Controls.Add(this.lbl_light);
            this.Controls.Add(this.btn_test);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "測試Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label lbl_light;
    }
}

