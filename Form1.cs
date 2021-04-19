using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_praktika_10
{
  public partial class Form1 : Form
  {
    private float x1, x2, y1, y2;
    private double a;
    private SolidBrush pen = new SolidBrush(Color.Black);
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      g.FillEllipse(pen, x1, y1, x2, y2);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      x1 = ClientSize.Width / 4;
      y1 = ClientSize.Height / 2;
      x2 = ClientSize.Width / 2;
      y2 = ClientSize.Height / 2;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      a += 0.1;
      x2 = x1 + (int)(Math.Cos(a));
      y2 = y1 + (int)(Math.Cos(a));
      Invalidate();
    }
  }
}
