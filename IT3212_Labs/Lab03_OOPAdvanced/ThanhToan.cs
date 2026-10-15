using System;

public interface IPayment
{
    bool ThanhToan(decimal soTien);
}

public class ChuyenKhoan : IPayment
{
    public bool ThanhToan(decimal soTien)
    {
        Console.WriteLine($"Đã thanh toán {soTien:N0} VNĐ qua chuyển khoản ngân hàng.");
        return true;
    }
}