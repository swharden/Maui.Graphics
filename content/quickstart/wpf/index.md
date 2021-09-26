---
Title: WPF Quickstart - Maui.Graphics
Description: How to use Maui.Graphics in a WPF application
Date: 2021-09-21
---

# Maui.Graphics WPF Quickstart

This page demonstrates how to use Maui.Graphics in a WPF application. 

<div class='text-center img-border'>

![](maui-graphics-quickstart-wpf.png)

</div>

## Steps

> **WARNING:** At the time of writing Microsoft.Maui.Graphics is still in pre-release and the WPF control is not available as a NuGet package. This is likely to get easier in the future.

* Create a WPF application
* Add NuGet packages
  * [Microsoft.Maui.Graphics](https://www.nuget.org/packages/Microsoft.Maui.Graphics)
  * [Microsoft.Maui.Graphics.Skia](https://www.nuget.org/packages/Microsoft.Maui.Graphics.Skia)
* Add WPF control package from source
  * [Microsoft.Maui.Graphics.Skia.WPF](https://github.com/dotnet/Microsoft.Maui.Graphics/tree/main/src/Microsoft.Maui.Graphics.Skia.WPF) (it's not on NuGet yet)
* Create a `Drawable` that describes what you want to render
* Place a `WDSkiaGraphicsView` in your layout
* Create a `Drawable` and assign it to `WDSkiaGraphicsView`
* Add a `Loaded` event to invalidate the control (forcing a render at launch)

## MyDrawable.cs
```cs
using Microsoft.Maui.Graphics;
using System;

public class MyDrawable : IDrawable
{
    private readonly Random Rand = new();

    public void Draw(ICanvas canvas, RectangleF dirtyRect)
    {
        canvas.FillColor = Color.FromArgb("#003366");
        canvas.FillRectangle(dirtyRect);

        for (int i = 0; i < 500; i++)
        {
            canvas.FillColor = Color.FromRgba(
                r: Rand.NextDouble(),
                g: Rand.NextDouble(),
                b: Rand.NextDouble(),
                a: .5);

            canvas.FillCircle(
                centerX: (float)Rand.NextDouble() * dirtyRect.Width,
                centerY: (float)Rand.NextDouble() * dirtyRect.Height,
                radius: (float)Rand.NextDouble() * 5 + 5);
        }

        canvas.FontSize = 36;
        canvas.FontColor = Colors.White;
        canvas.SetShadow(
            offset: new SizeF(2, 2),
            blur: 1,
            color: Colors.Black);

        canvas.DrawString(
            value: "This is Maui.Graphics",
            x: dirtyRect.Width / 2,
            y: dirtyRect.Height / 2,
            horizontalAlignment: HorizontalAlignment.Center);
    }
}
```

## MainWindow.xaml

```xml
<Window x:Class="QuickstartWpf.MainWindow"
        ...
        xmlns:Skia="clr-namespace:Microsoft.Maui.Graphics.Skia;assembly=Microsoft.Maui.Graphics.Skia.WPF"
        Title="Maui.Graphics Quickstart - WPF (Skia)" Height="300" Width="400">
    <Grid>
        <Skia:WDSkiaGraphicsView Name="MyGraphicsView" />
    </Grid>
</Window>
```

## MainWindow.xaml.cs

* 💡 Invaliding the control after the window is loaded forces it to draw after the program starts

```cs
using System.Windows;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MyGraphicsView.Drawable = new MyDrawable();
        Loaded += (_, _) => MyGraphicsView.Invalidate();
    }
}
```

## Source Code

* https://github.com/swharden/Maui.Graphics/tree/main/projects

## Resources
* https://maui.graphics
* [Drawing with Maui.Graphics](https://swharden.com/blog/2021-09-10-maui-graphics)
* [Microsoft.Maui.Graphics](https://github.com/dotnet/Microsoft.Maui.Graphics) project on GitHub