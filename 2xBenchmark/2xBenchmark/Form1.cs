using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace _2xBenchmark

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

    private void btnRunBenchmark_Click(object sender, EventArgs e)
    {
        Process proc = null;
        try
            {
                string BatchDir = @Application.StartupPath;
                proc = new Process();
                proc.StartInfo.WorkingDirectory = BatchDir;
                proc.StartInfo.FileName = "bench.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception exc1)
            {
                Console.WriteLine(exc1.StackTrace);
            }
            // Read Text from txt File
            string workingdir = @Application.StartupPath;
            string txtname = string.Format(@"\test.txt");
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            string textfiledir = workingdir + txtname;
            string result = System.IO.File.ReadAllText(textfiledir);
            txtboxResultBox.Text += result;
    }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            txtboxResultBox.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtboxResultBox.SelectAll();
            txtboxResultBox.Focus();
            txtboxResultBox.Copy();
        }
    }
}
