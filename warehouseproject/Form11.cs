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
    public partial class Form11 : Form
    {
        Model1 model = new Model1();
       
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
            movemnt movemnt = new movemnt();
            // comboBox1.Items.Add(supplier.supplierID);
            var movementdata = from d in model.movemnts select d;
            foreach (var i  in movementdata)
            {
                comboBox1.Items.Add(i.movemntID);
            }
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            movemnt movemnt = new movemnt();
            
            var z = (from d in model.movemnts  select d) ;
           
            var y = DateTime.Parse(textBox1.Text);
            var k = DateTime.Parse(textBox2.Text);
            
           
            listBox1.Items.Clear();
           foreach(var i in z)
            {
               
                if (i.currentdate>y && i.currentdate<k)
                {
                    
                    listBox1.Items.Add(i.movemntID);
                    listBox1.Items.Add(i.towarehouseid);
                    listBox1.Items.Add(i.fromwarehouseid);
                    listBox1.Items.Add(i.permissionno);
                    listBox1.Items.Add(i.permissiondate);
                    listBox1.Items.Add(i.quantity);
                    listBox1.Items.Add(i.productiondate);
                    listBox1.Items.Add(i.expirydate);
                    listBox1.Items.Add(i.supplierID);
                    listBox1.Items.Add(i.currentdate);


                   

                }
               
            }
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
