using System;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Thêm dòng này

namespace QuanLyThuVien
{
    static class Program
    {
        [DllImport("user32.dll")] // Sử dụng DllImport
        private static extern bool SetProcessDPIAware();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) // Kiểm tra phiên bản Windows
                SetProcessDPIAware(); // Gọi hàm để kích hoạt DPI Awareness
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form4());
        }
    }
}
