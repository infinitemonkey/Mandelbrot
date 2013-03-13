using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Mandelbrot
{
    public partial class frmMain : Form
    {
        public delegate void DelegateWriteInfo(string pText);
        private Drawing Drawing = new Drawing();
        private Drawing Preview;

        public frmMain()
        {
            InitializeComponent();
            LoadColorSchemes();

            Preview = new Drawing
                {
                    frm = this,
                    Xmin = Convert.ToDouble(txtXmin.Text),
                    Xmax = Convert.ToDouble(txtXmax.Text),
                    Ymin = Convert.ToDouble(txtYmin.Text),
                    Ymax = Convert.ToDouble(txtYmax.Text),
                    Iterations = Convert.ToDouble(txtIter.Text),
                    Width = 60,
                    Height = 60,
                    CurColMap = cbColors.SelectedIndex
                };
            Preview.Draw();
            Preview.Location = new Point(lblPreview.Left + lblPreview.Width + 10, lblPreview.Top);
            Preview.Name = "DrawingPreview";
            grpDrawing.Controls.Add(Preview);
        }

        private void LoadColorSchemes()
        {
            foreach (string path in Directory.GetFiles(Application.StartupPath + "\\Colors", "*.ColorMap"))
                cbColors.Items.Add(Path.GetFileName(path).Split('.')[0]);
        }

        private void btnNewColor_Click(object sender, EventArgs e)
        {
            var frm = new frmMakeColor();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cbColors.Items.Clear();
                LoadColorSchemes();
            }   
        }

        public void UpdateStatus(int value)
        {
            btnAbort.Enabled = value > 0;
            progStatus.Value = value;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (Drawing.T == null || !Drawing.T.IsAlive)
                {
                    Controls.RemoveByKey("Drawing");
                    Drawing.frm = this;
                    Drawing.Xmin = Convert.ToDouble(txtXmin.Text);
                    Drawing.Xmax = Convert.ToDouble(txtXmax.Text);
                    Drawing.Ymin = Convert.ToDouble(txtYmin.Text);
                    Drawing.Ymax = Convert.ToDouble(txtYmax.Text);
                    Drawing.Iterations = Convert.ToDouble(txtIter.Text);
                    Drawing.Width = Convert.ToInt32(txtWidth.Text);
                    Drawing.Height = Convert.ToInt32(txtHeight.Text);
                    Drawing.CurColMap = cbColors.SelectedIndex;
                    Drawing.ShowAxis = checkAxis.Checked;
                    Drawing.LiveRender = checkLiveRender.Checked;
                    if (Width < Convert.ToInt32(txtWidth.Text))
                        Width = Convert.ToInt32(txtWidth.Text);
                    if (Height - (grpSettings.Top + grpSettings.Height + 20) < Convert.ToInt32(txtHeight.Text))
                        Height = Convert.ToInt32(txtHeight.Text) + grpSettings.Top + grpSettings.Height + 100;
                    Drawing.Location = new Point((Width - Convert.ToInt32(txtWidth.Text)) / 2, ((Height + (grpSettings.Top + grpSettings.Height)) - Convert.ToInt32(txtHeight.Text)) / 2);
                    Drawing.Name = "Drawing";
                    Controls.Add(Drawing);
                    btnReset.Enabled = true;
                    Drawing.Draw();
                }
            }
            catch (NullReferenceException err)
            {
                MessageBox.Show("Thread is in work: " + err.Message);
            }
        }

        private void cbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preview.Xmin = Convert.ToDouble(txtXmin.Text);
            Preview.Xmax = Convert.ToDouble(txtXmax.Text);
            Preview.Ymin = Convert.ToDouble(txtYmin.Text);
            Preview.Ymax = Convert.ToDouble(txtYmax.Text);
            Preview.Iterations = Convert.ToDouble(txtIter.Text);
            Preview.LiveRender = checkLiveRender.Checked;
            Preview.ShowAxis = checkAxis.Checked;
            Preview.CurColMap = cbColors.SelectedIndex;
            Preview.Draw();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Preview.Xmin = Convert.ToDouble(txtXmin.Text);
            Preview.Xmax = Convert.ToDouble(txtXmax.Text);
            Preview.Ymin = Convert.ToDouble(txtYmin.Text);
            Preview.Ymax = Convert.ToDouble(txtYmax.Text);
            Preview.Iterations = Convert.ToDouble(txtIter.Text);
            Preview.LiveRender = checkLiveRender.Checked;
            Preview.ShowAxis = checkAxis.Checked;
            Preview.CurColMap = cbColors.SelectedIndex;
            Preview.Draw();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drawing.SaveImage();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveXMLAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drawing.SaveXML();
        }

        private void openXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drawing.OpenXML();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Drawing.Reset();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            Drawing.T.Abort();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Drawing.T.Abort();
            Dispose();
        }


    }
}
