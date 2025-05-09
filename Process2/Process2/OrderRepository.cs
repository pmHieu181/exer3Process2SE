using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process2
{
    internal class OrderRepository
    {
        private readonly string connectionString = "Server=MINHHIEU\\SQLEXPRESS;Database=Process2DB;Integrated Security=True;";

        public int InsertOrder(Order order)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO [Order] (OrderDate, AgentID) OUTPUT INSERTED.OrderID VALUES (@OrderDate, @AgentID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@AgentID", order.AgentID);
                return (int)cmd.ExecuteScalar();
            }
        }

        public void InsertOrderDetail(OrderDetail detail)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO OrderDetail (OrderID, ItemID, Quantity, UnitAmount) VALUES (@OrderID, @ItemID, @Quantity, @UnitAmount)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", detail.OrderID);
                cmd.Parameters.AddWithValue("@ItemID", detail.ItemID);
                cmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                cmd.Parameters.AddWithValue("@UnitAmount", detail.UnitAmount);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetOrderReport()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT o.OrderID, a.AgentName, i.ItemName, od.Quantity, od.UnitAmount
                    FROM [Order] o
                    JOIN Agent a ON o.AgentID = a.AgentID
                    JOIN OrderDetail od ON o.OrderID = od.OrderID
                    JOIN Item i ON od.ItemID = i.ItemID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetAgents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT AgentID, AgentName FROM Agent";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetItemsByCustomerName(string customerName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT i.ItemName, i.Size, SUM(od.Quantity) as TotalQuantity, c.CustomerName
                    FROM [Order] o
                    JOIN Customer c ON o.CustomerID = c.CustomerID
                    JOIN OrderDetail od ON o.OrderID = od.OrderID
                    JOIN Item i ON od.ItemID = i.ItemID
                    WHERE c.CustomerName LIKE @CustomerName
                    GROUP BY i.ItemName, i.Size, c.CustomerName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerName", "%" + customerName + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetPurchasesByCustomerId(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT o.OrderID, o.OrderDate, i.ItemName, od.Quantity, od.UnitAmount, c.CustomerName
                    FROM [Order] o
                    JOIN Customer c ON o.CustomerID = c.CustomerID
                    JOIN OrderDetail od ON o.OrderID = od.OrderID
                    JOIN Item i ON od.ItemID = i.ItemID
                    WHERE c.CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int AgentID { get; set; }
    }

    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitAmount { get; set; }
    }
}
