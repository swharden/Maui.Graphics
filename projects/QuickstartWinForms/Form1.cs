using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;
using System;
using System.Windows.Forms;

namespace QuickstartWinForms
{
    public partial class Form1 : Form
    {
        readonly GraphicsModels.RandomCircles GraphicsModel = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void skglControl1_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e)
        {
            ICanvas canvas = new SkiaCanvas() { Canvas = e.Surface.Canvas };
            GraphicsModel.Draw(canvas, skglControl1.Width, skglControl1.Height);
        }

        private void skglControl1_SizeChanged(object sender, EventArgs e) => skglControl1.Invalidate();
        private void button1_Click(object sender, EventArgs e) => skglControl1.Invalidate();
        private void timer1_Tick(object sender, EventArgs e) => skglControl1.Invalidate();
        private void checkBox1_CheckedChanged(object sender, EventArgs e) => timer1.Enabled = checkBox1.Checked;
    }
}
