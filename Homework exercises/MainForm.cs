using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_exercises
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            if (username.Length < 5)
            {
                label1.Text = "Tên đăng nhập phải từ 5 kí tự";
            }
            else
            {
                label1.Text = "Tên đăng nhập hợp lệ.";
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(username, @"[^a-zA-Z0-9_]"))
            {
                label1.Text = "Tên đăng nhập chỉ được chứa các ký tự chữ cái, số và dấu gạch dưới.";

            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            if (password.Length < 8)
            {               
                label1.Text = "Mật khẩu phải có ít nhất 8 ký tự.";
            }
            else
            {
                label1.Text = "";
            } 
            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                    hasLetter = true;
                if (char.IsDigit(c))
                    hasDigit = true;
            }

            if (!hasLetter || !hasDigit)
            {
                label1.Text = "Mật khẩu phải chứa cả chữ cái và số.";
            }
            else if (password.Length >= 8)
            {
                label1.Text = "Mật khẩu hợp lệ.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text;
            string password = textBox2.Text;           
            if (username == "221249" && password == "ducpho123")
            {                
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {    
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);         
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox1.Focus();
            }
        }
    }
}
