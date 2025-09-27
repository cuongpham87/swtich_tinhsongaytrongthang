// Viết một chương trình tính số ngày trong tháng của một tháng cho trước
// Trong một năm, tháng 2 có thể có 28 hoặc 29 ngày,
//Các tháng 1, 3, 5, 7, 8, 10, 12 có 31 ngày,
// các tháng còn lại có 30 ngày.
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhập tháng muốn biết số ngày");
        int month = Convert.ToInt32(Console.ReadLine());
        switch (month)
        {
            case 2:
                Console.WriteLine("tháng 2 có 28 hoặc 29 ngày");
                break;
            case 1:
                Console.WriteLine("Tháng 1 có 31 ngày");
                break;
            case 3:
                Console.WriteLine("tháng 3 có 31 ngày");
                break;
            case 4:
                Console.WriteLine("Tháng 4 có 30 ngày");
                break;
            case 5:
                Console.WriteLine("tháng 5 có 31 ngày");
                break;
            case 6:
                Console.WriteLine("Tháng 6 có 30 ngày");
                break;
            case 7:
                Console.WriteLine("tháng 7 có 31 ngày");
                break;
            case 8:
                Console.WriteLine("Tháng 8 có 31 ngày");
                break;
            case 9:
                Console.WriteLine("tháng 9 có 30 ngày");
                break;
            case 10:
                Console.WriteLine("Tháng 10 có 31 ngày");
                break;
            case 11:
                Console.WriteLine("tháng 11 có 30 ngày");
                break;
            case 12:
                Console.WriteLine("tháng 12 có 31 ngày");
                break;
            default:
                Console.WriteLine("Tháng không hợp lệ");
                break; 
        }
    }
}
