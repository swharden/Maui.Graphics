using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;
using System.Windows;
using System.Windows.Threading;

namespace QuickstartWpf
{
    public partial class MainWindow : Window
    {
        readonly GraphicsModels.RandomCircles GraphicsModel = new();
        readonly DispatcherTimer Timer1 = new();

        public MainWindow()
        {
            InitializeComponent();
            Timer1.Interval = System.TimeSpan.FromMilliseconds(10);
            Timer1.Tick += Timer1_Tick;
        }

        private void SKElement_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            ICanvas canvas = new SkiaCanvas() { Canvas = e.Surface.Canvas };
            GraphicsModel.Draw(canvas, SkElement1.ActualWidth, SkElement1.ActualHeight);
        }

        private void SKElement_SizeChanged(object sender, SizeChangedEventArgs e) => SkElement1.InvalidateVisual();
        private void Button_Click(object sender, RoutedEventArgs e) => SkElement1.InvalidateVisual();
        private void Timer1_Tick(object? sender, System.EventArgs e) => SkElement1.InvalidateVisual();
        private void Checkbox1_Checked(object sender, RoutedEventArgs e) => Timer1.Start();
        private void Checkbox1_Unchecked(object sender, RoutedEventArgs e) => Timer1.Stop();
    }
}