using Demo;
using System.Data.SqlClient;

public class GiaSucDAL
{
    // Thay tên server và database của bạn vào connectionString
    private string connectionString = @"Data Source=your_server;Initial Catalog=your_database;Integrated Security=True";

    public void InsertGiaSuc(GiaSuc giaSuc)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO GiaSuc (LoaiGiaSuc, SoLuong, SoLuongSua, SoLuongCon) VALUES (@LoaiGiaSuc, @SoLuong, @SoLuongSua, @SoLuongCon)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LoaiGiaSuc", giaSuc.LoaiGiaSuc);
            cmd.Parameters.AddWithValue("@SoLuong", giaSuc.SoLuong);
            cmd.Parameters.AddWithValue("@SoLuongSua", giaSuc.SoLuongSua);
            cmd.Parameters.AddWithValue("@SoLuongCon", giaSuc.SoLuongCon);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
