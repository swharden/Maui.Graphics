using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;

BitmapExportContext bmp = SkiaGraphicsService.Instance.CreateBitmapExportContext(600, 400);
SizeF bmpSize = new(bmp.Width, bmp.Height);
ICanvas canvas = bmp.Canvas;

canvas.FillColor = Colors.Navy;
canvas.FillRectangle(0, 0, bmpSize.Width, bmpSize.Height);

Random rand = new(0);
for (int i = 0; i < 1000; i++)
{
    canvas.StrokeColor = Colors.White.WithAlpha(.5f);
    canvas.DrawLine(
        x1: (float)rand.NextDouble() * bmpSize.Width,
        y1: (float)rand.NextDouble() * bmpSize.Height,
        x2: (float)rand.NextDouble() * bmpSize.Width,
        y2: (float)rand.NextDouble() * bmpSize.Height);
}

bmp.WriteToFile("console.png");