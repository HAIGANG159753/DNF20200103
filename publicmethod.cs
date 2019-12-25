using Lordeo.Framework;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DNFtest
{
    class publicmethod
    {
        //截取屏幕图像
        public static Bitmap GetScreenCapture()
        {
            Rectangle tScreenRect = new Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Bitmap tSrcBmp = new Bitmap(tScreenRect.Width, tScreenRect.Height); // 用于屏幕原始图片保存
            Graphics gp = Graphics.FromImage(tSrcBmp);
            gp.CopyFromScreen(0, 0, 0, 0, tScreenRect.Size);
            gp.DrawImage(tSrcBmp, 0, 0, tScreenRect, GraphicsUnit.Pixel);
            return tSrcBmp;
        }

        const int DWMWA_EXTENDED_FRAME_BOUNDS = 9;
        [DllImport("dwmapi.dll")]
        static extern int DwmGetWindowAttribute(IntPtr hWnd, int dwAttribute, out RECT lpRect, int cbAttribute);
        
        public static Bitmap GetImg(IntPtr hWnd)//得到窗口截图

        {

            IntPtr hscrdc = Win32API.GetWindowDC(hWnd);
            //IntPtr hscrdc = hWnd;

            //Console.WriteLine(3);
            //Console.WriteLine(hscrdc);

            //Control control = Control.FromHandle(hWnd);

            //Console.WriteLine(control);

            RECT rect = new RECT();

            //DwmGetWindowAttribute(hscrdc, DWMWA_EXTENDED_FRAME_BOUNDS,ref rect, sizeof(rect));

            //DwmGetWindowAttribute(hscrdc, DWMWA_EXTENDED_FRAME_BOUNDS, out rect, Marshal.SizeOf(typeof(RECT)));

            Win32API.GetWindowRect(hWnd, ref rect);


            IntPtr hbitmap = Win32API.CreateCompatibleBitmap(hscrdc, rect.right - rect.left, rect.bottom - rect.top);

            IntPtr hmemdc = Win32API.CreateCompatibleDC(hscrdc);

            Win32API.SelectObject(hmemdc, hbitmap);

            Win32API.PrintWindow(hWnd, hmemdc, 0);

            Bitmap bmp = Bitmap.FromHbitmap(hbitmap);

            Win32API.DeleteDC(hscrdc);//删除用过的对象

            Win32API.DeleteObject(hbitmap);//删除用过的对象

            Win32API.DeleteDC(hmemdc);//删除用过的对象

            return bmp;

        }
    }
    
}
