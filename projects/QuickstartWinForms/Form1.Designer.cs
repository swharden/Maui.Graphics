
namespace QuickstartWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Maui.Graphics.Color color1 = new Microsoft.Maui.Graphics.Color();
            Microsoft.Maui.Graphics.GDI.GDIDirectGraphicsRenderer gdiDirectGraphicsRenderer1 = new Microsoft.Maui.Graphics.GDI.GDIDirectGraphicsRenderer();
            this.gdiGraphicsView1 = new Microsoft.Maui.Graphics.GDI.GDIGraphicsView();
            this.SuspendLayout();
            // 
            // gdiGraphicsView1
            // 
            this.gdiGraphicsView1.BackgroundColor = color1;
            this.gdiGraphicsView1.Dirty = false;
            this.gdiGraphicsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdiGraphicsView1.Drawable = null;
            this.gdiGraphicsView1.Location = new System.Drawing.Point(0, 0);
            this.gdiGraphicsView1.Name = "gdiGraphicsView1";
            gdiDirectGraphicsRenderer1.BackgroundColor = color1;
            gdiDirectGraphicsRenderer1.Dirty = false;
            gdiDirectGraphicsRenderer1.Drawable = null;
            this.gdiGraphicsView1.Renderer = gdiDirectGraphicsRenderer1;
            this.gdiGraphicsView1.Size = new System.Drawing.Size(384, 261);
            this.gdiGraphicsView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.gdiGraphicsView1);
            this.Name = "Form1";
            this.Text = "Maui.Graphics Quickstart - WinForms (GDI)";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Maui.Graphics.GDI.GDIGraphicsView gdiGraphicsView1;
    }
}

