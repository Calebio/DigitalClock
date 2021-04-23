using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DcTimer_Tick(object sender, EventArgs e)
        {
            DcTime.Text = DateTime.Now.ToString("HH:mm");
            DcSeconds.Text = DateTime.Now.ToString("ss");
            DcDate.Text = DateTime.Now.ToString("MM dd yyyy");
            DcDay.Text = DateTime.Now.ToString("dddd");
            DcSeconds.Location = new Point(DcTime.Location.X + DcTime.Width, DcSeconds.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DcTimer.Start();
        }
    }
}
