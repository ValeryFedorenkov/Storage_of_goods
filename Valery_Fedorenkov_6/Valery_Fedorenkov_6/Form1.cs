using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Valery_Fedorenkov_6
{
    public partial class Form1 : Form
    {
        public GoodsList goods = new GoodsList();
        public Form1()
        {
            InitializeComponent();
            goods.Add(new Goods("Pizza", 20, 10));
            dataGridView1.DataSource = new BindingSource(goods, null);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = goods;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Goods g = new Goods(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            goods.Add(g);
            dataGridView1.DataSource = goods;
            (BindingContext[goods] as CurrencyManager).Refresh();
        }
    }
}
