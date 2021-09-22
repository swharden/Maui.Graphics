using System.Windows;
namespace QuickstartWpf;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MyGraphicsView.Drawable = new MyDrawable();
        Loaded += (_, _) => MyGraphicsView.Invalidate();
    }
}