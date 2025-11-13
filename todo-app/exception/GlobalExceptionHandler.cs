using System;
using System.Threading;
using System.Windows.Forms;

namespace todo_app.exception
{
    public static class GlobalExceptionHandler
    {
        public static void Setup()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);

            if (e.IsTerminating)
            {
                Console.Error.WriteLine(e.ToString());
                MessageBox.Show("Ứng dụng đã gặp một lỗi nghiêm trọng và sẽ phải đóng lại.", "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private static void HandleException(Exception? ex)
        {
            if (ex == null) return;

            if (ex is AppException)
            {
                Console.Error.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Console.Error.WriteLine(ex.Message);
                MessageBox.Show("Đã có lỗi không mong muốn xảy ra. Vui lòng thử lại hoặc liên hệ quản trị viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}