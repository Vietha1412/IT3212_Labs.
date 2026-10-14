using System;
public class TaiKhoanNganHang
{
    public string SoTaiKhoan { get; set; }
    public string TenChuTaiKhoan { get; set; }
    private double _soDu;

    public double SoDu
    {
        get => _soDu;
        set { if (value < 0) throw new Exception("Số dư không được âm."); _soDu = value; }
    }

    public void NapTien(double soTien)
    {
        if (soTien > 0) SoDu += soTien;
    }

    public void RutTien(double soTien)
    {
        if (soTien > 0 && soTien <= SoDu) SoDu -= soTien;
        else Console.WriteLine("Số tiền rút không hợp lệ hoặc vượt quá số dư!");
    }
}