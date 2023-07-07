using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace warehouseproject
{
    public partial class Form9 : Form
    { Model1 model= new Model1();
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            var w = from d in model.warehouses select d.warehouseID;
            foreach (var d in w)
            {
                comboBox1.Items.Add(d);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = int.Parse(comboBox1.Text);


            //  var x = (from d in model.warehouse_product select d);
            var z = (from d in model.warehouse_product where d.warehouseID == ID select d);
            //  var y = (from d in model.products where d.productcode == x.productID select d);


            listBox1.Items.Clear();
            foreach(var i in z)
            {
                listBox1.Items.Add(i.product.productname + "\t" + i.quantity);
                textBox1.Text=i.product.productname;
                textBox2.Text = i.quantity.ToString();

                label1.Text = i.warehouse.warehouseID.ToString();
                label1.Text = i.warehouse.warehousename;
                label1.Text = i.warehouse.Address;
                label1.Text = i.warehouse.supervisor;
            }
            
        }    

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
