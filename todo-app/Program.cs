using todo_app.exception;

namespace todo_app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            GlobalExceptionHandler.Setup();

            var controller = new controller.Controller();
            controller.Init();
            
            Application.Run(controller.MainForm);
        }
    }
}