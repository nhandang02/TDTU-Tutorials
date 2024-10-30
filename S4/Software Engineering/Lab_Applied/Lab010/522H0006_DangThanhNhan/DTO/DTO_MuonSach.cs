using System;

namespace DTO
{
    public class DTO_MuonSach
    {
        private string MaPhieuMuon;
        private string MaDocGia;
        private DateTime NgayMuon;

        public string _MaPhieuMuon
        {
            get { return MaPhieuMuon; }
            set { MaPhieuMuon = value; }
        }

        public string _MaDocGia
        {
            get { return MaDocGia; }
            set { MaDocGia = value; }
        }

        public DateTime _NgayMuon
        {
            get { return NgayMuon; }
            set { NgayMuon = value; }
        }

        public DTO_MuonSach(string maPhieuMuon, string maDocGia, DateTime ngayMuon)
        {
            this.MaPhieuMuon = maPhieuMuon;
            this.MaDocGia = maDocGia;
            this.NgayMuon = ngayMuon;
        }
    }
}
