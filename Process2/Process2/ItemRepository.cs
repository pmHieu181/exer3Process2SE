using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process2
{
    internal class ItemRepository
    {
        private readonly string connectionString = "Server=MINHHIEU\\SQLEXPRESS;Database=Process2DB;Integrated Security=True;";

        public void InsertItem(Item item)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Item (ItemName, Size) VALUES (@ItemName, @Size)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                cmd.Parameters.AddWithValue("@Size", item.Size ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable FilterItems(string itemName, string size)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ItemName, Size FROM Item WHERE 1=1";
                if (!string.IsNullOrEmpty(itemName))
                    query += " AND ItemName LIKE @ItemName";
                if (!string.IsNullOrEmpty(size))
                    query += " AND Size LIKE @Size";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(itemName))
                    cmd.Parameters.AddWithValue("@ItemName", "%" + itemName + "%");
                if (!string.IsNullOrEmpty(size))
                    cmd.Parameters.AddWithValue("@Size", "%" + size + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetTopPurchasedItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT TOP 10 i.ItemName, i.Size, SUM(od.Quantity) as TotalQuantity
                    FROM Item i
                    JOIN OrderDetail od ON i.ItemID = od.ItemID
                    GROUP BY i.ItemName, i.Size
                    ORDER BY TotalQuantity DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Size { get; set; }
    }
}
