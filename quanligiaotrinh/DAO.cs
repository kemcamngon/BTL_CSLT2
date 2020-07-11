using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace quanligiaotrinh
{
    class DAO
    {
        public static SqlConnection conn;
        public static string connectionString = "Data Source=DESKTOP-5P1ED5U;Initial Catalog=QuanlyGT;Integrated Security=True";
        public static void OpenConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if (conn.State == System.Data.ConnectionState.Closed)
                try
                {
                    conn.Open();
                    //MessageBox.Show("mo ket noi thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                try
                {
                    conn.Close();
                    //MessageBox.Show("dong ket noi thanh cong");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter();	// Khai báo
            // Tạo đối tượng Command thực hiện câu lệnh SELECT        
            Mydata.SelectCommand = new SqlCommand();
            Mydata.SelectCommand.Connection = DAO.conn; 	// Kết nối CSDL
            Mydata.SelectCommand.CommandText = sql;	// Gán câu lệnh SELECT
            DataTable table = new DataTable();    // Khai báo DataTable nhận dữ liệu trả về
            Mydata.Fill(table); 	//Thực hiện câu lệnh SELECT và đổ dữ liệu vào bảng table
            return table;
        }
        /*public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adp.Fill(table);
            return table;
        }*/
        public static DataTable LoadDataToGridView(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static bool checkKeyExit(string sql)
        {
            bool kq = false;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                kq = true;
            return kq;
        }
         public static void FillDataToCombo(string sql, ComboBox combo, string valuesField, string DisplayField)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable mytable = new DataTable();
            adapter.Fill(mytable);
            combo.DataSource = mytable;
            combo.ValueMember = valuesField;
            combo.DisplayMember = DisplayField;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd; // Khai báo đối tượng SqlCommand
            cmd = new SqlCommand(); // Khởi tạo đối tượng
            cmd.Connection = DAO.conn; // Gán kết nối
            cmd.CommandText = sql; // Gán câu lệnh SQL
            try
            {
                conn.Open(); // phai mở kết nối trước khi thực hiện truy vấn
                cmd.ExecuteNonQuery(); // Thực hiện câu lệnh SQL
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; // Khai báo đối tượng SqlCommand
            cmd = new SqlCommand(); // Khởi tạo đối tượng
            cmd.Connection = DAO.conn; // Gán kết nối
            cmd.CommandText = sql; // Gán câu lệnh SQL
            try
            {
                //conn.Open(); // phai mở kết nối trước khi thực hiện truy vấn
                cmd.ExecuteNonQuery(); // Thực hiện câu lệnh SQL
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DAO.conn;
            cmd.CommandText = sql;
            try
            {
                conn.Open(); // phai mở kết nối trước khi thực hiện truy vấn
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        public static string GetFieldValues(string sql)
        {
            DAO.OpenConnection();
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, DAO.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(partsTime[2].Length - 2, 2) == "PM")
            {
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
                partsTime[2] = partsTime[2].Remove(partsTime[2].Length - 2, 2);
            }
            if (partsTime[2].Substring(partsTime[2].Length - 2, 2) == "AM")
            {
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
                partsTime[2] = partsTime[2].Remove(partsTime[2].Length - 2, 2);
            }
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[0], parts[1], parts[2]);

            return dt;
        }
    }
}
