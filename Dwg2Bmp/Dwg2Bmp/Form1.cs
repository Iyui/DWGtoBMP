using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace Dwg2Bmp
{
    public partial class Form1 : Form
    {
        //private bool bShiftSorF = false;
        //private bool bGetFilePath = false;
        public Form1()
        {
            InitializeComponent();
            string path = Assembly.GetExecutingAssembly().Location;
            DateTime lastdate = File.GetLastWriteTime(path);
            this.Text = "DWG转图片工具";
#if (DEBUG)

            this.Text += "-Iyui";
            this.Text += lastdate.ToString("-编译日期:yyyyMMdd HHmmss");
            
#else

            //this.Text += lastdate.ToString("yyyyMMdd");
            this.Text += "0.1.1";
#endif

        }

        private void OpenFileFormat()
        {
            ViewDWG dv = new ViewDWG();
            string sGetFilePath = this.sGetDWGFilePath();
            lFilePath.Text = sGetFilePath;
        }

        private void ShiftFileFormat()
        {
            //string sGetFilePath;
            try
            {
                ViewDWG dv = new ViewDWG();
                string sFilePath = lFilePath.Text.Substring(0, lFilePath.Text.LastIndexOf("\\"));
                string sGetPicPath = sFilePath + Path.GetFileNameWithoutExtension(lFilePath.Text) + ".bmp";
                dv.GetDwgImage(lFilePath.Text, sGetPicPath);
                MessageBox.Show("转换成功");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        #region 保存对话框
        private string sGetDWGFilePath()
        {
            //string localFilePath, fileNameExt, newFileName, FilePath;
            //System.Windows.Forms.SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();//类文件中使用//非窗体
            //设置文件类型
            openFileDialog1.Filter = "DWG Files(*.dwg)|*.*";
            //设置默认文件类型显示顺序
            openFileDialog1.FilterIndex = 2;
            //保存对话框是否记忆上次打开的目录
            openFileDialog1.RestoreDirectory = true;
            //saveFileDialog1.FileName = sFileName;
            //点了保存按钮进入
            string localFilePath;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //获得文件路径
                localFilePath = openFileDialog1.FileName.ToString();
                //获取文件名，不带路径
                //fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);
                //获取文件路径，不带文件名
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));
                //给文件名前加上时间
                //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt;
                //在文件名里加字符
                //saveFileDialog1.FileName.Insert(1,"dameng");
                //System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();//输出文件
                //fs输出带文字或图片的文件，就看需求了
                return localFilePath;
            }
            return null;

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileFormat();
        }

        private void btShiftFormat_Click(object sender, EventArgs e)
        {
            ShiftFileFormat();
        }
    }
}
