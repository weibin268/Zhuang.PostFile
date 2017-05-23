using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Zhuang.PostFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();

            var resData = wc.UploadFile(System.Configuration.ConfigurationManager.AppSettings["server-url"]
                , tbUrl.Text);

            var result = Encoding.UTF8.GetString(resData);

            MessageBox.Show(result);

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbUrl.Text = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
