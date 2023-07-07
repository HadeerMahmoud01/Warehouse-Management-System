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
    public partial class Form4 : Form
    {
        Model1 model = new Model1();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            supplier supplier = new supplier();
            supplier.supplierID = int.Parse(textBox8.Text);
            supplier.suppliername = textBox6.Text;
            supplier.phone = textBox7.Text;
            supplier.Address = textBox9.Text;
            supplier.mobile = textBox5.Text;
            supplier.fax = textBox10.Text;
            supplier.email = textBox11.Text;
            
            var supplierdata = from d in model.suppliers where d.supplierID == supplier.supplierID select d;
            if ( supplierdata != null)
            {
                
                model.suppliers.Add(supplier);
                model.SaveChanges();
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }

        private void button2_Click(object sender, EventArgs e)//update
        {
            int id = int.Parse(textBox8.Text);


            supplier supplier = model.suppliers.Where(d => d.supplierID == id).Select(d => d).FirstOrDefault();
            if (supplier != null)
            {

                supplier.suppliername = textBox6.Text;
                supplier.phone = textBox7.Text;
                supplier.Address = textBox9.Text;
                supplier.mobile = textBox5.Text;
                supplier.fax = textBox10.Text;
                supplier.email = textBox11.Text;

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
