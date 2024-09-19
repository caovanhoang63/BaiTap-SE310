using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BT1.Biz;
using BT1.DA.Ado;

namespace BT1
{
    public partial class Form1 : Form
    {
        private readonly FarmBiz _farmBiz;
        public Form1()
        {
            InitializeComponent();
            var repo = new AdoStore();
            _farmBiz = new FarmBiz(repo);
            _updateAnimalNumber();
            milk.Text = _farmBiz.Milk.ToString();
        }


        private void _updateAnimalNumber()
        {
            cow.Text = _farmBiz.Cow.ToString();
            sheep.Text = _farmBiz.Sheep.ToString();
            goat.Text = _farmBiz.Goat.ToString();
        }
        
        private void addAnimalBtn_Click(object sender, EventArgs e)
        {
            int cowNum, sheepNum, goatNum;

            if (!Int32.TryParse(this.cowTextBox.Text, out cowNum))
            {
                MessageBox.Show("Please enter a valid number for cows.");
                return;
            }

            if (!Int32.TryParse(this.sheepTextBox.Text, out sheepNum))
            {
                MessageBox.Show("Please enter a valid number for sheep.");
                return;
            }

            if (!Int32.TryParse(this.goatTextBox.Text, out goatNum))
            {
                MessageBox.Show("Please enter a valid number for goats.");
                Console.WriteLine(this.goatTextBox.Text);
                return;
            }
            _farmBiz.AddAnimal(cowNum, sheepNum, goatNum);
            _updateAnimalNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _farmBiz.GiveBirth();
            _updateAnimalNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             _farmBiz.GetMilk();
             milk.Text = _farmBiz.Milk.ToString();
        }
    }
}