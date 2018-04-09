using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCoverUtility
{
    public partial class Browser : Form
    {
        private readonly string Uri;

        public Browser(string Uri)
        {
            this.Uri = Uri;
            InitializeComponent();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "index.htm")));
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
