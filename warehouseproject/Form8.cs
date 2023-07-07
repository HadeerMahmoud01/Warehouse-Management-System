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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        // current date means here the date of movement
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 model = new Model1();
                movemnt movement = new movemnt();
                movement.movemntID = int.Parse(textBox1.Text);
                movement.towarehouseid = int.Parse(textBox2.Text);
                movement.fromwarehouseid = int.Parse(textBox3.Text);
                movement.quantity = int.Parse(textBox4.Text);
                movement.productcode = int.Parse(textBox5.Text);
                movement.currentdate = dateTimePicker4.Value;
                warehouse_product warehouse_Product = new warehouse_product();
                //  var z = (from d in model.movemnts where d.movemntID==movement.movementID select d).FirstOrDefault();
                var z = (from d in model.warehouse_product where d.warehouseID == movement.towarehouseid && d.productID == movement.productcode select d).FirstOrDefault();
                var x = (from d in model.warehouse_product where d.warehouseID == movement.fromwarehouseid && d.productID == movement.productcode select d).FirstOrDefault();
                model.movemnts.Add(movement);
                if (z != null && x != null)
                {
                    z.quantity += movement.quantity;
                    x.quantity -= movement.quantity;
                    model.SaveChanges();
                    MessageBox.Show("ok");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            catch
            {
                MessageBox.Show("recheck your date");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
