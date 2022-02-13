---
Title: Maui.Graphics Console Quickstart
Description: How to use Maui.Graphics in a Console Application
---
 
### Create a Console Application

```
dotnet new console
```

### Get the Maui.Graphics Package

Add the [Microsoft.Maui.Graphics](https://www.nuget.org/packages/Microsoft.Maui.Graphics) package from NuGet. This command gets the latest pre-release package:

```
dotnet add package Microsoft.Maui.Graphics
dotnet add package Microsoft.Maui.Graphics.Skia
```

### Draw Graphics and Save PNG

Create a bitmap export context, interact with its canvas, then save the output as an image file:

```cs
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
```

### Output

<div class="text-center">

![](console.png)

</div>

## Source Code

* https://github.com/swharden/Maui.Graphics/tree/main/projects

## Resources
* https://maui.graphics
* [Drawing with Maui.Graphics](https://swharden.com/blog/2021-09-10-maui-graphics)
* [Microsoft.Maui.Graphics](https://github.com/dotnet/Microsoft.Maui.Graphics) project on GitHub