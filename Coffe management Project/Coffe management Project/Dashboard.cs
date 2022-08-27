using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_management_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAddItem.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
            }
            else if(user == "Admin")
            {
                btnAddItem.Show();
                btnUpdate.Show();
                btnRemove.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            welcome_user1.SendToBack();
            uC_placeOrder1.Visible = true;
            uC_placeOrder1.BringToFront();
        }

        private void welcome_user1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            addNewItem.Visible = true;
            addNewItem.BringToFront();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addNewItem.Visible = false;
            uC_placeOrder1.Visible = false;
            uC_updateItem1.Visible = false;
            uC_RemoveItem1.Visible = false;

        }

        private void addNewItem1_Load(object sender, EventArgs e)
        {
            addNewItem.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_updateItem1.Visible = true;
            uC_updateItem1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }
    }
}
