using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace RemoteHostApp.Helpers;

public static class ImageHelper
{
    // Cache codec 1 lần khi khởi động — không allocate array mỗi frame
    private static readonly ImageCodecInfo JpegCodec =
        ImageCodecInfo.GetImageEncoders()
            .First(c => c.FormatID == ImageFormat.Jpeg.Guid);

    // Reuse MemoryStream — tránh GC pressure khi chạy 30fps
    private static readonly MemoryStream _ms = new(1024 * 512); // pre-alloc 512KB

    public static (string Base64, int Width, int Height)
    ResizeAndCompress(Bitmap source, int maxWidth = 1280, int quality = 60)
    {
        int srcW = source.Width, srcH = source.Height;
        int dstW = srcW, dstH = srcH;

        if (srcW > maxWidth)
        {
            dstW = maxWidth;
            dstH = (int)(srcH * ((double)maxWidth / srcW));
        }

        using var resized = new Bitmap(dstW, dstH, PixelFormat.Format24bppRgb);
        using (var g = Graphics.FromImage(resized))
        {
            //Chất lượng cao -> chậm
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
            //g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;

            g.DrawImage(source, 0, 0, dstW, dstH);
        }

        var encoderParams = new EncoderParameters(1);
        encoderParams.Param[0] = new EncoderParameter(Encoder.Quality, (long)quality);

        // Reuse stream: reset về 0 thay vì tạo mới
        _ms.SetLength(0);
        resized.Save(_ms, JpegCodec, encoderParams);

        return (Convert.ToBase64String(_ms.GetBuffer(), 0, (int)_ms.Length), dstW, dstH);
    }
}