using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process2
{
    public partial class MainForm : Form
    {
        private readonly OrderService _orderService = new OrderService();
        private readonly ItemService _itemService = new ItemService();
        public MainForm()
        {
            InitializeComponent();

        }

        private void dataGridViewOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item item = new Item
            {
                ItemName = txtItemName.Text,
                Size = txtSize.Text
            };
            _itemService.AddItem(item);
            MessageBox.Show("Added!");
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                OrderDate = DateTime.Now,
                AgentID = 1 
            };
            int orderID = _orderService.CreateOrder(order);

            foreach (DataGridViewRow row in dataGridViewOrderDetails.Rows)
            {
                if (row.Cells["ItemID"].Value != null)
                {
                    OrderDetail detail = new OrderDetail
                    {
                        OrderID = orderID,
                        ItemID = Convert.ToInt32(row.Cells["ItemID"].Value),
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                        UnitAmount = Convert.ToDecimal(row.Cells["UnitAmount"].Value)
                    };
                    _orderService.AddOrderDetail(detail);
                }
            }
            MessageBox.Show("Saved!");
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            dataGridViewReport.DataSource = _orderService.GetOrderReport();
        }

        private void btnFilterItems_Click(object sender, EventArgs e)
        {
            string itemName = txtFilterItemName.Text;
            string size = txtFilterSize.Text;
            dataGridViewItems.DataSource = _itemService.FilterItems(itemName, size);
        }

        private void btnShowBestItems_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewBestItems.DataSource = _itemService.GetTopPurchasedItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị sản phẩm bán chạy nhất: " + ex.Message);
            }
        }

        private void btnShowPurchasedItems_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtCustomerName.Text;
                dataGridViewPurchasedItems.DataSource = _orderService.GetItemsByCustomerName(customerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnShowCustomerPurchases_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(lbl.Text, out int customerId))
                {
                    dataGridViewCustomerPurchases.DataSource = _orderService.GetPurchasesByCustomerId(customerId);
                }
                else
                {
                    MessageBox.Show("Enter your CustomerID!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTopPurchasedItems_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewItems.DataSource = _itemService.GetTopPurchasedItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc sản phẩm mua nhiều nhất: " + ex.Message);
            }
        }
    }
}
