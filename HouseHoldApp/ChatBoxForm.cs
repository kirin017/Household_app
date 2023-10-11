using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseHoldApp
{
    public partial class ChatBoxForm : Form
    {
        public ChatBoxForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
        public string random_sentences()
        {
            List<string> danhSachCauVan = new List<string>();
            Random random = new Random();

            // Sinh số nguyên ngẫu nhiên trong khoảng từ 0 đến 99
            int randomNumber = random.Next(0, 10);
            // Thêm các câu văn vào danh sách
            danhSachCauVan.Add("Hello, how can I assist you today?");
            danhSachCauVan.Add("I'm sorry for the inconvenience. Let me help you with that.");
            danhSachCauVan.Add("Thank you for reaching out to us. We appreciate your feedback.");
            danhSachCauVan.Add("Please provide me with more details so I can better assist you.");
            danhSachCauVan.Add("I'll look into this issue and get back to you as soon as possible.");
            danhSachCauVan.Add("Is there anything else I can help you with today?");
            danhSachCauVan.Add("Is there anything else I can help you with today?");
            danhSachCauVan.Add("We value your business and are here to assist you with any questions or concerns.");
            danhSachCauVan.Add("Your satisfaction is our priority, and we'll do our best to resolve this for you.");
            danhSachCauVan.Add("If you have any other questions in the future, please don't hesitate to reach out to us.");
            danhSachCauVan.Add("Hello");

            return danhSachCauVan[randomNumber];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtBox.Text.Length == 0)
                txtBox.Text = Convert.ToString("User: " + txtUser.Text);
            else
            {
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "User: " + txtUser.Text;
            }
            txtUser.Clear();
            Thread.Sleep(300);
            txtBox.Text += Environment.NewLine;
            txtBox.Text += "Girl: " + random_sentences();

            
        }
    }
}
