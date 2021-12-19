using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
namespace GPU_Bot_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            if (web.DownloadString("https://www.newegg.com/evga-geforce-rtx-3060-ti-08g-p5-3663-kr/p/N82E16814487535?Description=rtx%203060%20ti&cm_re=rtx_3060%20ti-_-14-487-535-_-Product").Contains("OUT OF STOCK"))
            {

                label4.Text = "STATUS: Sold Out!";



            } else if (web.DownloadString("https://www.newegg.com/evga-geforce-rtx-3060-ti-08g-p5-3663-kr/p/N82E16814487535?Description=rtx%203060%20ti&cm_re=rtx_3060%20ti-_-14-487-535-_-Product").Contains("In stock")) {

                label4.Text = "STATUS: IN STOCK! LAUNCHING NOW!";
                Process.Start("https://www.newegg.com/evga-geforce-rtx-3060-ti-08g-p5-3663-kr/p/N82E16814487535?Description=rtx%203060%20ti&cm_re=rtx_3060%20ti-_-14-487-535-_-Product");
                timer1.Stop();
                return;


            }
            
            WebClient web1 = new WebClient();
            if (web1.DownloadString("https://www.aztekcomputers.com/zta30610e10m-ZOTAC-1WUKSOB96EA.html").Contains("Out of Stock"))
            {

                label7.Text = "STATUS: Sold Out!";



            }
            else if (web1.DownloadString("https://www.aztekcomputers.com/zta30610e10m-ZOTAC-1WUKSOB96EA.html").Contains("In Stock"))
            {

                label7.Text = "STATUS: IN STOCK! LAUNCHING NOW!";
                Process.Start("https://www.aztekcomputers.com/zta30610e10m-ZOTAC-1WUKSOB96EA.html");
                timer1.Stop();
                return;


            }

        }
    }
}
