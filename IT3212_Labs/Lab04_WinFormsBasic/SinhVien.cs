using System;

public class SinhVien
{
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public string GioiTinh { get; set; }
    public string Khoa { get; set; }
    public double DiemTB { get; set; }

    public SinhVien() { }

    public SinhVien(string ma, string ten, DateTime ngaySinh, string gioiTinh, string khoa, double diem)
    {
        MaSV = ma;
        HoTen = ten;
        NgaySinh = ngaySinh;
        GioiTinh = gioiTinh;
        Khoa = khoa;
        DiemTB = diem;
    }
}