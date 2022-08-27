using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_management_Project.AllUsers
{
    public partial class Uc_addItem : UserControl
    {
        Connection cn = new Connection();
        String query;

       public Uc_addItem()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into products(name,category,price) values (' " + txtItemName.Text + "','" + txtCategory.Text + "', " + txtPrice.Text + " )";
            cn.SetData(query);
            clearAll();
        }

       

        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void AddNewItem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
