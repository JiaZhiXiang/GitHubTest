using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("master分支");
            MessageBox.Show("master分支第一次修改");
            MessageBox.Show("添加 SwicaseJia 分支");
            MessageBox.Show("这是我在远程仓中自己添加的");
            MessageBox.Show("这是我在远程仓中自己添加的第二段代码");
            MessageBox.Show("这是我在远程仓中自己添加的第三段代码");
            MessageBox.Show("这是我在远程仓中自己添加的第五段代码");
            MessageBox.Show("2021年2月17日20:39:11");
            MessageBox.Show("2021年2月17日20:43:44");

            MessageBox.Show("本地仓第一次提交");
            //同意合并
            MessageBox.Show("远程仓分支");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("在 master 分支上添加按钮");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("新添加的 iss53 分支");
        }
    }
}
