using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cfinal
{
    public partial class Form2 : Form
    {
        string password = "";
        bool IsToForm1 = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            password = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (String.Equals(password, textBox1.Text))
            {
                IsToForm1 = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("密碼錯誤");
            }


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
