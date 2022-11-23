using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cfinal
{
    public partial class Form2 : Form
    {
        string id = "";
        string password = "";
        bool IsToForm1 = false;

        public class DBConfig
        {      
            public static string dbFile = Application.StartupPath + @"\user.db";

            public static string dbPath = "Data source=" + dbFile;

            public static SQLiteConnection sqlite_connect;
            public static SQLiteCommand sqlite_cmd;
            public static SQLiteDataReader sqlite_datareader;
        }
        private void Load_DB()
        {
            DBConfig.sqlite_connect = new SQLiteConnection(DBConfig.dbPath);
            DBConfig.sqlite_connect.Open();// Open

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = textBox2.Text;
            password = textBox1.Text;

            DBConfig.sqlite_connect = new SQLiteConnection(DBConfig.dbPath);
            DBConfig.sqlite_connect.Open();// Open

            string sql = @"SELECT * from user where id = '" + id.ToString() + "';";

            DBConfig.sqlite_cmd = new SQLiteCommand(sql, DBConfig.sqlite_connect);
            DBConfig.sqlite_datareader = DBConfig.sqlite_cmd.ExecuteReader();

            if (DBConfig.sqlite_datareader.HasRows | password=="")
            {
                MessageBox.Show("帳號已存在或密碼未填寫");
            }
            else
            {
                MessageBox.Show("成功註冊");

                sql = @"INSERT INTO user (id,password) VALUES('" +id.ToString()+"','"+password.ToString()+"');";

                DBConfig.sqlite_cmd = new SQLiteCommand(sql, DBConfig.sqlite_connect);
                DBConfig.sqlite_datareader = DBConfig.sqlite_cmd.ExecuteReader();
                
            }
            DBConfig.sqlite_datareader.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            id = textBox2.Text;
            password = textBox1.Text;
            Load_DB();

            string sql = @"SELECT * from user WHERE id ='" + id.ToString() +"' AND password ='"+ password.ToString() +"';";
            DBConfig.sqlite_cmd = new SQLiteCommand(sql, DBConfig.sqlite_connect);
            DBConfig.sqlite_datareader = DBConfig.sqlite_cmd.ExecuteReader();

            if (DBConfig.sqlite_datareader.HasRows | password == "")
            {
                IsToForm1 = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("密碼錯誤");

            }
            DBConfig.sqlite_datareader.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
    
        }

        private void close_form_action(object sender, FormClosingEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            if (IsToForm1) //判斷是否要回到Form1
            {
                this.DialogResult = DialogResult.Yes; //利用DialogResult傳遞訊息
                Form1 form1 = (Form1)this.Owner; //取得父視窗的參考
            }
            else 
            {
                System.Environment.Exit(0);
            }

        }
    }
}
