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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 model= new Model1();
          // supply_permission supply= new supply_permission();

            var z = from d in model.supply_permission select d;

            var y = DateTime.Parse(textBox1.Text);
            var k = DateTime.Parse(textBox2.Text);


            listBox1.Items.Clear();
           
            foreach (var i in z)
            {

                if (i.permissiondate > y && i.permissiondate < k)
                {

                 listBox1.Items.Add(i.permissionno);
                    listBox1.Items.Add(i.permissiondate);
                    listBox1.Items.Add(i.quantity);
                    listBox1.Items.Add(i.productiondate);
                    listBox1.Items.Add(i.expirydate);
                    listBox1.Items.Add(i.supplierID);
                    listBox1.Items.Add(i.productcode);
                    listBox1.Items.Add(i.warehouseID);

                }

            }
        }
    }
}
