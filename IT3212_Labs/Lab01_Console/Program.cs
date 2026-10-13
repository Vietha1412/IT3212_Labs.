using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int chon;
        do
        {
            Console.WriteLine("\n================ CHƯƠNG TRÌNH LAB 1 - IT3212 ================");
            Console.WriteLine("1. Bài 1: Nhập thông tin cá nhân và tính tuổi");
            Console.WriteLine("2. Bài 2: Tính diện tích xung quanh và thể tích hình trụ");
            Console.WriteLine("3. Bài 3: Xếp loại kết quả học tập");
            Console.WriteLine("4. Bài 4: Menu xử lý (Tổng 1..n, Bảng cửu chương)");
            Console.WriteLine("5. Bài 5: Xử lý ngoại lệ phép chia");
            Console.WriteLine("6. Bài 6: Giải phương trình bậc hai");
            Console.WriteLine("7. Bài 7: Thống kê dãy số nguyên");
            Console.WriteLine("8. Bài 8: Kiểm tra và in số nguyên tố không vượt quá n");
            Console.WriteLine("9. Bài 9: Đọc số từ 0 đến 99 bằng tiếng Việt");
            Console.WriteLine("10. Bài 10: Vẽ hình bằng ký tự (*)");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Mời bạn chọn bài tập (0-10): ");

            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập số.");
                continue;
            }

            Console.WriteLine();
            switch (chon)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break;
                case 5: Bai5(); break;
                case 6: Bai6(); break;
                case 7: Bai7(); break;
                case 8: Bai8(); break;
                case 9: Bai9(); break;
                case 10: Bai10(); break;
                case 0: Console.WriteLine("Thoát chương trình. Tạm biệt!"); break;
                default: Console.WriteLine("Lựa chọn không tồn tại từ 0 đến 10."); break;
            }
            if (chon != 0)
            {
                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
                Console.Clear();
            }
        } while (chon != 0);
    }

    static void Bai1()
    {
        Console.WriteLine("--- BÀI 1: NHẬP THÔNG TIN CÁ NHÂN ---");
        Console.Write("Họ và tên: ");
        string hoTen = Console.ReadLine();
        Console.Write("Năm sinh: ");
        int namSinh;
        if (!int.TryParse(Console.ReadLine(), out namSinh)) { Console.WriteLine("Năm sinh không hợp lệ."); return; }
        int tuoi = DateTime.Now.Year - namSinh;
        Console.WriteLine("Xin chào {0}, tuổi gần đúng: {1}", hoTen, tuoi);
    }

    static void Bai2()
    {
        Console.WriteLine("--- BÀI 2: TÍNH TOÁN HÌNH TRỤ ---");
        double r, h;
        Console.Write("Bán kính r = ");
        if (!double.TryParse(Console.ReadLine(), out r) || r <= 0) { Console.WriteLine("Bán kính phải lớn hơn 0."); return; }
        Console.Write("Chiều cao h = ");
        if (!double.TryParse(Console.ReadLine(), out h) || h <= 0) { Console.WriteLine("Chiều cao phải lớn hơn 0."); return; }
        double dienTichXQ = 2 * Math.PI * r * h;
        double theTich = Math.PI * r * r * h;
        Console.WriteLine("Sxq = {0:N2}; V = {1:N2}", dienTichXQ, theTich);
    }

    static void Bai3()
    {
        Console.WriteLine("--- BÀI 3: XẾP LOẠI HỌC TẬP ---");
        double diem;
        Console.Write("Nhập điểm (0-10): ");
        if (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
        {
            Console.WriteLine("Điểm phải thuộc [0, 10].");
        }
        else if (diem >= 9) Console.WriteLine("Xếp loại: Xuất sắc");
        else if (diem >= 8) Console.WriteLine("Xếp loại: Giỏi");
        else if (diem >= 6.5) Console.WriteLine("Xếp loại: Khá");
        else if (diem >= 5) Console.WriteLine("Xếp loại: Trung bình");
        else Console.WriteLine("Xếp loại: Yếu");
    }

    static void Bai4()
    {
        Console.WriteLine("--- BÀI 4: MENU XỬ LÝ (TỔNG & CỬU CHƯƠNG) ---");
        Console.WriteLine("1. Tính tổng 1..n");
        Console.WriteLine("2. In bảng cửu chương 7");
        Console.Write("Chọn chức năng con: ");
        int subChoice;
        if (int.TryParse(Console.ReadLine(), out subChoice))
        {
            if (subChoice == 1)
            {
                Console.Write("Nhập n = ");
                int n = int.Parse(Console.ReadLine());
                int tong = 0;
                for (int i = 1; i <= n; i++) tong += i;
                Console.WriteLine("Tổng từ 1 đến {0} là: {1}", n, tong);
            }
            else if (subChoice == 2)
            {
                for (int i = 1; i <= 10; i++) Console.WriteLine("7 x {0} = {1}", i, 7 * i);
            }
        }
    }

    static void Bai5()
    {
        Console.WriteLine("--- BÀI 5: XỬ LÝ NGOẠI LỆ PHÉP CHIA ---");
        try
        {
            Console.Write("Nhập số a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Kết quả a / b = " + (a / b));
        }
        catch (FormatException) { Console.WriteLine("Lỗi: Dữ liệu phải là số nguyên."); }
        catch (DivideByZeroException) { Console.WriteLine("Lỗi: Không thể chia cho 0."); }
        finally { Console.WriteLine("Kết thúc quá trình tính toán."); }
    }

    static void Bai6()
    {
        Console.WriteLine("--- BÀI 6: GIẢI PHƯƠNG TRÌNH BẬC HAI (ax^2 + bx + c = 0) ---");
        Console.Write("Nhập a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập c = ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0) Console.WriteLine("Phương trình vô số nghiệm.");
                else Console.WriteLine("Phương trình vô nghiệm.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Phương trình có 1 nghiệm: x = {0:N2}", x);
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0) Console.WriteLine("Phương trình vô nghiệm thực.");
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0:N2}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt: x1 = {0:N2}, x2 = {1:N2}", x1, x2);
            }
        }
    }

    static void Bai7()
    {
        Console.WriteLine("--- BÀI 7: THỐNG KÊ DÃY SỐ ---");
        Console.Write("Nhập số lượng phần tử n = ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0) return;

        int[] arr = new int[n];
        int tong = 0, soChan = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Phần tử thứ {0}: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
            tong += arr[i];
            if (arr[i] % 2 == 0) soChan++;
        }

        double trungBinh = (double)tong / n;
        int max = arr[0], min = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }

        Console.WriteLine("Tổng: {0} | Trung bình: {1:N2} | Max: {2} | Min: {3} | Số chẵn: {4}", tong, trungBinh, max, min, soChan);
    }

    static void Bai8()
    {
        Console.WriteLine("--- BÀI 8: SỐ NGUYÊN TỐ ---");
        Console.Write("Nhập n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Các số nguyên tố từ 2 đến {0}: ", n);
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i)) Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static void Bai9()
    {
        Console.WriteLine("--- BÀI 9: ĐỌC SỐ TỪ 0 ĐẾN 99 ---");
        Console.Write("Nhập số (0-99): ");
        int num = int.Parse(Console.ReadLine());
        if (num < 0 || num > 99) { Console.WriteLine("Sai khoảng giá trị."); return; }

        string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        if (num < 10) Console.WriteLine(chuSo[num]);
        else
        {
            int chuc = num / 10;
            int donVi = num % 10;
            string docChuc = (chuc == 1) ? "mười" : chuSo[chuc] + " mươi";
            string docDonVi = "";
            if (donVi == 1 && chuc > 1) docDonVi = " mốt";
            else if (donVi == 5 && chuc > 1) docDonVi = " lăm";
            else if (donVi > 0) docDonVi = " " + chuSo[donVi];
            Console.WriteLine(docChuc + docDonVi);
        }
    }

    static void Bai10()
    {
        Console.WriteLine("--- BÀI 10: VẼ HÌNH ---");
        Console.Write("Nhập chiều cao h: ");
        int h = int.Parse(Console.ReadLine());

        Console.WriteLine("1. Tam giác vuông đặc:");
        for (int i = 1; i <= h; i++)
        {
            for (int j = 1; j <= i; j++) Console.Write("* ");
            Console.WriteLine();
        }

        Console.WriteLine("\n2. Hình vuông rỗng:");
        for (int i = 1; i <= h; i++)
        {
            for (int j = 1; j <= h; j++)
            {
                if (i == 1 || i == h || j == 1 || j == h) Console.Write("* ");
                else Console.Write("  ");
            }
            Console.WriteLine();
        }
    }
}