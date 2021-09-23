using System.Windows.Forms;

namespace QuickstartWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gdiGraphicsView1.Drawable = new GraphicsModels.RandomCircles();
            gdiGraphicsView1.SizeChanged += (_, _) => gdiGraphicsView1.Invalidate();
        }
    }
}
