using System;

public class Nguoi
{
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }

    public Nguoi(string hoTen, DateTime ngaySinh)
    {
        HoTen = hoTen;
        NgaySinh = ngaySinh;
    }

    public virtual string MoTa()
    {
        return HoTen + " - " + NgaySinh.ToString("dd/MM/yyyy");
    }
}