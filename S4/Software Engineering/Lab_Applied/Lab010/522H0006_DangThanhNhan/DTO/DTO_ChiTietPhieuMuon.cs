using System;

namespace DTO
{
    public class DTO_ChiTietPhieuMuon
    {
        private string MaPhieuMuon;
        private string MaSach;
        private DateTime? NgayTra;

        public string _MaPhieuMuon
        {
            get { return MaPhieuMuon; }
            set { MaPhieuMuon = value; }
        }

        public string _MaSach
        {
            get { return MaSach; }
            set { MaSach = value; }
        }

        public DateTime? _NgayTra
        {
            get { return NgayTra; }
            set { NgayTra = value; }
        }

        public DTO_ChiTietPhieuMuon(string maPhieuMuon, string maSach, DateTime? ngayTra = null)
        {
            this.MaPhieuMuon = maPhieuMuon;
            this.MaSach = maSach;
            this.NgayTra = ngayTra;
        }
    }
}
