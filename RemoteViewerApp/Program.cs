using Microsoft.Extensions.Configuration;
using RemoteViewerApp.Forms;
using RemoteViewerApp.Helpers;
using RemoteViewerApp.Models;
using RemoteViewerApp.Services;

namespace RemoteViewerApp;

/// <summary>
/// Entry point của RemoteViewerApp.
/// Khởi tạo services thủ công (tương tự HostApp, không dùng Host builder để giữ WinForms đơn giản).
/// </summary>
internal static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

        try
        {
            //  Đọc cấu hình 
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var settings = new AppSettings();
            config.GetSection("AppSettings").Bind(settings);

            //  Khởi tạo services 
            var signalR = new SignalRViewerService(settings);

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

            //  Chạy MainForm 
            var mainForm = new MainForm(settings, signalR);

            LoggingHelper.Info("RemoteViewerApp khởi động.");
            Application.Run(mainForm);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Lỗi khởi động ứng dụng:\n{ex.Message}",
                "RemoteViewerApp – Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
