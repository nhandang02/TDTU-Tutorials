using System;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_Sach
    {
        public DataTable GetAllSach()
        {
            string sql = "SELECT * FROM Sach";
            return Connection.selectQuery(sql);
        }

        public void AddSach(DTO_Sach sach)
        {
            string sql = $"INSERT INTO Sach VALUES ('{sach._MaSach}', N'{sach._TenSach}', N'{sach._TacGia}', {sach._SoLuong})";
            Connection.actionQuery(sql);
        }

        public void UpdateSach(DTO_Sach sach)
        {
            string sql = $"UPDATE Sach SET TenSach = N'{sach._TenSach}', TacGia = N'{sach._TacGia}', SoLuong = {sach._SoLuong} WHERE MaSach = '{sach._MaSach}'";
            Connection.actionQuery(sql);
        }

        public void DeleteSach(string maSach)
        {
            string sql = $"DELETE FROM Sach WHERE MaSach = '{maSach}'";
            Connection.actionQuery(sql);
        }

        public DataTable SearchSach(string keyword)
        {
            string sql = $"SELECT * FROM Sach WHERE MaSach LIKE '%{keyword}%' OR TenSach LIKE '%{keyword}%'";
            return Connection.selectQuery(sql);
        }
    }
}
