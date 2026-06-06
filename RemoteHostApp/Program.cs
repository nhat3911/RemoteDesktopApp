using Microsoft.Extensions.Configuration;
using RemoteHostApp.Forms;
using RemoteHostApp.Helpers;
using RemoteHostApp.Models;
using RemoteHostApp.Services;

namespace RemoteHostApp
{
    /// <summary>
    /// Entry point của RemoteHostApp.
    /// Khởi tạo services thủ công (không dùng Host builder để giữ WinForms đơn giản).
    /// </summary>
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //  Khởi tạo WinForms đúng cách cho .NET Framework 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                //  Đọc cấu hình từ appsettings.json 
                var config = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false)
                    .Build();

                var settings = new AppSettings();
                config.GetSection("AppSettings").Bind(settings);

                //  Khởi tạo services (thủ công, singleton) 
                var signalR = new SignalRHostService(settings);
                var input = new InputSimulatorService();
                var sessionMgr = new SessionManager();
                var capture = new ScreenCaptureService(settings, signalR);

                // Xử lý command-line args để set UserId và Username
                string[] args = Environment.GetCommandLineArgs();
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "--uid" && i + 1 < args.Length)
                    {
                        AppSession.Uid = args[i + 1];
                    }

                    if (args[i] == "--username" && i + 1 < args.Length)
                    {
                        AppSession.Username = args[i + 1];
                    }
                }

                //  Khởi tạo và chạy MainForm 
                var mainForm = new MainForm(settings, signalR, capture, input, sessionMgr);

                LoggingHelper.Info("RemoteHostApp khởi động.");
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi khởi động ứng dụng:\n{ex.Message}",
                    "RemoteHostApp – Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}