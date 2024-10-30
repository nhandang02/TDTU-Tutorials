using System;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_ChiTietPhieuMuon
    {
        public static void AddChiTietPhieuMuon(DTO_ChiTietPhieuMuon chiTietPhieuMuon)
        {
            string sql = "INSERT INTO ChiTietPhieuMuon (MaPhieuMuon, MaSach, NgayTra) " +
                         "VALUES (@MaPhieuMuon, @MaSach, @NgayTra)";

            Connection.actionQuery(sql);
        }

        public static DataTable GetChiTietPhieuMuon()
        {
            string sql = "SELECT * FROM ChiTietPhieuMuon";
            return Connection.selectQuery(sql);
        }
    }
}
