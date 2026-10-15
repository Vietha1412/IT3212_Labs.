using System;

public class SinhVien : Nguoi, IValidatable, IPrintable
{
    public string MaSV { get; set; }
    public double DiemTB { get; set; }

    public SinhVien(string ma, string ten, DateTime ngaySinh, double diem)
        : base(ten, ngaySinh)
    {
        MaSV = ma;
        DiemTB = diem;
    }

    public override string MoTa()
    {
        return base.MoTa() + " - " + MaSV + " - " + DiemTB.ToString("N2");
    }

    public bool IsValid(out string message)
    {
        if (string.IsNullOrWhiteSpace(MaSV)) { message = "Thiếu mã sinh viên"; return false; }
        if (DiemTB < 0 || DiemTB > 10) { message = "Điểm trung bình không hợp lệ"; return false; }
        message = ""; return true;
    }

    public string ToDisplayText()
    {
        return MaSV + " - " + HoTen + " - Điểm TB: " + DiemTB;
    }
}