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
            Console.WriteLine("\n================ CHƯƠNG TRÌNH LAB 3 - IT3212 ================");
            Console.WriteLine("1. Bài 1 & 2: Kế thừa Nguoi - SinhVien và ghi đè phương thức MoTa()");
            Console.WriteLine("2. Bài 3 & 5: Lớp trừu tượng NguoiHoc và tính học phí đa hình");
            Console.WriteLine("3. Bài 4: Interface IValidatable và IPrintable");
            Console.WriteLine("4. Bài 6: Hệ thống Nhân viên (Tính lương đa hình)");
            Console.WriteLine("5. Bài 7: Quản lý phương tiện (Interface IMove)");
            Console.WriteLine("6. Bài 8: Quản lý tài liệu thư viện");
            Console.WriteLine("7. Bài 9: Hệ thống thanh toán (Interface IPayment)");
            Console.WriteLine("8. Bài 10: Nâng cấp quản lý sinh viên đa hình tổng hợp");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Mời bạn chọn bài tập (0-8): ");

            if (!int.TryParse(Console.ReadLine(), out chon)) continue;
            Console.WriteLine();

            switch (chon)
            {
                case 1: ChayBai1_2(); break;
                case 2: ChayBai3_5(); break;
                case 3: ChayBai4(); break;
                case 4: ChayBai6(); break;
                case 5: ChayBai7(); break;
                case 6: ChayBai8(); break;
                case 7: ChayBai9(); break;
                case 8: ChayBai10(); break;
                case 0: Console.WriteLine("Thoát chương trình Lab 3!"); break;
                default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
            }
            if (chon != 0)
            {
                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
                Console.Clear();
            }
        } while (chon != 0);
    }

    static void ChayBai1_2()
    {
        Console.WriteLine("--- BÀI 1 & 2: KẾ THỪA VÀ GHI ĐÈ ---");
        SinhVien sv = new SinhVien("SV01", "Nguyễn Văn An", new DateTime(2005, 5, 12), 8.5);
        Console.WriteLine(sv.MoTa());
    }

    static void ChayBai3_5()
    {
        Console.WriteLine("--- BÀI 3 & 5: ĐA HÌNH HỌC PHÍ ---");
        List<NguoiHoc> ds = new List<NguoiHoc>
        {
            new SinhVienChinhQuy { HoTen = "An", SoTinChi = 18 },
            new SinhVienLienThong { HoTen = "Bình", SoTinChi = 15 }
        };

        decimal tong = 0;
        foreach (NguoiHoc item in ds)
        {
            decimal hocPhi = item.TinhHocPhi();
            tong += hocPhi;
            Console.WriteLine("{0} - Học phí: {1:N0} VNĐ", item.HoTen, hocPhi);
        }
        Console.WriteLine("Tổng học phí: {0:N0} VNĐ", tong);
    }

    static void ChayBai4()
    {
        Console.WriteLine("--- BÀI 4: INTERFACE KIỂM TRA VÀ HIỂN THỊ ---");
        SinhVien sv = new SinhVien("SV02", "Trần Bình", new DateTime(2005, 9, 3), 9.2);
        string msg;
        if (sv.IsValid(out msg))
        {
            Console.WriteLine("Kiểm tra dữ liệu: Hợp lệ!");
            Console.WriteLine(sv.ToDisplayText());
        }
        else
        {
            Console.WriteLine("Lỗi: " + msg);
        }
    }

    static void ChayBai6()
    {
        Console.WriteLine("--- BÀI 6: HỆ THỐNG NHÂN VIÊN ---");
        List<NhanVienLab3> dsNV = new List<NhanVienLab3>
        {
            new NhanVienVanPhong { HoTen = "Minh", LuongCung = 8000000 },
            new GiangVien { HoTen = "Tuấn", SoTiet = 45, DonGia = 120000 }
        };
        foreach (var nv in dsNV)
        {
            Console.WriteLine($"Nhân viên: {nv.HoTen} | Lương: {nv.TinhLuong():N0} VNĐ");
        }
    }

    static void ChayBai7()
    {
        Console.WriteLine("--- BÀI 7: QUẢN LÝ PHƯƠNG TIỆN ---");
        List<IMove> dsXe = new List<IMove> { new XeMay(), new OTo() };
        foreach (var xe in dsXe)
        {
            xe.ChuyenDong();
            Console.WriteLine($"Chi phí vận hành: {xe.TinhChiPhi():N0} VNĐ\n");
        }
    }

    static void ChayBai8()
    {
        Console.WriteLine("--- BÀI 8: TÀI LIỆU THƯ VIỆN ---");
        TaiLieu sach = new Sach { MaTaiLieu = "S01", TenTaiLieu = "Lập trình C#", TacGia = "John Smith" };
        sach.HienThi();
    }

    static void ChayBai9()
    {
        Console.WriteLine("--- BÀI 9: HỆ THỐNG THANH TOÁN ---");
        IPayment thanhToan = new ChuyenKhoan();
        thanhToan.ThanhToan(500000);
    }

    static void ChayBai10()
    {
        Console.WriteLine("--- BÀI 10: NÂNG CẤP QUẢN LÝ SINH VIÊN ĐA HÌNH ---");
        List<NguoiHoc> ds = new List<NguoiHoc>
        {
            new SinhVienChinhQuy { HoTen = "Nguyễn Văn An", SoTinChi = 20 },
            new SinhVienLienThong { HoTen = "Trần Thị Bình", SoTinChi = 15 }
        };
        Console.WriteLine($"Đã nạp thành công hệ thống quản lý nâng cao với {ds.Count} loại học viên đa hình.");
    }
}