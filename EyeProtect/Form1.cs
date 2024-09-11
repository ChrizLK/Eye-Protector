using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeProtect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            timer1.Interval = 3600000; 
            timer1.Tick += Timer1_Tick;
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ShowNotification("Time to take a break!", "Eye Protector");
        }

        private void ShowNotification(string message, string title)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = SystemIcons.Warning;
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = message;
            notifyIcon.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon.ShowBalloonTip(30000); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MessageBox.Show("Eye Protector Started!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
