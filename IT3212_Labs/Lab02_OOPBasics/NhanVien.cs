using System;
public class NhanVien
{
    public string MaNV { get; set; }
    public string HoTen { get; set; }
    public double LuongCoBan { get; set; }
    public double HeSoLuong { get; set; }
    public double PhuCap { get; set; }

    public double TinhTienLuong() => LuongCoBan * HeSoLuong + PhuCap;

    public void HienThi()
    {
        Console.WriteLine($"NV: {MaNV} - {HoTen} | Lương: {TinhTienLuong():N0}");
    }
}