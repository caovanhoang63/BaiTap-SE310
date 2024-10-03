using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
  public partial class Form1 : Form
    {
        private readonly List<Product> _products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddProduct(object sender, EventArgs e)
        {
            var p = new Product(textBox1.Text,textBox2.Text,int.Parse(textBox3.Text),decimal.Parse(textBox4.Text),  textBox5.Text,dateTimePicker1.Value);
            _products.Add(p);
        }


        private void GetHighestPrice(object sender, EventArgs e)
        {
            
            var mostExpensive = _products.OrderByDescending(p => p.Price).FirstOrDefault();
            var source = new BindingSource();
            source.DataSource = mostExpensive;
            dataGridView1.DataSource = source;
        }



    }
}