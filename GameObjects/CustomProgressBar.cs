using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomProgressBar : ProgressBar
{
    private ProgressBar progressBar1;

    public Color ProgressColor { get; set; } = Color.Green;

    public CustomProgressBar()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
        InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rect = e.ClipRectangle;

        // Draw the background
        e.Graphics.FillRectangle(new SolidBrush(this.BackColor), rect);

        // Calculate and draw the progress
        rect.Width = (int)(rect.Width * ((double)Value / Maximum));
        e.Graphics.FillRectangle(new SolidBrush(ProgressColor), rect);
    }

    private void InitializeComponent()
    {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            this.ResumeLayout(false);

    }
}
