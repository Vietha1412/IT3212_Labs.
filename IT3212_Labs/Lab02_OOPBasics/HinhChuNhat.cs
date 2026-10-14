using System;
public class HinhChuNhat
{
    private double _chieuDai, _chieuRong;
    public double ChieuDai
    {
        get => _chieuDai;
        set { if (value <= 0) throw new Exception("Cạnh phải > 0"); _chieuDai = value; }
    }
    public double ChieuRong
    {
        get => _chieuRong;
        set { if (value <= 0) throw new Exception("Cạnh phải > 0"); _chieuRong = value; }
    }
    public HinhChuNhat(double dai, double rong) { ChieuDai = dai; ChieuRong = rong; }
    public double TinhChuVi() => (ChieuDai + ChieuRong) * 2;
    public double TinhDienTich() => ChieuDai * ChieuRong;
}