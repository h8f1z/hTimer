using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hTimer
{
    public partial class MainForm : Form
    {
        private TimeSpan timerTime = new TimeSpan(0, 0, 0);
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            btnStartStop.Text = timer1.Enabled ? "Start" : "Stop";
            btnReset.Visible = timer1.Enabled && timerTime.CompareTo(new TimeSpan(0, 0, 0)) != 0;

            if (timer1.Enabled)
            {
                timer1.Stop();
                return;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTime = timerTime.Add(TimeSpan.FromSeconds(1.0));
            label1.Text = (timerTime).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timerTime = new TimeSpan(0, 0, 0);
            label1.Text = timerTime.ToString();
        }
    }
}
