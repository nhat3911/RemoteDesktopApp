using Microsoft.Extensions.Configuration;
using RemoteAuthApp.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace RemoteAuthApp.Services;

public class AuthService
{
    private readonly HttpClient _httpClient = new();
    private readonly string _apiKey;

    public AuthService(IConfiguration config)
    {
        _apiKey = config["Firebase:ApiKey"] ?? "";
        if (string.IsNullOrWhiteSpace(_apiKey))
            throw new InvalidOperationException("Thiếu Firebase:ApiKey trong appsettings.json");
    }

    public async Task<AuthResponse?> RegisterAsync(string username, string email, string password)
    {
        var user = await AuthAsync("signUp", email, password);
        if (user == null) return null;

        var updated = await UpdateProfileAsync(user.idToken, username);
        return updated ?? user;
    }

    public Task<AuthResponse?> LoginAsync(string email, string password)
        => AuthAsync("signInWithPassword", email, password);

    private async Task<AuthResponse?> AuthAsync(string action, string email, string password)
    {
        string url = $"https://identitytoolkit.googleapis.com/v1/accounts:{action}?key={_apiKey}";

        var body = new
        {
            email,
            password,
            returnSecureToken = true
        };

        var response = await _httpClient.PostAsJsonAsync(url, body);

        if (!response.IsSuccessStatusCode)
            throw new InvalidOperationException(await ReadFirebaseErrorAsync(response));

        return await response.Content.ReadFromJsonAsync<AuthResponse>();
    }

    private async Task<AuthResponse?> UpdateProfileAsync(string idToken, string displayName)
    {
        string url = $"https://identitytoolkit.googleapis.com/v1/accounts:update?key={_apiKey}";

        var body = new
        {
            idToken,
            displayName,
            returnSecureToken = true
        };

        var response = await _httpClient.PostAsJsonAsync(url, body);

        if (!response.IsSuccessStatusCode)
            throw new InvalidOperationException(await ReadFirebaseErrorAsync(response));

        return await response.Content.ReadFromJsonAsync<AuthResponse>();
    }

    private static async Task<string> ReadFirebaseErrorAsync(HttpResponseMessage response)
    {
        string json = await response.Content.ReadAsStringAsync();

        try
        {
            using var doc = JsonDocument.Parse(json);
            string code = doc.RootElement.GetProperty("error").GetProperty("message").GetString() ?? "UNKNOWN_ERROR";

            return code switch
            {
                "EMAIL_EXISTS" => "Email đã được sử dụng.",
                "EMAIL_NOT_FOUND" => "Email chưa được đăng ký.",
                "INVALID_PASSWORD" => "Mật khẩu không đúng.",
                "INVALID_LOGIN_CREDENTIALS" => "Email hoặc mật khẩu không đúng.",
                "WEAK_PASSWORD" => "Mật khẩu quá yếu, cần ít nhất 6 ký tự.",
                "OPERATION_NOT_ALLOWED" => "Chưa bật Email/Password trong Firebase Authentication.",
                "TOO_MANY_ATTEMPTS_TRY_LATER" => "Quá nhiều lần thử. Vui lòng thử lại sau.",
                var x when x.Contains("API key not valid", StringComparison.OrdinalIgnoreCase) => "Firebase API key không hợp lệ.",
                _ => code
            };
        }
        catch
        {
            return $"Firebase trả lỗi HTTP {(int)response.StatusCode}: {json}";
        }
    }
}