using System;

public abstract class NguoiHoc
{
    public string HoTen { get; set; }
    public int SoTinChi { get; set; }
    public abstract decimal TinhHocPhi();
}

public class SinhVienChinhQuy : NguoiHoc
{
    public override decimal TinhHocPhi() => SoTinChi * 450000m;
}

public class SinhVienLienThong : NguoiHoc
{
    public override decimal TinhHocPhi() => SoTinChi * 520000m;
}