using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace timber_shop_manager
{
    internal class DatabaseHelper
    {
        private string connectionString;

        private string 
            server = Properties.Settings.Default.DBServer, 
            name = Properties.Settings.Default.DBName, 
            username = Properties.Settings.Default.DBUsername, 
            password = Properties.Settings.Default.DBPassword;

        private bool isWindowAuthentication = Properties.Settings.Default.isWindowAuthentication;

        public DatabaseHelper()
        {
            connectionString = "Data Source=DESKTOP-M3PPH9A\\SQLEXPRESS;Initial Catalog=TimberShop;Integrated Security=True;Trust Server Certificate=True";
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TimberShop;Integrated Security=True;Trust Server Certificate=True";
            if (isWindowAuthentication)
            {
                //connectionString = $"Data Source={server};Initial Catalog={name};Integrated Security=True;Trust Server Certificate=True";
            } 
            else
            {
                //connectionString = $"Data Source={server};Initial Catalog={name};User ID={username};Password={password};Encrypt=True;Trust Server Certificate=True";
            }
        }

        // Kiểm tra kết nối
        public bool isConnected()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connect Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // Phương thức mở kết nối
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Phương thức thực thi câu lệnh SQL (INSERT, UPDATE, DELETE)
        /* EXAMPLE:
         * string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
         * dbHelper.ExecuteNonQuery(insertQuery, 
         *     new SqlParameter("@username", "admin"), 
         *     new SqlParameter("@password", "123456"));
         */
        public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Phương thức lấy dữ liệu (SELECT)
        /* EXAMPLE
         * string selectQuery = "SELECT * FROM Users";
         * DataTable dt = dbHelper.ExecuteQuery(selectQuery);
         * dataGridView.DataSource = dt;
         */
        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            // Xử lý NULL trong DataTable
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    if (row[column] == DBNull.Value)
                    {
                        row[column] = null;
                    }
                }
            }
            return dt;
        }

        // Phương thức lấy giá trị đơn lẻ (ví dụ: COUNT, SUM, MAX, MIN)
        /* EXAMPLE
         * string countQuery = "SELECT COUNT(*) FROM Users";
         * int count = Convert.ToInt32(dbHelper.ExecuteScalar(countQuery));
         * MessageBox.Show($"Số lượng người dùng: {count}");
         */
        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    object result = cmd.ExecuteScalar();
                    return (result == DBNull.Value) ? null : result;
                }
            }
        }

        // Lấy danh sách dữ liệu từ database
        /* EXAMPLE
         * string query = "SELECT category_name FROM Categories"; // Lấy dữ liệu từ bảng Categories
         * List<string> data = dbHelper.GetDataForComboBox(query, "category_name"); // Lưu ý: columnName = "category_name"
         * comboBox1.DataSource = data;
         */
        public List<string> GetDataForComboBox(string query, string columnName, params SqlParameter[] parameters)
        {
            List<string> dataList = new List<string>();
            DataTable dt = ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                dataList.Add(row[columnName].ToString()); // Lấy dữ liệu từ cột columnName
            }

            return dataList;
        }

        // Phương thức lấy dữ liệu và chuyển thành danh sách đối tượng
        public List<T> GetDataForList<T>(string query, Func<SqlDataReader, T> map, params SqlParameter[] parameters)
        {
            List<T> dataList = new List<T>();

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Chuyển đổi từng dòng dữ liệu thành đối tượng
                            T item = map(reader);
                            dataList.Add(item);
                        }
                    }
                }
            }
            return dataList;
        }

        public SqlDataReader ExecuteReader(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())  
            {
                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);  
                    }

                    conn.Open();  

                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
        }

    }
}
