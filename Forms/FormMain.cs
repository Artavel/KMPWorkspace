using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        int panelWidth;
        bool Hidden;

        public FormMain()
        {
            InitializeComponent();
            SidePanel1.Height = button1.Height;
            SidePanel1.Top = button1.Top;
            panelWidth = panelSlide.Width;
            Hidden = false;
            userControlMain1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button1.Height;
            SidePanel1.Top = button1.Top;
            userControlMain1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button2.Height;
            SidePanel1.Top = button2.Top;
            userControlRW1.BringToFront();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button3.Height;
            SidePanel1.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button4.Height;
            SidePanel1.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button5.Height;
            SidePanel1.Top = button5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button6.Height;
            SidePanel1.Top = button6.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button7.Height;
            SidePanel1.Top = button7.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button8.Height;
            SidePanel1.Top = button8.Top;
        }

        private void sidebarButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelSlide.Width = panelSlide.Width + 10;
                if (panelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlide.Width = panelSlide.Width - 10;
                if (panelSlide.Width <= 70)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }
    }
}
