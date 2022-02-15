using System;
using Microsoft.Maui.Graphics;

namespace GraphicsModels
{
    public class RandomCircles 
    {
        private readonly Random Rand = new Random();

        public void Draw(ICanvas canvas, int width, int height)
        {
            canvas.FillColor = Color.FromArgb("#003366");
            canvas.FillRectangle(0, 0, width, height);

            for (int i = 0; i < 500; i++)
            {
                canvas.FillColor = Color.FromRgba(
                    r: Rand.NextDouble(),
                    g: Rand.NextDouble(),
                    b: Rand.NextDouble(),
                    a: .5);

                canvas.FillCircle(
                    centerX: (float)Rand.NextDouble() * width,
                    centerY: (float)Rand.NextDouble() * height,
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
                x: width / 2,
                y: height / 2,
                horizontalAlignment: HorizontalAlignment.Center);
        }
    }
}
