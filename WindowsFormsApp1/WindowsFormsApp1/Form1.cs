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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("蛋餅");
                listBox1.Items.Add("厚片吐司");
                listBox1.Items.Add("薄片吐司");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("總匯三明治");
                listBox1.Items.Add("雞腿堡");
                listBox1.Items.Add("牛肉起司堡");
            }
        }
        int count1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int count = listBox1.SelectedItems.Count;
            count1 = count1 + count;
            if (count != 0)
            {
                foreach (object o in listBox1.SelectedItems)
                {
                    listBox2.Items.Add(o.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總共有" + count1.ToString() + "份餐點");
        }
    }
}
