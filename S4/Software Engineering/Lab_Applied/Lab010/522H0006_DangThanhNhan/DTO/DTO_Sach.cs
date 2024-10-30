using System;

namespace DTO
{
    public class DTO_Sach
    {
        private string MaSach;
        private string TenSach;
        private string TacGia;
        private int SoLuong;

        public string _MaSach
        {
            get { return MaSach; }
            set { MaSach = value; }
        }

        public string _TenSach
        {
            get { return TenSach; }
            set { TenSach = value; }
        }

        public string _TacGia
        {
            get { return TacGia; }
            set { TacGia = value; }
        }

        public int _SoLuong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }

        public DTO_Sach(string maSach, string tenSach, string tacGia, int soLuong)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.TacGia = tacGia;
            this.SoLuong = soLuong;
        }
    }
}
