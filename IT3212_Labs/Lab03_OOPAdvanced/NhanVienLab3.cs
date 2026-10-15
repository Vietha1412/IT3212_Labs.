using System;

public abstract class NhanVienLab3
{
    public string HoTen { get; set; }
    public abstract decimal TinhLuong();
}

public class NhanVienVanPhong : NhanVienLab3
{
    public decimal LuongCung { get; set; }
    public override decimal TinhLuong() => LuongCung;
}

public class GiangVien : NhanVienLab3
{
    public int SoTiet { get; set; }
    public decimal DonGia { get; set; }
    public override decimal TinhLuong() => SoTiet * DonGia;
}