using System;
public class SanPham
{
    public string MaSP { get; set; }
    public string TenSP { get; set; }
    public double DonGia { get; set; }
    public int SoLuong { get; set; }

    public double TinhThanhTien() => DonGia * SoLuong;

    public void HienThi()
    {
        Console.WriteLine($"Mã: {MaSP} | Tên: {TenSP} | Đơn giá: {DonGia:N0} | SL: {SoLuong} | Thành tiền: {TinhThanhTien():N0}");
    }
}