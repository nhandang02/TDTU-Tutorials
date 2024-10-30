using System;

namespace DTO
{
    public class DTO_DocGia
    {
        private string MaDocGia;
        private string HoTen;
        private DateTime NgaySinh;

        public string _MaDocGia
        {
            get { return MaDocGia; }
            set { MaDocGia = value; }
        }

        public string _HoTen
        {
            get { return HoTen; }
            set { HoTen = value; }
        }

        public DateTime _NgaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }

        public DTO_DocGia(string maDocGia, string hoTen, DateTime ngaySinh)
        {
            this.MaDocGia = maDocGia;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
        }
    }
}
