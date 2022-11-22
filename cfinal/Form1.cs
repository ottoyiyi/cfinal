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

            Form2 form2;
            form2 = new Form2();
            form2.ShowDialog();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _checkbox_log = "";
            Money = 0;
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
            if (checkBox7.Checked == true)
            {
                _checkbox_log += checkBox7.Text +"\r\n";
                Money += 50;
            }
            if (checkBox8.Checked == true)
            {
                _checkbox_log += checkBox8.Text + "\r\n";
                Money += 25;
            }
            if (checkBox9.Checked == true)
            {
                _checkbox_log += checkBox9.Text + "\r\n";
                Money += 15;
            }
            if (checkBox10.Checked == true)
            {
                _checkbox_log += checkBox10.Text + "\r\n";
                Money += 50;
            }
            if (checkBox11.Checked == true)
            {
                _checkbox_log += checkBox11.Text + "\r\n";
                Money += 35;
            }
            if (checkBox12.Checked == true)
            {
                _checkbox_log += checkBox12.Text + "\r\n";
                Money += 40;
            }
            if (checkBox13.Checked == true)
            {
                _checkbox_log += checkBox13.Text + "\r\n";
                Money += 70;
            }
            if (checkBox14.Checked == true)
            {
                _checkbox_log += checkBox14.Text + "\r\n";
                Money += 40;
            }
            if (checkBox15.Checked == true)
            {
                _checkbox_log += checkBox15.Text + "\r\n";
                Money += 50;
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

            rows.Add(new Object[] { rows.Count, date.ToString("yyyy/MM/dd HH:mm:ss"), _checkbox_log,Money });
            richTextBox1.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _checkbox_log = "";
            richTextBox1.Text = "";
            Money = 0;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
