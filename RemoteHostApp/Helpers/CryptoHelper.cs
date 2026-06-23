using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RemoteHostApp.Helpers; // Đổi thành RemoteViewerApp.Helpers cho bên Viewer

/// <summary>
/// Mã hóa/giải mã AES-256-CBC.
/// Key 32 bytes, IV ngẫu nhiên 16 bytes gắn đầu mỗi chuỗi Base64 được mã hóa.
/// 
/// Dùng chung một SESSION_KEY giữa Host và Viewer.
/// Thực tế nên trao đổi key qua Diffie-Hellman hoặc server API —
/// ở đây dùng key cố định để đơn giản hoá demo.
/// </summary>
public static class CryptoHelper
{
    // Key 32 bytes (AES-256). Cả Host và Viewer phải dùng cùng key này.
    // Trong thực tế: trao đổi key an toàn qua HTTPS khi bắt đầu session.
    private static readonly byte[] SessionKey =
        Encoding.UTF8.GetBytes("RemoteDesktop_AES256_SecretKey!!");  // đúng 32 ký tự

    /// <summary>
    /// Mã hóa chuỗi plain text → Base64 (IV + ciphertext).
    /// IV ngẫu nhiên 16 bytes được gắn ở đầu để tránh ciphertext giống nhau
    /// dù plaintext giống nhau (mỗi frame ảnh mã hóa ra khác nhau).
    /// </summary>
    public static string Encrypt(string plainText)
    {
        using var aes = Aes.Create();
        aes.Key  = SessionKey;
        aes.Mode = CipherMode.CBC;
        aes.GenerateIV();                      // IV ngẫu nhiên mỗi lần

        using var encryptor = aes.CreateEncryptor();
        var plainBytes = Encoding.UTF8.GetBytes(plainText);
        var cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

        // Ghép IV (16 bytes) + ciphertext rồi Base64
        var combined = new byte[aes.IV.Length + cipherBytes.Length];
        Buffer.BlockCopy(aes.IV,       0, combined, 0,             aes.IV.Length);
        Buffer.BlockCopy(cipherBytes,  0, combined, aes.IV.Length, cipherBytes.Length);

        return Convert.ToBase64String(combined);
    }

    /// <summary>
    /// Giải mã Base64 (IV + ciphertext) → plain text gốc.
    /// </summary>
    public static string Decrypt(string encryptedBase64)
    {
        var combined = Convert.FromBase64String(encryptedBase64);

        var iv          = new byte[16];
        var cipherBytes = new byte[combined.Length - 16];
        Buffer.BlockCopy(combined, 0,  iv,          0, 16);
        Buffer.BlockCopy(combined, 16, cipherBytes, 0, cipherBytes.Length);

        using var aes = Aes.Create();
        aes.Key  = SessionKey;
        aes.IV   = iv;
        aes.Mode = CipherMode.CBC;

        using var decryptor = aes.CreateDecryptor();
        var plainBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

        return Encoding.UTF8.GetString(plainBytes);
    }
}
