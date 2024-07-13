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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("卡號未填，請再試一次");
            }
            else
            {
                string txt = "";
                txt = txt + "卡號:" + textBox1.Text + "\n卡別:";
                if(radioButton1.Checked == true)
                {
                    txt = txt + radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    txt = txt + radioButton2.Text;
                }
                else if (radioButton3.Checked == true)
                {
                    txt = txt + radioButton3.Text;
                }
                txt = txt + "\n有效截止月年:" + comboBox1.Text + "月" + comboBox2.Text + "年\n授權碼:" + textBox2.Text + "\n你是從何處得知本項資訊?";
                if(checkBox1.Checked == true)
                {
                    txt = txt + "報紙";
                }
                if (checkBox2.Checked == true)
                {
                    txt = txt + "網路";
                }
                if (checkBox3.Checked == true)
                {
                    txt = txt + "電視";
                }
                if (checkBox4.Checked == true)
                {
                    txt = txt + "朋友";
                }
                if (checkBox5.Checked == true)
                {
                    txt = txt + "廣播";
                }
                if (checkBox6.Checked == true)
                {
                    txt = txt + "其他";
                }
                MessageBox.Show(txt);
            }
        }
    }
}
