using System;

public class TaiLieu
{
    public string MaTaiLieu { get; set; }
    public string TenTaiLieu { get; set; }
    public virtual void HienThi() => Console.WriteLine($"Tài liệu: {MaTaiLieu} - {TenTaiLieu}");
}

public class Sach : TaiLieu
{
    public string TacGia { get; set; }
    public override void HienThi() => Console.WriteLine($"Sách: {MaTaiLieu} - {TenTaiLieu} | Tác giả: {TacGia}");
}