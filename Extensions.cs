using System;
using SkiaSharp;

namespace Wpf.Blazor;

public static class Extensions
{
    public static string? ToBase64Image(this SKBitmap bmp)
    {
        using var image = SKImage.FromBitmap(bmp);
        using var data = image.Encode(SKEncodedImageFormat.Png, 100);

        return "data:image/png;base64," + Convert.ToBase64String(data.ToArray());
    }
}