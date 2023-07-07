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
    public partial class Form6 : Form
    {
        Model1 model = new Model1();
        exchange_permission exchange = new exchange_permission();
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //add
        {
            try
            {

                exchange.permissionID = int.Parse(textBox1.Text);
                exchange.permissionno = int.Parse(textBox2.Text);
                exchange.permissiondate = DateTime.Parse(textBox3.Text);
                exchange.quantity = int.Parse(textBox4.Text);
                exchange.productiondate = DateTime.Parse(textBox5.Text);
                exchange.expirydate = DateTime.Parse(textBox6.Text);
                exchange.supplierID = int.Parse(textBox7.Text);
                exchange.productcode = int.Parse(textBox8.Text);
                exchange.warehouseID = int.Parse(textBox9.Text);
                // int id1= int.Parse(comboBox1.Text);

                warehouse_product warehouse_Product = new warehouse_product();
                warehouse warehouse = new warehouse();
                product product = new product();
                var exchangedata = from d in model.exchange_permission where d.permissionID == exchange.permissionno select d;
                var z = (from d in model.warehouse_product where d.warehouseID == exchange.warehouseID && d.productID == exchange.productcode select d).FirstOrDefault();
                model.exchange_permission.Add(exchange);
                //    model.warehouse_product.Add(warehouse_Product);
                if (z != null)
                {
                    z.quantity -= exchange.quantity;


                    // warehouse_Product.quantity -= 1;
                    MessageBox.Show((z.quantity).ToString());
                    //model.warehouse_product.Add(z);

                    model.SaveChanges();
                    MessageBox.Show("ok");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("recheck your data");
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            var w = from d in model.warehouses select d.warehouseID;
            foreach (var d in w)
            {
                comboBox1.Items.Add(d);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {int id1=int.Parse( comboBox1.Text);
            exchange=model.exchange_permission.Find(id1);
            if(exchange!= null)
            {
                textBox9.Text=exchange.permissionID.ToString();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int id = int.Parse(textBox1.Text);

            try
            {
                exchange = model.exchange_permission.Where(d => d.permissionID == id).Select(d => d).FirstOrDefault();
                if (exchange != null)
                {

                    exchange.permissionID = int.Parse(textBox1.Text);
                    exchange.permissionno = int.Parse(textBox2.Text);
                    exchange.permissiondate = DateTime.Parse(textBox3.Text);
                    exchange.quantity = int.Parse(textBox4.Text);
                    exchange.productiondate = DateTime.Parse(textBox5.Text);
                    exchange.expirydate = DateTime.Parse(textBox6.Text);
                    exchange.supplierID = int.Parse(textBox7.Text);
                    exchange.productcode = int.Parse(textBox8.Text);
                    exchange.warehouseID = int.Parse(textBox9.Text);


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
