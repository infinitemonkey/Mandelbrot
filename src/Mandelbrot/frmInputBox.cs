using System.Drawing;
using System.Windows.Forms;

namespace Mandelbrot
{
    public class frmInputBox : Form
    {
        private TextBox textBox1;
        private Label label1;

        private System.ComponentModel.Container components = null;

        private frmInputBox(string question, string title)
        {
            InitializeComponent(question, title);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent(string question, string title)
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new Label();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Location = new Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(256, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = question;
            //
            // textBox1
            //
            this.textBox1.Location = new System.Drawing.Point(16, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            this.textBox1.KeyDown += new
                System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            //
            // InputBox
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 53);
            this.ControlBox = false;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBox1,
																		  this.label1});
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputBox";
            this.Text = "InputBox";
            this.ResumeLayout(false);

        }

        private void textBox1_KeyDown(object sender,
            System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Close();
        }

        public static string ShowInputBox(string Question, string Title)
        {
            frmInputBox box = new frmInputBox(Question, Title);
            box.ShowDialog();
            return box.textBox1.Text;
        }
    }
}
