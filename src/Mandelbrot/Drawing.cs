using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.Xml.Serialization;

namespace Mandelbrot
{
    public partial class Drawing : UserControl
    {
        public delegate void DelegateWriteInfo(string pText);
        public delegate void DelegateSetPixel(Bitmap b, int s, int z, Color col);

        private Thread t = null;
        private double _xmin = -2.1;
        private double _ymin = -1.3;
        private double _xmax = 1;
        private double _ymax = 1.3;
        private Bitmap bq = null;
        private Point pStart = Point.Empty;
        private Point pFinish = Point.Empty;
        private int _CurColMap = 0;
        private double _iterations = 100.0;
        private bool _liveRender = true;

        public bool LiveRender
        {
            get { return _liveRender; }
            set { _liveRender = value; }
        }

        private string[] ColMaps
        {
            get { return System.IO.Directory.GetFiles(Application.StartupPath + "\\Colors", "*.ColorMap"); }
            set { ColMaps = value; }
        }
        private bool _showAxis = false;

        public frmMain frm;

        public Thread T
        {
            get { return t; }
        }

        public double Iterations
        {
            get { return _iterations; }
            set { _iterations = value; }
        }

        public bool ShowAxis
        {
            get { return _showAxis; }
            set { _showAxis = value; }
        }

        public double Xmin
        {
            get { return _xmin; }
            set { _xmin = value; }
        }

        public double Ymin
        {
            get { return _ymin; }
            set { _ymin = value; }
        }

        public double Xmax
        {
            get { return _xmax; }
            set { _xmax = value; }
        }

        public double Ymax
        {
            get { return _ymax; }
            set { _ymax = value; }
        }

        public int CurColMap
        {
            get { return _CurColMap; }
            set {
                if (value < 0)
                    _CurColMap = 0;
                else
                    _CurColMap = value;
            }
        }

        public Drawing()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            t = new Thread(DrawMandel);
            t.Start();
            var ts = new Thread(WaitForThread);
            ts.Start();
        }

        public void Reset()
        {
            if (!t.IsAlive)
            {
                _xmin = -2.1;
                _ymin = -1.3;
                _xmax = 1;
                _ymax = 1.3;
                UpdateFrmMain();
                t = new Thread(DrawMandel);
                t.Start();
                var ts = new Thread(WaitForThread);
                ts.Start();
            }
        }

        private void WaitForThread()
        {
            while (t.IsAlive)
            {
                Invoke(new DelegateWriteInfo(WriteInfo), "Mandelbrot - Calculating...");
                Thread.Sleep(200);
            }
            Invoke(new DelegateWriteInfo(WriteInfo), "Mandelbrot - Ready " + ((int)(Math.Abs((float)(3.1 / (_xmax - _xmin))))) + "x Magnification");
            Application.DoEvents();
            Invalidate();
        }

        private void WriteInfo(string pText)
        {
            frm.Text = pText;
        }

        private void SetPixel(Bitmap b, int s, int z, Color col)
        {
            b.SetPixel(s, z, col);
            if (s % 20 == 0)
                frm.UpdateStatus((int)(((double)s / Width) * 100));
            else if (s == Width - 1)
                frm.UpdateStatus(0);
        }

        private void OnlySetPixel(Bitmap b, int s, int z, Color col)
        {
            b.SetPixel(s, z, col);
        }

        private void DrawMandel()
        {
            Color[] cs = GetColors(ColMaps[_CurColMap]);
            
            // Creates the Bitmap we draw to
            var b = new Bitmap(Width, Height);

            int s;
            var intigralX = (_xmax - _xmin) / Width;
            double intigralY = (_ymax - _ymin) / Height;
            
            double x = _xmin;
            for (s = 1; s < Width; s++)
            {
                double y = _ymin;
                bool crossYAxis;
                bool isMinus;
                int z;
                for (z = 1; z < Height; z++)
                {
                    double x1 = 0;
                    double y1 = 0;
                    int looper = 0;
                    while (looper < _iterations && Math.Sqrt((x1 * x1) + (y1 * y1)) < 2)
                    {
                        looper++;
                        double xx = (x1 * x1) - (y1 * y1) + x;
                        y1 = 2 * x1 * y1 + y;
                        x1 = xx;
                    }

                    // Get the percent of where the looper stopped
                    double perc = looper / (_iterations);
                    // Get that part of a 255 scale
                    int val = ((int)(perc * 255));
                    // Use that number to set the color
                    if (_liveRender)
                        Invoke(new DelegateSetPixel(SetPixel), new object[] { b, s, z, cs[val] });
                    else
                        b.SetPixel(s, z, cs[val]);
                    if (_showAxis)
                    {
                        isMinus = (y < 0);
                        y += intigralY;
                        crossYAxis = isMinus && y >= 0;

                        if (crossYAxis)
                            for (int i = 1; i < Width; i++)
                            {
                                if (_liveRender)
                                    Invoke(new DelegateSetPixel(SetPixel), new object[] { b, i, z, Color.White });
                                else
                                    b.SetPixel(i, z, Color.White);
                            }
                    }
                    else
                        y += intigralY;
                }
                if (_showAxis)
                {
                    isMinus = (x < 0);
                    x += intigralX;
                    crossYAxis = isMinus && x >= 0;

                    if (crossYAxis)
                        for (int i = 1; i < Height; i++)
                        {
                            if (_liveRender)
                                Invoke(new DelegateSetPixel(SetPixel), new object[] { b, s, i, Color.White });
                            else
                                b.SetPixel(s, i, Color.White);
                        }
                }
                else
                    x += intigralX;
                bq = b; // bq is a globally defined bitmap
                BackgroundImage = bq; // Draw it to the form
                if (s % 30 == 0 && _liveRender)
                    Invalidate();
            }            
        }


        private Color[] GetColors(string Path)
        {
            try
            {
                var c = new Color[256];
                var sr = new System.IO.StreamReader(Path);
                var lines = new ArrayList();
                var s = sr.ReadLine();
                while (s != null)
                {
                    lines.Add(s);
                    s = sr.ReadLine();
                }
                int i;
                for (i = 0; i < Math.Min(256, lines.Count); i++)
                {
                    var curC = (string)lines[i];
                    var temp = Color.FromArgb(int.Parse(curC.Split(' ')[0]), int.Parse(curC.Split(' ')[1]), int.Parse(curC.Split(' ')[2]));
                    c[i] = temp;
                }
                for (var j = i; j < 256; j++)
                {
                    c[j] = Color.White;
                }
                return c;
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid ColorMap file.", ex);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    pStart = new Point(e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    Reset();
                    break;
                default:
                    if (!t.IsAlive)
                    {
                        _CurColMap++;
                        if (_CurColMap == ColMaps.Length)
                        {
                            _CurColMap = 0;
                        }
                        t = new Thread(DrawMandel);
                        t.Start();
                        var ts = new Thread(WaitForThread);
                        ts.Start();
                    }
                    break;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var temp = new Point(e.X, pStart.Y + ((int)(((Height - 28) / (Width * 1.0)) * (e.X - pStart.X))));
            var rect = Rectangle.FromLTRB(pStart.X, pStart.Y, temp.X, temp.Y);
            var bp = new Bitmap(Width, Height);
            var g = Graphics.FromImage(bp);
            g.DrawImage(bq, 0, 0);
            g.DrawRectangle(new Pen(Brushes.Red, 3), rect);
            BackgroundImage = null;
            BackgroundImage = bp;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            pFinish = new Point(e.X, pStart.Y + ((int)(((Height - 28) / (Width * 1.0)) * (e.X - pStart.X))));
            if (pFinish != pStart)
            {
                double distX = _xmax - _xmin;
                double distY = _ymax - _ymin;
                double oSx = _xmin;
                double oSy = _ymin;
                _xmin = (pStart.X / (Width * 1.0)) * distX;
                _xmin += oSx;
                _xmax = (pFinish.X / (Width * 1.0)) * distX;
                _xmax += oSx;
                _ymin = (pStart.Y / (Height * 1.0)) * distY;
                _ymin += oSy;
                _ymax = (pFinish.Y / (Height * 1.0)) * distY;
                _ymax += oSy;
                UpdateFrmMain();
                t = new Thread(DrawMandel);
                t.Start();
                var ts = new Thread(WaitForThread);
                ts.Start();
            }
        }

        private void UpdateFrmMain()
        {
            frm.txtXmin.Text = _xmin.ToString();
            frm.txtXmax.Text = _xmax.ToString();
            frm.txtYmin.Text = _ymin.ToString();
            frm.txtYmax.Text = _ymax.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                SaveXML();
            }
            else if (e.KeyCode == Keys.O && e.Control)
            {
                OpenXML();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetDataObject(bq, true);
            }
        }

        public void SaveImage()
        {
            var lSaveFileDialog = new SaveFileDialog {Filter = "Bitmap File (*.bmp)|*.bmp"};
            if (lSaveFileDialog.ShowDialog(this) == DialogResult.OK)
                bq.Save(lSaveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        public void SaveXML()
        {
            var ms = new MandelSettings
                {
                    StartX = _xmin,
                    StartY = _ymin,
                    FinishX = _xmax,
                    FinishY = _ymax,
                    ColorFile = ColMaps[_CurColMap],
                    FractalName = frmInputBox.ShowInputBox("What do you want to name the fractal?", "Mandel")
                };
            var xs = new XmlSerializer(typeof(MandelSettings));
            var sw = new System.IO.StreamWriter(Application.StartupPath + "\\" + ms.FractalName + ".xml", false);
            xs.Serialize(sw.BaseStream, ms);
            sw.Close();
        }

        public void OpenXML()
        {
            var ofd = new OpenFileDialog {Filter = "Xml Files (*.xml)|*.xml|All Files (*.*)|*.*"};
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                var sr = new System.IO.StreamReader(path);
                var xs = new XmlSerializer(typeof(MandelSettings));
                var ms = (MandelSettings)xs.Deserialize(sr.BaseStream);
                sr.Close();
                _xmin = ms.StartX;
                _ymin = ms.StartY;
                _ymax = ms.FinishY;
                _xmax = ms.FinishX;
                var f = new System.IO.FileInfo(ms.ColorFile);
                //ColMaps = System.IO.Directory.GetFiles(f.DirectoryName);
                for (int i = 0; i < ColMaps.Length; i++)
                {
                    if (ColMaps[i] == ms.ColorFile)
                    {
                        _CurColMap = i;
                        break;
                    }
                }
                t = new Thread(DrawMandel);
                t.Start();
                var ts = new Thread(WaitForThread);
                ts.Start();
            }
        }
    }
}
