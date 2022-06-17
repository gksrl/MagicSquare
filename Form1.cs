using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicSquare
{
    public partial class Form1 : Form
    {
        int num1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            DataTable dt = new DataTable();
            dt.Rows.Add();
            dataGridView1.DataSource = dt;

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show(" 숫자를 입력하세요.");
            }

            else if (Convert.ToInt32(textBox1.Text) < 3 || Convert.ToInt32(textBox1.Text) > 29)
            {
                MessageBox.Show(" 3이상 29이하 숫자만 입력하세요.");
            }

            else
            {
                for (int i = 0; i < num1; i++) // 입력 받은 수 만큼 열 생성
                {
                    dt.Columns.Add($"{i}", typeof(string));


                    for (int j = 0; j < i-4; j++) // 입력 받은 수 만큼의 행 생성
                    {
                        dt.Rows.Add();

                    }
                }
                


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
