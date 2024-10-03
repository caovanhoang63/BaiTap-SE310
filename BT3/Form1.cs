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
        private List<Product> _products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            dataGridView2.DataSource = _products;
        }

        private void AddProduct(object sender, EventArgs e)
        {
            var p = new Product(textBox1.Text,textBox2.Text,int.Parse(textBox3.Text),decimal.Parse(textBox4.Text),  textBox5.Text,dateTimePicker1.Value);
            _products.Add(p);
            RefreshDataGridView();

        }


        private void GetHighestPrice(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new List<Product> { _products.OrderByDescending(p => p.Price).FirstOrDefault() };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void FindProductFromJapan(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new List<Product> { _products.FirstOrDefault(p => p.Origin =="Nhật Bản") };
        }

        private void FindExpired(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  _products.Where(p => p.ExpirationDate < DateTime.Now).ToList();
        }

        private void FindByPrices(object sender, EventArgs e)
        {
            var from = int.Parse(textBox6.Text);
            var to = int.Parse(textBox7.Text);
            dataGridView1.DataSource = _products.Where(p => p.Price >= from && p.Price <= to).ToList();
        }


        private void DeleteByOrigin(object sender, EventArgs e)
        {
            _products.RemoveAll(p => p.Origin == textBox8.Text);
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = _products;
        }

        private void DeleteAll(object sender, EventArgs e)
        {
            _products.Clear();
            RefreshDataGridView();
        }

        private void DeleteExpired(object sender, EventArgs e)
        {
            _products.RemoveAll(p => p.ExpirationDate < DateTime.Now);
            RefreshDataGridView();
        }

        private void CheckExpired(object sender, EventArgs e)
        {
            var enumerable = _products.Where(p => p.ExpirationDate < DateTime.Now);
            if (enumerable.Any())
            {
                MessageBox.Show("Có sản phẩm hết hạn");
            }
            else
            {
                MessageBox.Show("Không có sản phẩm hêt hạn");
            }
            
        }
    }
}