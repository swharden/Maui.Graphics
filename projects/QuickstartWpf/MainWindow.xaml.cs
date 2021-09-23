using System.Windows;
namespace QuickstartWpf;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        MyGraphicsView.Drawable = new GraphicsModels.RandomCircles();
        Loaded += (_, _) => MyGraphicsView.Invalidate();
    }
}