namespace DNFtest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.startgametest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startgametest
            // 
            this.startgametest.Location = new System.Drawing.Point(44, 46);
            this.startgametest.Name = "startgametest";
            this.startgametest.Size = new System.Drawing.Size(168, 96);
            this.startgametest.TabIndex = 0;
            this.startgametest.Text = "进行一些操作";
            this.startgametest.UseVisualStyleBackColor = true;
            this.startgametest.Click += new System.EventHandler(this.startgametest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startgametest);
            this.Name = "Form1";
            this.Text = "测试用";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startgametest;
    }
}

