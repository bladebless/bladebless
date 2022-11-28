using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using МДК_0101.Properties;

namespace МДК_0101
{
    public partial class Form1 : Form
    {
        Size Screen = SystemInformation.PrimaryMonitorSize;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = SystemInformation.VirtualScreen.Width + "x" + SystemInformation.VirtualScreen.Height;
            textBox1.ReadOnly = true;
            Form f = new Form();
            int a = f.Size.Width, b = f.Size.Height;
            this.textBox1.Text = a + "x" + b;
        }

        private void buttonRndColor_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }

        private void buttonInc_Click(object sender, EventArgs e)
        {
            this.Size = new Size(Width + 50, Height + 50);

        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            this.Size = new Size(Width - 50, Height - 50);
        }

        private void buttonCT_Click(object sender, EventArgs e)
        {
            Location = new Point((Screen.Width - Width) / 2, 0);
        }

        private void buttonRT_Click(object sender, EventArgs e)
        {
            Location = new Point(Screen.Width - Width, 0);
        }

        private void buttonLC_Click(object sender, EventArgs e)
        {
            Location = new Point(0, (Screen.Height - Height) / 2);
        }

        private void buttonCC_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void buttonRC_Click(object sender, EventArgs e)
        {
            Location = new Point(Screen.Width - Width, (Screen.Height - Height) / 2);
        }

        private void buttonLB_Click(object sender, EventArgs e)
        {
            Location = new Point(0, Screen.Height - Height);
        }

        private void buttonCB_Click(object sender, EventArgs e)
        {
            Location = new Point((Screen.Width - Width) / 2, Screen.Height - Height);
        }

        private void buttonRB_Click(object sender, EventArgs e)
        {
            Location = new Point(Screen.Width - Width, Screen.Height - Height);
        }

        private void buttonLT_Click(object sender, EventArgs e)
        {
            Location = new Point(0, 0);

        }

        private void buttonFull_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonDefult_Click(object sender, EventArgs e)
        {
            this.Size = MinimumSize;
            this.WindowState = FormWindowState.Normal;
            CenterToScreen();
        }

        private void buttonRollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.textBox1.Text = this.Width + "x" + this.Height;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.3;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void красивыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            

            //var img = new Bitmap(@"C:\Users\79920\Downloads\Stitch Cursors\Cursors\Arrow.cur");
            /*var img = new Bitmap(@"Arrow.cur");
            Icon icon = Icon.FromHandle(img.GetHicon());
            Cursor cur = new Cursor(icon.Handle);
            Cursor.Current = cur;
            this.Cursor = cur; */
        }
        private void классическийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
        }

        private void поменятьФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); //
            fileDialog.ShowDialog();
            var fileName = fileDialog.FileName;
            this.BackgroundImage = Image.FromFile(fileName);
        }

        private void запретитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void разрешитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void измениеРазмераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (измениеРазмераToolStripMenuItem.Checked == true)
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                измениеРазмераToolStripMenuItem.Checked = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                измениеРазмераToolStripMenuItem.Checked = true;
            }
        }
    }
}