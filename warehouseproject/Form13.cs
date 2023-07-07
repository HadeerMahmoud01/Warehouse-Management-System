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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            // supply_permission supply= new supply_permission();

            var z = from d in model.supply_permission select d;
            
        

            listBox1.Items.Clear();
         
            foreach (var i in z)
            {

                if (dateTimePicker1.Value<i.expirydate)
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
