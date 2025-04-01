using System;
using System.ComponentModel.Design;

class Student
{
    public string Name;
    public int Age;
    public double Grade;
    public float DiemToan;
    public float DiemVan;
    public float DiemAnh;

    public void Getresult()
    {
        Grade = (DiemToan + DiemVan + DiemAnh)/3;

        if (Grade >= 8 && Grade <= 10)
        {
            Console.WriteLine("Diem trung binh cua " + Name + " la " + Grade + ": Dat Loai Gioi!");
        }
        else if (Grade >= 5)
        {
            Console.WriteLine("Diem trung binh cua " + Name + " la " + Grade + ": Dat Loai Kha!");
        }
        else if (Grade >= 3)
        {
            Console.WriteLine("Diem trung binh cua " + Name + " la " + Grade + ": Dat Loai Trung Binh!");
        }
        else 
        {
            Console.WriteLine("Diem trung binh cua " + Name + " la " + Grade + ": Truot!");
        }
    }

    public void DisplayAllStudent()
    {
        Console.WriteLine("Thong tin sinh vien: ");
        Console.WriteLine("Ten: " + Name);
        Console.WriteLine("Tuoi: " + Age);
        Console.WriteLine("Diem Toan: " + DiemToan);
        Console.WriteLine("Diem Van: " + DiemVan);
        Console.WriteLine("Diem Anh: " + DiemAnh);
    }
}

class Program

{
    public static void Main(string[] args)
    {
        List<Student> Students = new List<Student>();

        Student student1 = new Student();
        Console.Write("Hay nhap ten sinh vien 1: ");
        student1.Name = Console.ReadLine();
        Console.Write("Hay nhap tuoi cua sinh vien 1: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out student1.Age) && student1.Age > 0 && student1.Age < 55)
            {
                break;  // Nếu nhập hợp lệ và tuổi là số dương, thoát khỏi vòng lặp
            }
            else
            {
                Console.WriteLine("Tuoi khong hop le, vui long nhap lai! (Tuoi phai la so nguyen duong).");
                Console.Write("Hay nhap tuoi cua sinh vien 1: ");  // Yêu cầu nhập lại tuổi
            }
        }
        Console.Write("Hay nhap diem toan cua sinh vien 1: ");
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out student1.DiemToan)) // Kiểm tra xem có phải là số thực không
            {
                if (student1.DiemToan >= 0 && student1.DiemToan <= 10) // Kiểm tra xem điểm có trong khoảng 0-10 không
                {
                    break; // Nếu nhập hợp lệ, thoát khỏi vòng lặp
                }
                else
                {
                    Console.WriteLine("Diem Toan khong hop le. Vui long nhap lai (Diem Toan phai tu 0 den 10).");
                }
            }
            else
            {
                Console.WriteLine("Diem Toan khong hop le. Vui long nhap lai (Diem Toan phai la so).");
            }
            Console.Write("Hay nhap diem toan cua sinh vien 1: "); // Nếu không hợp lệ, yêu cầu nhập lại
        }
        Console.Write("Hay nhap diem van cua sinh vien 1: ");
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out student1.DiemVan)) // Kiểm tra xem có phải là số thực không
            {
                if (student1.DiemVan >= 0 && student1.DiemVan <= 10) // Kiểm tra xem điểm có trong khoảng 0-10 không
                {
                    break; // Nếu nhập hợp lệ, thoát khỏi vòng lặp
                }
                else
                {
                    Console.WriteLine("Diem van khong hop le. Vui long nhap lai (Diem van phai tu 0 den 10).");
                }
            }
            else
            {
                Console.WriteLine("Diem van khong hop le. Vui long nhap lai (Diem Van phai la so).");
            }
            Console.Write("Hay nhap diem van cua sinh vien 1: "); // Nếu không hợp lệ, yêu cầu nhập lại
        }
        Console.Write("Hay nhap diem anh cua sinh vien 1: ");
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out student1.DiemAnh)) // Kiểm tra xem có phải là số thực không
            {
                if (student1.DiemAnh >= 0 && student1.DiemAnh <= 10) // Kiểm tra xem điểm có trong khoảng 0-10 không
                {
                    break; // Nếu nhập hợp lệ, thoát khỏi vòng lặp
                }
                else
                {
                    Console.WriteLine("Diem anh khong hop le. Vui long nhap lai (Diem anh phai tu 0 den 10).");
                }
            }
            else
            {
                Console.WriteLine("Diem anh khong hop le. Vui long nhap lai (Diem Van phai la so).");
            }
            Console.Write("Hay nhap diem anh cua sinh vien 1: "); // Nếu không hợp lệ, yêu cầu nhập lại
        }
        Students.Add(student1);

        Student student2 = new Student();
        Console.Write("Hay nhap ten sinh vien 2: ");
        student2.Name = Console.ReadLine();
        Console.Write("Hay nhap tuoi cua sinh vien 2: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out student2.Age) && student2.Age > 0 && student2.Age < 55)
            {
                break;  // Nếu nhập hợp lệ và tuổi là số dương, thoát khỏi vòng lặp
            }
            else
            {
                Console.WriteLine("Tuoi khong hop le, vui long nhap lai! (Tuoi phai la so nguyen duong).");
                Console.Write("Hay nhap tuoi cua sinh vien 2: ");  // Yêu cầu nhập lại tuổi
            }
        }
        Console.Write("Hay nhap diem toan cua sinh vien 2: ");
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out student2.DiemToan)) // Kiểm tra xem có phải là số thực không
            {
                if (student2.DiemToan >= 0 && student2.DiemToan <= 10) // Kiểm tra xem điểm có trong khoảng 0-10 không
                {
                    break; // Nếu nhập hợp lệ, thoát khỏi vòng lặp
                }
                else
                {
                    Console.WriteLine("Diem Toan khong hop le. Vui long nhap lai (Diem Toan phai tu 0 den 10).");
                }
            }
            else
            {
                Console.WriteLine("Diem Toan khong hop le. Vui long nhap lai (Diem Toan phai la so).");
            }
            Console.Write("Hay nhap diem toan cua sinh vien 2: "); // Nếu không hợp lệ, yêu cầu nhập lại
        }
        Console.Write("Hay nhap diem van cua sinh vien 2: ");
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out student2.DiemVan)) // Kiểm tra xem có phải là số thực không
            {
                if (student2.DiemVan >= 0 && student2.DiemVan <= 10) // Kiểm tra xem điểm có trong khoảng 0-10 không
                {
                    break; // Nếu nhập hợp lệ, thoát khỏi vòng lặp
                }
                else
                {
                    Console.WriteLine("Diem van khong hop le. Vui long nhap lai (Diem van phai tu 0 den 10).");
                }
            }
            else
            {
                Console.WriteLine("Diem van khong hop le. Vui long nhap lai (Diem Van phai la so).");
            }
            Console.Write("Hay nhap diem van cua sinh vien 2: "); // Nếu không hợp lệ, yêu cầu nhập lại
        }
        Console.Write("Hay nhap diem anh cua sinh vien 2: ");
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out student2.DiemAnh)) // Kiểm tra xem có phải là số thực không
            {
                if (student2.DiemAnh >= 0 && student2.DiemAnh <= 10) // Kiểm tra xem điểm có trong khoảng 0-10 không
                {
                    break; // Nếu nhập hợp lệ, thoát khỏi vòng lặp
                }
                else
                {
                    Console.WriteLine("Diem anh khong hop le. Vui long nhap lai (Diem anh phai tu 0 den 10).");
                }
            }
            else
            {
                Console.WriteLine("Diem anh khong hop le. Vui long nhap lai (Diem Van phai la so).");
            }
            Console.Write("Hay nhap diem anh cua sinh vien 2: "); // Nếu không hợp lệ, yêu cầu nhập lại
        }
        Students.Add(student2);

        foreach (Student student in Students) 
        {
            student.DisplayAllStudent();
            student.Getresult();
            Console.WriteLine();
        }
    }
}