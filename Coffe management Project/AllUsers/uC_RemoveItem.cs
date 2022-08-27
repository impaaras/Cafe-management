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
    public partial class uC_RemoveItem : UserControl
    {
        Connection cn = new Connection();
        String query;
        public uC_RemoveItem()
        {
            InitializeComponent();
        }

        private void uC_RemoveItem_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to Delete Item?";
            DelLabel.ForeColor = Color.Blue;
            loadData();
        }

        public void loadData()
        {
            query = "select * from products";
            DataSet ds = cn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from products where name like '"+txtSearch.Text+"%'";
            DataSet ds = cn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete item?", "Important message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from products where iid =" + id + "";
                cn.SetData(query);
                loadData();
            }
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {
            DelLabel.ForeColor = Color.Red;
            DelLabel.Text = "*Click on Row to Delete the Item";
        }
    }
}
