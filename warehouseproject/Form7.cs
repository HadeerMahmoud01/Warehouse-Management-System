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
    public partial class Form7 : Form
    {
        Model1 model = new Model1();

        supply_permission supply = new supply_permission();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // add
        {
            try
            {
                supply.permissionID = int.Parse(textBox1.Text);
                supply.permissionno = int.Parse(textBox2.Text);
                supply.permissiondate = DateTime.Parse(textBox3.Text);
                supply.quantity = int.Parse(textBox4.Text);
                supply.productiondate = DateTime.Parse(textBox5.Text);
                supply.expirydate = DateTime.Parse(textBox6.Text);
                supply.supplierID = int.Parse(textBox7.Text);
                supply.productcode = int.Parse(textBox8.Text);
                supply.warehouseID = int.Parse(textBox9.Text);
                warehouse_product warehouse_Product = new warehouse_product();
                warehouse_Product.productID = int.Parse(textBox8.Text);
                warehouse_Product.warehouseID = int.Parse(textBox9.Text);

                var supplydata = from d in model.supply_permission where d.permissionID != supply.permissionno select d;
                var z = (from d in model.warehouse_product where d.warehouseID == supply.warehouseID && d.productID == supply.productcode select d).FirstOrDefault();

                model.supply_permission.Add(supply);
                if (z != null)
                {
                    z.quantity += supply.quantity;



                    MessageBox.Show((z.quantity).ToString());


                    model.SaveChanges();
                    MessageBox.Show("ok");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("invalid data");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            try
            {
                supply = model.supply_permission.Where(d => d.permissionID == id).Select(d => d).FirstOrDefault();
                if (supply != null)
                {

                    supply.permissionID = int.Parse(textBox1.Text);
                    supply.permissionno = int.Parse(textBox2.Text);
                    supply.permissiondate = DateTime.Parse(textBox3.Text);
                    supply.quantity = int.Parse(textBox4.Text);
                    supply.productiondate = DateTime.Parse(textBox5.Text);
                    supply.expirydate = DateTime.Parse(textBox6.Text);
                    supply.supplierID = int.Parse(textBox7.Text);
                    supply.productcode = int.Parse(textBox8.Text);
                    supply.warehouseID = int.Parse(textBox9.Text);


                    model.SaveChanges();
                    MessageBox.Show("updated");
                }
                else
                {
                    MessageBox.Show("invalid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("rechek your data");
            }
        }
    }
}
