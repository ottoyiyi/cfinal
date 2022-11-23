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
using System.Data.SQLite;
using static System.Windows.Forms.AxHost;

namespace cfinal
{
    public partial class Form1 : Form
    {
        string _checkbox_log = "";
        int Money = 0;

        int index = 1;

        public class DBConfig
        {     
            public static string dbFile = Application.StartupPath + @"\user.db";

            public static string dbPath = "Data source=" + dbFile;

            public static SQLiteConnection sqlite_connect;
            public static SQLiteCommand sqlite_cmd;
            public static SQLiteDataReader sqlite_datareader;
        }
        private void Show_DB()
        {
            this.dataGridView1.Rows.Clear();
            string sql = @"SELECT * from reecord;";
            DBConfig.sqlite_cmd = new SQLiteCommand(sql, DBConfig.sqlite_connect);
            DBConfig.sqlite_datareader = DBConfig.sqlite_cmd.ExecuteReader();

            if (DBConfig.sqlite_datareader.HasRows)
            {
                while (DBConfig.sqlite_datareader.Read()) //read every data
                {
                    int _serial = Convert.ToInt32(DBConfig.sqlite_datareader["serial"]);
                    int _date = Convert.ToInt32(DBConfig.sqlite_datareader["date"]);
                    string _order = Convert.ToString(DBConfig.sqlite_datareader["ord"]);
                    double _total = Convert.ToDouble(DBConfig.sqlite_datareader["total"]);

                    string _date_str = DateTimeOffset.FromUnixTimeSeconds(_date).ToString("yy-MM-dd hh:mm:ss");

                    index = _serial;
                    DataGridViewRowCollection rows = dataGridView1.Rows;
                    rows.Add(new Object[] { index, _date_str, _order, _total });
                }
                DBConfig.sqlite_datareader.Close();
            }
        }


        private void Load_DB()
        {
            DBConfig.sqlite_connect = new SQLiteConnection(DBConfig.dbPath);
            DBConfig.sqlite_connect.Open();// Open

        }

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
            Load_DB();
            Show_DB();
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
                _checkbox_log += checkBox1.Text + comboBox1.SelectedItem.ToString() + " " ;
                Money += 90;
            }
            if (checkBox2.Checked == true)
            {
                _checkbox_log += checkBox2.Text + comboBox2.SelectedItem.ToString() + " ";
                Money += 100;
            }
            if (checkBox3.Checked == true)
            {
                _checkbox_log += checkBox3.Text + comboBox3.SelectedItem.ToString() + " ";
                Money += 110;
            }
            if (checkBox4.Checked == true)
            {
                _checkbox_log += checkBox4.Text + comboBox4.SelectedItem.ToString() + " ";
                Money += 120;
            }
            if (checkBox5.Checked == true)
            {
                _checkbox_log += checkBox5.Text + comboBox5.SelectedItem.ToString() + " ";
                Money += 150;
            }
            if (checkBox6.Checked == true)
            {
                _checkbox_log += checkBox6.Text + comboBox6.SelectedItem.ToString() + " ";
                Money += 200;
            }
            if (checkBox7.Checked == true)
            {
                _checkbox_log += checkBox7.Text + " ";
                Money += 50;
            }
            if (checkBox8.Checked == true)
            {
                _checkbox_log += checkBox8.Text + " ";
                Money += 25;
            }
            if (checkBox9.Checked == true)
            {
                _checkbox_log += checkBox9.Text + " ";
                Money += 15;
            }
            if (checkBox10.Checked == true)
            {
                _checkbox_log += checkBox10.Text + " ";
                Money += 50;
            }
            if (checkBox11.Checked == true)
            {
                _checkbox_log += checkBox11.Text + " ";
                Money += 35;
            }
            if (checkBox12.Checked == true)
            {
                _checkbox_log += checkBox12.Text + " ";
                Money += 40;
            }
            if (checkBox13.Checked == true)
            {
                _checkbox_log += checkBox13.Text + " ";
                Money += 70;
            }
            if (checkBox14.Checked == true)
            {
                _checkbox_log += checkBox14.Text + " " ;
                Money += 40;
            }
            if (checkBox15.Checked == true)
            {
                _checkbox_log += checkBox15.Text ;
                Money += 50;
            }

            richTextBox1.Text = _checkbox_log;
            
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
            long _date = 0;
            _date = DateTimeOffset.Now.ToUnixTimeSeconds();
            String order = _checkbox_log.ToString();
            DateTime date = DateTime.Now; // 現在時間

            rows.Add(new Object[] { rows.Count, date.ToString("yyyy/MM/dd HH:mm:ss"), _checkbox_log,Money });
            richTextBox1.Text = "";

            if (_checkbox_log != "")
            {
                Load_DB();
                string sql = @"INSERT INTO reecord (date,ord,total) VALUES('" +_date.ToString() + "','" + order.ToString() + "','" +Money.ToString() + "');";

                DBConfig.sqlite_cmd = new SQLiteCommand(sql, DBConfig.sqlite_connect);
                DBConfig.sqlite_cmd.ExecuteNonQuery();
            }
            else 
            {
                MessageBox.Show("請點餐");
            }
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
