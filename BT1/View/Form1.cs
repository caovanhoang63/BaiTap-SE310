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
        }

        private void addAnimalBtn_Click(object sender, EventArgs e)
        {
        }
    }
}