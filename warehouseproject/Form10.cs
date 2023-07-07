using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouseproject
{
    public partial class Form10 : Form
    {
        Model1 model = new Model1();
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            var z = from d in model.products select d;
            foreach (var d in z)
            {
                comboBox1.Items.Add(d.productcode);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);
            var z = (from d in model.warehouse_product where d.productID == id select d);
          
            foreach (var i in z)
            {
                listBox1.Items.Add(i.warehouse.warehouseID + "\t"+ i.warehouse.warehousename);
                listBox2.Items.Add(i.product.productname);
                listBox2.Items.Add(i.product.productunit);

            }
        }
    }
}
