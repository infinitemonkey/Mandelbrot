using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Mandelbrot
{
    public partial class frmMakeColor : Form
    {
        public frmMakeColor()
        {
            InitializeComponent();
        }

        private void MakeColorFile(Color[] colors, string fName)
        {
            if (colors.Length == 0)
            {
                throw new Exception("Need at least 2 colors for ColorMap file.");
            }
            var b = new Bitmap(256, 1);
            Graphics g = Graphics.FromImage(b);
            if (colors.Length == 1)
            {
                g.DrawLine(new Pen(colors[0], 200), 0, 0, 256, 0);
            }
            else
            {
                int colLen = 256 / (colors.Length - 1);
                for (int i = 0; i < colors.Length - 1; i++)
                {
                    var lgb = new LinearGradientBrush(new Point(i * colLen, 0), new Point((i + 1) * colLen, 0), colors[i], colors[i + 1]);
                    g.DrawLine(new Pen(lgb, 200), new Point(i * colLen, 0), new Point((i + 1) * colLen, 0));
                    lgb.Dispose();
                }
            }
            var sw = new System.IO.StreamWriter(Application.StartupPath + "\\Colors\\" + fName + ".ColorMap", false);
            for (var i = 0; i < 256; i++)
            {
                string s = b.GetPixel(i, 0).R.ToString() + " " + b.GetPixel(i, 0).G.ToString() + " " + b.GetPixel(i, 0).B.ToString();
                sw.WriteLine(s);
            }
            sw.Close();
            BackgroundImage = b;
            //b.Dispose();
            //b = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //MakeColorFile(new Color[2] { Color.Yellow, Color.FromArgb(255, 52, 173) }, "NewColor");
            MakeColorFile(new Color[6] 
                        { 
                            lblColor1.ForeColor, 
                            lblColor2.ForeColor, 
                            lblColor3.ForeColor, 
                            lblColor4.ForeColor,
                            lblColor5.ForeColor,
                            lblColor6.ForeColor
                        }, txtName.Text);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
                Controls.Find("lblColor" + btn.Name.Substring("btnColor".Length, 1), true)[0].ForeColor = colorDialog.Color;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
