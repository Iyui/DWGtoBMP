namespace Dwg2Bmp
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lFilePath = new System.Windows.Forms.Label();
            this.rbBMP = new System.Windows.Forms.RadioButton();
            this.rbJPG = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btShiftFormat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(43, 40);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(108, 48);
            this.btOpenFile.TabIndex = 0;
            this.btOpenFile.Text = "选择文件";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lFilePath
            // 
            this.lFilePath.AutoSize = true;
            this.lFilePath.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lFilePath.Location = new System.Drawing.Point(38, 94);
            this.lFilePath.Name = "lFilePath";
            this.lFilePath.Size = new System.Drawing.Size(0, 30);
            this.lFilePath.TabIndex = 1;
            // 
            // rbBMP
            // 
            this.rbBMP.AutoSize = true;
            this.rbBMP.Checked = true;
            this.rbBMP.Location = new System.Drawing.Point(18, 17);
            this.rbBMP.Name = "rbBMP";
            this.rbBMP.Size = new System.Drawing.Size(52, 19);
            this.rbBMP.TabIndex = 2;
            this.rbBMP.TabStop = true;
            this.rbBMP.Text = "BMP";
            this.rbBMP.UseVisualStyleBackColor = true;
            // 
            // rbJPG
            // 
            this.rbJPG.AutoSize = true;
            this.rbJPG.Enabled = false;
            this.rbJPG.Location = new System.Drawing.Point(18, 66);
            this.rbJPG.Name = "rbJPG";
            this.rbJPG.Size = new System.Drawing.Size(52, 19);
            this.rbJPG.TabIndex = 3;
            this.rbJPG.Text = "JPG";
            this.rbJPG.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbBMP);
            this.panel1.Controls.Add(this.rbJPG);
            this.panel1.Location = new System.Drawing.Point(232, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 100);
            this.panel1.TabIndex = 4;
            // 
            // btShiftFormat
            // 
            this.btShiftFormat.Location = new System.Drawing.Point(431, 40);
            this.btShiftFormat.Name = "btShiftFormat";
            this.btShiftFormat.Size = new System.Drawing.Size(108, 48);
            this.btShiftFormat.TabIndex = 5;
            this.btShiftFormat.Text = "开始转换";
            this.btShiftFormat.UseVisualStyleBackColor = true;
            this.btShiftFormat.Click += new System.EventHandler(this.btShiftFormat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 135);
            this.Controls.Add(this.btShiftFormat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lFilePath);
            this.Controls.Add(this.btOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lFilePath;
        private System.Windows.Forms.RadioButton rbBMP;
        private System.Windows.Forms.RadioButton rbJPG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btShiftFormat;
    }
}

