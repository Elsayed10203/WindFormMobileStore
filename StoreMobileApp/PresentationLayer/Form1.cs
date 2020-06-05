using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using StoreMobileApp.PresentationLayer;

namespace StoreMobileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            iconrestaurar_Click(null,null);
            pictureBox1_Click(null,null);
            panal_left.Visible = false;

        }

        private void Butt_Hum_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width>=200)
            {
                MenuVertical.Width = 80;
               panal_left.Visible = true;
            }
            else
            {
                MenuVertical.Width = 217;
               panal_left.Visible = false;

            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int LX, LY;
        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.LX = this.Location.X;
            this.LY = this.Location.Y;
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.Location = new Point(LX, LY);
            //  this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1250, 650);
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContainer.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.LX = this.Location.X;
            this.LY = this.Location.Y;
            //this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void FormContainer(object Formhijo)
        {         
             if (this.panel_med.Controls.Count > 0)
             this.panel_med.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
          
             this.panel_med.Controls.Add(fh);
            this.panel_med.Tag = fh;
            fh.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            FormContainer(new FrmCatag());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormContainer(new formsAllcs());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormContainer(new FrmSupReport());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormContainer(new FrmService());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormContainer(new Frmdevice());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormContainer(new frmSupliers());

        }
    } 
}
