using OpenCoverLibrary;
using OpenCoverLibrary.NUnitRunner;
using OpenCoverLibrary.ReportGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCoverUtility
{
    public partial class OpenCoverUtility : Form
    {
        public OpenCoverUtility()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtSourceDirectory.Text = dialog.SelectedPath;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (txtSourceDirectory.Text.Trim() != String.Empty)
            {
                DLLUtilities utilities = new DLLUtilities();

                var list = utilities.ListAllDLLFiles<string>(txtSourceDirectory.Text, int.Parse(txtScanningDepth.Text));


                list.Sort(delegate (string a, string b)
                {
                    bool TestKeywordFoundInA, TestKeywordFoundInB;

                    TestKeywordFoundInA = a.ToLower().IndexOf("test") >= 0;
                    TestKeywordFoundInB = b.ToLower().IndexOf("test") >= 0;

                    if (TestKeywordFoundInA != TestKeywordFoundInB)
                        if (TestKeywordFoundInA == true)
                            return -100;
                        else
                            return 100;
                    else
                        return Path.GetFileName(a).CompareTo(Path.GetFileName(b));
                });

                Dictionary<string, string> comboSource = new Dictionary<string, string>();
                foreach (var item in list)
                {
                    comboSource.Add(item.Substring(txtSourceDirectory.Text.Length), item);
                }

                cbDll.DataSource = new BindingSource(comboSource, null);
                cbDll.DisplayMember = "Key";
                cbDll.ValueMember = "Value";

                if (cbDll.Items.Count > 0)
                    cbDll.SelectedIndex = 0;

                //MessageBox.Show(((KeyValuePair<string, string>)cbDll.SelectedItem).Value);
            }
        }

        private void btnCodeCoverage_Click(object sender, EventArgs e)
        {
            NUnitRunner nUnitRunner = new NUnitRunner(@"opencover.4.6.519\OpenCover.Console.exe", @"NUnit.Console-3.8.0\nunit3-console.exe");
            nUnitRunner.RunDLL(((KeyValuePair<string, string>)cbDll.SelectedItem).Value, "coverage.xml");

            ReportGenerator reportGenerator = new ReportGenerator(@"ReportGenerator_3.1.2.0\ReportGenerator.exe");
            reportGenerator.Generate("coverage.xml", txtSourceDirectory.Text);

            Browser browser = new Browser("index.htm");
            browser.Show();
        }
    }
}
