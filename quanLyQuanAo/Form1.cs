using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyQuanAo
{
    public partial class Form1 : Form
    {
        private List<student> students;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void show()
        {
            BindingSource Dom = new BindingSource();
            Dom.DataSource = students;
            tableView.DataSource = Dom;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<student>();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            student x = new student();
            x.nameStudent = textName.Text;
            x.codeStudent = textCode.Text;
            x.ageStudent = int.Parse(textAge.Text);
            students.Add(x);
            show();
        }
    }
}
