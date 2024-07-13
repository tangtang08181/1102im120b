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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.DayOfWeek.ToString() == "Saturday" || dateTimePicker1.Value.DayOfWeek.ToString() == "Sunday")
            {
                label1.Text = "假日，休息";
            }
            else if(dateTimePicker1.Value.DayOfWeek.ToString() == "Monday")
            {
                label1.Text = "星期一，上課";
            }
            else if (dateTimePicker1.Value.DayOfWeek.ToString() == "Tuesday")
            {
                label1.Text = "星期二，上課";
            }
            else if (dateTimePicker1.Value.DayOfWeek.ToString() == "Wednesday")
            {
                label1.Text = "星期三，上課";
            }
            else if (dateTimePicker1.Value.DayOfWeek.ToString() == "Thursday")
            {
                label1.Text = "星期四，上課";
            }
            else if (dateTimePicker1.Value.DayOfWeek.ToString() == "Friday")
            {
                label1.Text = "星期五，上課";
            }
        }
    }
}
