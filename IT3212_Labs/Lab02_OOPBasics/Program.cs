using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int chon;
        do
        {
            Console.WriteLine("\n================ CHƯƠNG TRÌNH LAB 2 - IT3212 ================");
            Console.WriteLine("1. Bài 1-4: Khai báo, Constructor, Đóng gói và Xếp loại SinhVien");
            Console.WriteLine("2. Bài 5: Quản lý danh sách SinhVien bằng List<T> và tìm kiếm");
            Console.WriteLine("3. Bài 6: Lớp SanPham và tính thành tiền");
            Console.WriteLine("4. Bài 7: Lớp TaiKhoanNganHang (Nạp/Rút tiền)");
            Console.WriteLine("5. Bài 8: Lớp NhanVien và tính bảng lương");
            Console.WriteLine("6. Bài 9: Lớp HinhChuNhat (Constructor và kiểm tra cạnh)");
            Console.WriteLine("7. Bài 10: Ứng dụng Console quản lý danh sách SinhVien đầy đủ (Thêm, Sửa, Xóa, Tìm kiếm)");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Mời bạn chọn bài tập (0-7): ");

            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
                continue;
            }

            Console.WriteLine();
            switch (chon)
            {
                case 1: ChayBai1den4(); break;
                case 2: ChayBai5(); break;
                case 3: ChayBai6(); break;
                case 4: ChayBai7(); break;
                case 5: ChayBai8(); break;
                case 6: ChayBai9(); break;
                case 7: ChayBai10(); break;
                case 0: Console.WriteLine("Thoát Lab 2!"); break;
                default: Console.WriteLine("Lựa chọn không tồn tại."); break;
            }
            if (chon != 0)
            {
                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
                Console.Clear();
            }
        } while (chon != 0);
    }

    static void ChayBai1den4()
    {
        Console.WriteLine("--- BÀI 1 - 4: KIỂM TRA ĐỐI TƯỢNG SINH VIÊN ---");
        SinhVien sv1 = new SinhVien("SV01", "Nguyen Van An", new DateTime(2005, 5, 12), 8.5);
        sv1.HienThi();
    }

    static void ChayBai5()
    {
        Console.WriteLine("--- BÀI 5: QUẢN LÝ DANH SÁCH SINH VIÊN ---");
        List<SinhVien> ds = new List<SinhVien>
        {
            new SinhVien("SV01", "Nguyễn An", new DateTime(2005, 5, 12), 8.2),
            new SinhVien("SV02", "Trần Bình", new DateTime(2005, 9, 3), 6.8),
            new SinhVien("SV03", "Lê Chi", new DateTime(2004, 2, 19), 9.1)
        };

        foreach (SinhVien sv in ds) sv.HienThi();

        Console.Write("\nNhập mã sinh viên cần tìm: ");
        string ma = Console.ReadLine();
        SinhVien ketQua = ds.Find(x => x.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase));
        if (ketQua == null) Console.WriteLine("Không tìm thấy sinh viên!");
        else ketQua.HienThi();
    }

    static void ChayBai6()
    {
        Console.WriteLine("--- BÀI 6: QUẢN LÝ SẢN PHẨM ---");
        SanPham sp = new SanPham { MaSP = "P01", TenSP = "Laptop Dell", DonGia = 15000000, SoLuong = 2 };
        sp.HienThi();
    }

    static void ChayBai7()
    {
        Console.WriteLine("--- BÀI 7: TÀI KHOẢN NGÂN HÀNG ---");
        TaiKhoanNganHang tk = new TaiKhoanNganHang { SoTaiKhoan = "123456", TenChuTaiKhoan = "Nguyen Van A", SoDu = 1000000 };
        Console.WriteLine($"Số dư ban đầu: {tk.SoDu:N0}");
        tk.NapTien(500000);
        Console.WriteLine($"Sau khi nạp 500k: {tk.SoDu:N0}");
        tk.RutTien(200000);
        Console.WriteLine($"Sau khi rút 200k: {tk.SoDu:N0}");
    }

    static void ChayBai8()
    {
        Console.WriteLine("--- BÀI 8: QUẢN LÝ NHÂN VIÊN ---");
        NhanVien nv = new NhanVien { MaNV = "NV01", HoTen = "Phạm Văn Minh", LuongCoBan = 3000000, HeSoLuong = 2.3, PhuCap = 500000 };
        nv.HienThi();
    }

    static void ChayBai9()
    {
        Console.WriteLine("--- BÀI 9: HÌNH CHỮ NHẬT ---");
        HinhChuNhat hcn = new HinhChuNhat(5, 3);
        Console.WriteLine($"Chu vi: {hcn.TinhChuVi()} | Diện tích: {hcn.TinhDienTich()}");
    }

    static void ChayBai10()
    {
        Console.WriteLine("--- BÀI 10: ỨNG DỤNG QUẢN LÝ SINH VIÊN (CRUD) ---");
        List<SinhVien> danhSach = new List<SinhVien>();
        int luaChon;
        do
        {
            Console.WriteLine("\n1. Thêm sinh viên | 2. Xem danh sách | 3. Tìm kiếm theo mã | 0. Quay lại");
            Console.Write("Chọn chức năng: ");
            if (!int.TryParse(Console.ReadLine(), out luaChon)) continue;

            if (luaChon == 1)
            {
                Console.Write("Mã SV: "); string ma = Console.ReadLine();
                Console.Write("Họ Tên: "); string ten = Console.ReadLine();
                Console.Write("Điểm TB: "); double d = double.Parse(Console.ReadLine());
                danhSach.Add(new SinhVien(ma, ten, DateTime.Today, d));
                Console.WriteLine("Đã thêm thành công!");
            }
            else if (luaChon == 2)
            {
                foreach (var sv in danhSach) sv.HienThi();
            }
            else if (luaChon == 3)
            {
                Console.Write("Nhập mã cần tìm: "); string ma = Console.ReadLine();
                var sv = danhSach.Find(x => x.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase));
                if (sv != null) sv.HienThi(); else Console.WriteLine("Không tìm thấy!");
            }
        } while (luaChon != 0);
    }
}