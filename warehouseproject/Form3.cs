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
    public partial class Form3 : Form
    {
        Model1 model = new Model1();
        warehouse warehouse = new warehouse();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //add
        {
            try
            {
                product product = new product();
                product.productcode = int.Parse(textBox1.Text);
                product.productname = textBox2.Text;
                product.productunit = textBox3.Text;

                warehouse_product warehouse_Product = new warehouse_product();
                warehouse_Product.productID = product.productcode;

                warehouse_Product.warehouseID = int.Parse(textBox4.Text);

                var productdata = from d in model.products where d.productcode == product.productcode select d;
                if (productdata != null)
                {
                    model.products.Add(product);
                    model.warehouse_product.Add(warehouse_Product);
                    model.SaveChanges();
                    MessageBox.Show("ok");
                }
                else
                {
                    MessageBox.Show("invalid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("re-enter warehouseid");
            }
        }

        private void button2_Click(object sender, EventArgs e) //update
        {
            int id = int.Parse(textBox1.Text);

          
            product product=model.products.Where(d=>d.productcode==id).Select(d=>d).FirstOrDefault();
            if (product != null)
            {

               product.productcode = int.Parse(textBox1.Text);
                product.productname = textBox2.Text;
                product.productunit = textBox3.Text;
               

                model.SaveChanges();
                MessageBox.Show("updated");
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
