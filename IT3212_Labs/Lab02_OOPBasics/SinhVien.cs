using System;

public class SinhVien
{
    // Trường dữ liệu ẩn (backing fields) phục vụ đóng gói (Bài 3)
    private string _hoTen;
    private double _diemTB;

    // Các thuộc tính (Properties)
    public string MaSV { get; set; }

    public string HoTen
    {
        get { return _hoTen; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Họ tên không được rỗng.");
            _hoTen = value.Trim();
        }
    }

    public DateTime NgaySinh { get; set; }

    public double DiemTB
    {
        get { return _diemTB; }
        set
        {
            if (value < 0 || value > 10)
                throw new ArgumentOutOfRangeException("DiemTB", "Điểm TB phải từ 0 đến 10.");
            _diemTB = value;
        }
    }

    // Constructor mặc định (Bài 2)
    public SinhVien()
    {
        MaSV = "Chưa có";
        HoTen = "Chưa có";
        NgaySinh = DateTime.Today;
        DiemTB = 0;
    }

    // Constructor đầy đủ tham số (Bài 2)
    public SinhVien(string maSV, string hoTen, DateTime ngaySinh, double diemTB)
    {
        MaSV = maSV;
        HoTen = hoTen;
        NgaySinh = ngaySinh;
        DiemTB = diemTB;
    }

    // Phương thức hiển thị thông tin
    public void HienThi()
    {
        Console.WriteLine("{0} - {1} - {2:dd/MM/yyyy} - Diem TB: {3:N2} - Tuoi: {4} - Xep loai: {5}",
            MaSV, HoTen, NgaySinh, DiemTB, TinhTuoi(), XepLoai());
    }

    // Phương thức nghiệp vụ: Tính tuổi (Bài 4)
    public int TinhTuoi()
    {
        int tuoi = DateTime.Today.Year - NgaySinh.Year;
        if (NgaySinh.Date > DateTime.Today.AddYears(-tuoi)) tuoi--;
        return tuoi;
    }

    // Phương thức nghiệp vụ: Xếp loại (Bài 4)
    public string XepLoai()
    {
        if (DiemTB >= 9) return "Xuất sắc";
        if (DiemTB >= 8) return "Giỏi";
        if (DiemTB >= 6.5) return "Khá";
        if (DiemTB >= 5) return "Trung bình";
        return "Yếu";
    }
}