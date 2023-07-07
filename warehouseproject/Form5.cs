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
    public partial class Form5 : Form
    {
        Model1 model = new Model1();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            customer customer = new customer();
        customer.customerID = int.Parse(textBox8.Text);
           customer.customername = textBox6.Text;
           customer.phone = textBox7.Text;
            customer.Address = textBox9.Text;
            customer.mobile = textBox5.Text;
            customer.fax = textBox10.Text;
            customer.email = textBox11.Text;

            var customerdata
                = from d in model.customers where d.customerID == customer.customerID  select d;
            if (customerdata != null)
            {

                model.customers.Add(customer);
                model.SaveChanges();
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox8.Text);


            customer customer = model.customers.Where(d => d.customerID == id).Select(d => d).FirstOrDefault();
            if (customer != null)
            {
               
                customer.customerID = int.Parse(textBox8.Text);
                customer.customername = textBox6.Text;
                customer.phone = textBox7.Text;
                customer.Address = textBox9.Text;
                customer.mobile = textBox5.Text;
                customer.fax = textBox10.Text;
                customer.email = textBox11.Text;


                model.SaveChanges();
                MessageBox.Show("updated");
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }
    }
}
