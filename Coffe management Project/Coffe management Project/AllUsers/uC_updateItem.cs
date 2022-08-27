using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_management_Project.AllUsers
{
    public partial class uC_updateItem : UserControl
    {
        Connection cn = new Connection();
        String query;
        public uC_updateItem()
        {
            InitializeComponent();
        }

        private void uC_updateItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            query = "select * from products";
            DataSet ds = cn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {

            query = "select * from products where name like '"+txtSearchItem.Text+"%'";
            DataSet ds = cn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        String Category;
        String Name;
        int price;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());


            txtCategory.Text = Category;
            txtName.Text = Name;
            txtPrice.Text = price.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            query = "update products set name = '"+txtName.Text+"', category='"+txtCategory.Text+"',price='"+txtPrice.Text+"' where iid = "+id+"";
            cn.SetData(query);
            LoadData();

            txtPrice.Clear();
            txtName.Clear();
            txtCategory.Clear();
        }
    }
}
