using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_MuonSach
    {

        public static void AddMuonSach(DTO_MuonSach muonSach)
        {
            string sql = "INSERT INTO MuonSach (MaPhieuMuon, MaDocGia, NgayMuon) " +
                         "VALUES (@MaPhieuMuon, @MaDocGia, @NgayMuon)";

            Connection.actionQuery(sql);
        }

        public static DataTable GetMuonSach()
        {
            string sql = "SELECT * FROM MuonSach";
            return Connection.selectQuery(sql);
        }

        public static string GenerateMaPhieuMuon(string prefix)
        {
            string sql = "SELECT MAX(CAST(SUBSTRING(MaPhieuMuon, LEN(MaPhieuMuon) - 2, 3) AS INT)) FROM MuonSach";
            DataTable dt = Connection.selectQuery(sql);

            if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
            {
                return prefix + "-001";
            }

            int maxId = Convert.ToInt32(dt.Rows[0][0]);
            return prefix + "-" + (maxId + 1).ToString("D3");
        }
    }
}
