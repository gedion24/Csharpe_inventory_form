using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WformLab.model;

namespace WformLab
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           // string number = txtnum.Text;
          //  string date = txtdate.Text;
          //  string inventorynumber = txtinventory.Text;
          //  string objname = txtobjname.Text;
          //  string count = txtcount.Text;
          //  string price = txtcprice.Text;

            Item it = new Item();
            it.number = txtnum.Text;
            it.date = txtdate.Text;
            it.inventorynumber = txtinventory.Text;
            it.objectname = txtobjname.Text;
            it.count = int.Parse (txtcount.Text);
            it.price = txtcprice.Text;

            MessageBox.Show("added");




        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
