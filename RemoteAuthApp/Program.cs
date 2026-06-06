using Microsoft.Extensions.Configuration;
using RemoteAuthApp.Forms;
using RemoteAuthApp.Services;

namespace RemoteAuthApp;

/// <summary>
/// Entry point.
/// Khởi tạo database và services, sau đó chạy LoginForm.
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
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var firebaseAuthService = new AuthService(config);

            var loginForm = new LoginForm(firebaseAuthService);

            Application.Run(loginForm);
        }        catch (Exception ex)
        {
            MessageBox.Show(
                $"Lỗi khởi động:\n{ex.Message}",
                "RemoteAuthApp",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
