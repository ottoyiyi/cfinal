using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cfinal
{
    public partial class Form1 : Form
    {
        string _checkbox_log = "";
        int Money = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true)
            {
                _checkbox_log += checkBox1.Text+comboBox1.SelectedItem.ToString()+"\r\n";
                Money += 90;
            }
            if (checkBox2.Checked == true)
            {
                _checkbox_log += checkBox2.Text+comboBox2.SelectedItem.ToString()+"\r\n";
                Money += 100;
            }
            if (checkBox3.Checked == true)
            {
                _checkbox_log += checkBox3.Text+comboBox3.SelectedItem.ToString()+"\r\n";
                Money += 110;
            }
            if (checkBox4.Checked == true)
            {
                _checkbox_log += checkBox4.Text+comboBox4.SelectedItem.ToString()+"\r\n";
                Money += 120;
            }
            if (checkBox5.Checked == true)
            {
                _checkbox_log += checkBox5.Text+comboBox5.SelectedItem.ToString()+"\r\n";
                Money += 150;
            }
            if (checkBox6.Checked == true)
            {
                _checkbox_log += checkBox6.Text+comboBox6.SelectedItem.ToString()+"\r\n";
                Money += 200;
            }
            richTextBox1.Text = _checkbox_log+"\r\n"+"總計:"+ Money+ " 元" ;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is about");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("點餐成功");
            DataGridViewRowCollection rows = dataGridView1.Rows;

            DateTime date = DateTime.Now; // 現在時間

            rows.Add(new Object[] { "", date.ToString("yyyy/MM/dd HH:mm:ss"), _checkbox_log,Money });
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
