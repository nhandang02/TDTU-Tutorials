using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_MuonSach
    {
        public static void AddMuonSach(DTO_MuonSach muonSach)
        {
            DAL_MuonSach.AddMuonSach(muonSach);
        }

        public static DataTable GetMuonSach()
        {
            return DAL_MuonSach.GetMuonSach();
        }

        public static string GenerateMaPhieuMuon(string prefix)
        {
            return DAL_MuonSach.GenerateMaPhieuMuon(prefix);
        }
    }
}