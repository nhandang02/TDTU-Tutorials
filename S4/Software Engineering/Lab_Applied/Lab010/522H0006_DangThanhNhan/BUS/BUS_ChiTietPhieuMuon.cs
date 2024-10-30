using DAL;
using DTO;
using System.Data;

namespace BUS
{

    public class BUS_ChiTietPhieuMuon
    {
        public static void AddChiTietPhieuMuon(DTO_ChiTietPhieuMuon chiTietPhieuMuon)
        {
            DAL_ChiTietPhieuMuon.AddChiTietPhieuMuon(chiTietPhieuMuon);
        }

        public static DataTable GetChiTietPhieuMuon()
        {
            return DAL_ChiTietPhieuMuon.GetChiTietPhieuMuon();
        }
    }
}
