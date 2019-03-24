using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Tech_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

            SelectorMain.Width = MenuButton.Width;
            SelectorMain.Left = MenuButton.Left;
            dashboardCtrl1.BringToFront();
        }

        private void ToolsButton_Click(object sender, EventArgs e)
        {
            SelectorMain.Width = ToolsButton.Width;
            SelectorMain.Left = ToolsButton.Left;

            themeSet1.BringToFront();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MyAcBtn_Click(object sender, EventArgs e)
        {
            VPanal.Height = MyAcBtn.Height;
            VPanal.Top = MyAcBtn.Top;
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            VPanal.Height = DashboardBtn.Height;
            VPanal.Top = DashboardBtn.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DatabaseConnectionBt_Click(object sender, EventArgs e)
        {
            if (databaseSliderMenu1.Visible == false)
            {
                databaseSliderMenu1.Visible = true;
            }
            else if (databaseSliderMenu1.Visible == true)
            {
                databaseSliderMenu1.Visible = false;
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RecentBtn_Click(object sender, EventArgs e)
        {
            VPanal.Height = RecentBtn.Height;
            VPanal.Top = RecentBtn.Top;
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            VPanal.Height = AboutBtn.Height;
            VPanal.Top = AboutBtn.Top;
        }
        private void LogBtn_Click(object sender, EventArgs e)
        {
            VPanal.Height = LogBtn.Height;
            VPanal.Top = LogBtn.Top;
        }
    }
}
