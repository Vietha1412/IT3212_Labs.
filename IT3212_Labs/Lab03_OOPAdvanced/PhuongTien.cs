using System;

public interface IMove
{
    void ChuyenDong();
    double TinhChiPhi();
}

public class XeMay : IMove
{
    public void ChuyenDong() => Console.WriteLine("Xe máy chạy 60 km/h trên đường bộ.");
    public double TinhChiPhi() => 15000;
}

public class OTo : IMove
{
    public void ChuyenDong() => Console.WriteLine("Ô tô chạy 100 km/h trên cao tốc.");
    public double TinhChiPhi() => 80000;
}