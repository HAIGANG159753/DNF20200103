using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lordeo.Framework;
using OpenCvSharp;

namespace DNFtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startgametest_Click(object sender, EventArgs e)
        {
            //Bitmap bitmap = publicmethod.GetScreenCapture();
            //bitmap.Save(@"G:\\Game\\VSpicture\\NewDriverScreen.jpg");
            IntPtr hWnd = IntPtr.Zero;
            //Console.WriteLine(1);
            //Console.WriteLine(hWnd);
            string savePath = "D:\\temp.bmp";
            var processes = Process.GetProcessById(9936);
            //Console.WriteLine(processes);
            var title = processes.MainWindowTitle;
            hWnd = Win32API.FindWindow(null, title);//得到名称为“记事本”的窗口句柄。
            //Console.WriteLine(2);
            //Console.WriteLine(hWnd);
            if (hWnd.ToString() == "0")
            {
                MessageBox.Show("未能找到目标窗口");
            }
            else
            {

                //savePath = "D\\temp.bmp";//设置图片的临时保存路径。
                //RECT rect = new RECT();
                //Win32API.GetWindowRect(hWnd, ref rect);

                Bitmap img = publicmethod.GetImg(hWnd);//X,Y为所要获取截图的窗口宽度和高度。

                img.Save(savePath);//保存得到的截图。
                MessageBox.Show("截图成功");
            }
        }

        

    }
}