using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
            FileInfo f = new FileInfo(openFileDialog1.FileName);
            DirectoryInfo dir = new DirectoryInfo(f.DirectoryName);
            textBox2.Text = dir.Root.Name;
            textBox3.Text = dir.Name;
            textBox4.Text = Path.GetFileNameWithoutExtension(f.Name);
            textBox5.Text = f.Extension;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }
    }
}
