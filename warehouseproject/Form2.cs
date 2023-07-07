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
    public partial class Form2 : Form
    { Model1 model= new Model1();
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            warehouse warehouse= new warehouse();
            warehouse.warehouseID= int.Parse(textBox1.Text);
            warehouse.warehousename = textBox2.Text;
            warehouse.supervisor = textBox3.Text;
            warehouse.Address = textBox4.Text;

            
            var warehousedata = from d in model.warehouses where d.warehouseID == warehouse.warehouseID select d;
            
         
         
            if (warehousedata!=null )
            {
                model.warehouses.Add(warehouse);
                
                model.SaveChanges();
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("invalid");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        

        private void button2_Click(object sender, EventArgs e) //update
        {
            int id = int.Parse(textBox1.Text);
        
            warehouse ware = model.warehouses.Where(d=>d.warehouseID==id).Select(d=>d).FirstOrDefault();
          //  warehouse_product warehouse_Product=new warehouse_product();
            if (ware != null)
            {
              
                ware.warehouseID = int.Parse(textBox1.Text);
                ware.warehousename = textBox2.Text;
                ware.supervisor = textBox3.Text;
                ware.Address = textBox4.Text;
            
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
