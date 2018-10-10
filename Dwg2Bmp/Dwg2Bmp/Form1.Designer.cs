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
            this.btOutputPath = new System.Windows.Forms.Button();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
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
            this.lFilePath.Location = new System.Drawing.Point(173, 44);
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
            this.panel1.Location = new System.Drawing.Point(501, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 100);
            this.panel1.TabIndex = 4;
            // 
            // btShiftFormat
            // 
            this.btShiftFormat.Location = new System.Drawing.Point(43, 225);
            this.btShiftFormat.Name = "btShiftFormat";
            this.btShiftFormat.Size = new System.Drawing.Size(108, 48);
            this.btShiftFormat.TabIndex = 5;
            this.btShiftFormat.Text = "开始转换";
            this.btShiftFormat.UseVisualStyleBackColor = true;
            this.btShiftFormat.Click += new System.EventHandler(this.btShiftFormat_Click);
            // 
            // btOutputPath
            // 
            this.btOutputPath.Location = new System.Drawing.Point(43, 178);
            this.btOutputPath.Name = "btOutputPath";
            this.btOutputPath.Size = new System.Drawing.Size(86, 32);
            this.btOutputPath.TabIndex = 6;
            this.btOutputPath.Text = "输出路径";
            this.btOutputPath.UseVisualStyleBackColor = true;
            this.btOutputPath.Click += new System.EventHandler(this.btOutPutPath_Click);
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.Location = new System.Drawing.Point(135, 184);
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.Size = new System.Drawing.Size(442, 25);
            this.tbOutputPath.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 434);
            this.Controls.Add(this.tbOutputPath);
            this.Controls.Add(this.btOutputPath);
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
        private System.Windows.Forms.Button btOutputPath;
        private System.Windows.Forms.TextBox tbOutputPath;
    }
}

