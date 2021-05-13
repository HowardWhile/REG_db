
namespace MyAPP
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
            this.btn_save1 = new System.Windows.Forms.Button();
            this.btn_save2 = new System.Windows.Forms.Button();
            this.btn_remove1 = new System.Windows.Forms.Button();
            this.btn_remove2 = new System.Windows.Forms.Button();
            this.btn_load1 = new System.Windows.Forms.Button();
            this.btn_load2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_save1
            // 
            this.btn_save1.Location = new System.Drawing.Point(14, 16);
            this.btn_save1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save1.Name = "btn_save1";
            this.btn_save1.Size = new System.Drawing.Size(87, 31);
            this.btn_save1.TabIndex = 0;
            this.btn_save1.Text = "Save1";
            this.btn_save1.UseVisualStyleBackColor = true;
            this.btn_save1.Click += new System.EventHandler(this.btn_save1_Click);
            // 
            // btn_save2
            // 
            this.btn_save2.Location = new System.Drawing.Point(14, 55);
            this.btn_save2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save2.Name = "btn_save2";
            this.btn_save2.Size = new System.Drawing.Size(87, 31);
            this.btn_save2.TabIndex = 1;
            this.btn_save2.Text = "Save2";
            this.btn_save2.UseVisualStyleBackColor = true;
            this.btn_save2.Click += new System.EventHandler(this.btn_save2_Click);
            // 
            // btn_remove1
            // 
            this.btn_remove1.Location = new System.Drawing.Point(200, 16);
            this.btn_remove1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove1.Name = "btn_remove1";
            this.btn_remove1.Size = new System.Drawing.Size(87, 31);
            this.btn_remove1.TabIndex = 2;
            this.btn_remove1.Text = "Remove1";
            this.btn_remove1.UseVisualStyleBackColor = true;
            this.btn_remove1.Click += new System.EventHandler(this.btn_remove1_Click);
            // 
            // btn_remove2
            // 
            this.btn_remove2.Location = new System.Drawing.Point(200, 55);
            this.btn_remove2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove2.Name = "btn_remove2";
            this.btn_remove2.Size = new System.Drawing.Size(87, 31);
            this.btn_remove2.TabIndex = 3;
            this.btn_remove2.Text = "Remove2";
            this.btn_remove2.UseVisualStyleBackColor = true;
            this.btn_remove2.Click += new System.EventHandler(this.btn_remove2_Click);
            // 
            // btn_load1
            // 
            this.btn_load1.Location = new System.Drawing.Point(107, 16);
            this.btn_load1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_load1.Name = "btn_load1";
            this.btn_load1.Size = new System.Drawing.Size(87, 31);
            this.btn_load1.TabIndex = 4;
            this.btn_load1.Text = "Load1";
            this.btn_load1.UseVisualStyleBackColor = true;
            this.btn_load1.Click += new System.EventHandler(this.btn_load1_Click);
            // 
            // btn_load2
            // 
            this.btn_load2.Location = new System.Drawing.Point(107, 55);
            this.btn_load2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_load2.Name = "btn_load2";
            this.btn_load2.Size = new System.Drawing.Size(87, 31);
            this.btn_load2.TabIndex = 5;
            this.btn_load2.Text = "Load2";
            this.btn_load2.UseVisualStyleBackColor = true;
            this.btn_load2.Click += new System.EventHandler(this.btn_load2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 192);
            this.Controls.Add(this.btn_load2);
            this.Controls.Add(this.btn_load1);
            this.Controls.Add(this.btn_remove2);
            this.Controls.Add(this.btn_remove1);
            this.Controls.Add(this.btn_save2);
            this.Controls.Add(this.btn_save1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save1;
        private System.Windows.Forms.Button btn_save2;
        private System.Windows.Forms.Button btn_remove1;
        private System.Windows.Forms.Button btn_remove2;
        private System.Windows.Forms.Button btn_load1;
        private System.Windows.Forms.Button btn_load2;
    }
}

