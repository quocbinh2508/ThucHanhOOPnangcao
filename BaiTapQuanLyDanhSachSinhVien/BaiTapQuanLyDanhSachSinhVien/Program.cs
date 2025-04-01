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

    public void GetGrade()
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

class StudentManager
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void DisplayAllStudent()
    {
        foreach (Student student in students)
        {
            student.DisplayAllStudent();
            student.GetGrade();
            Console.WriteLine();
        }
    }
    public void GetAverageGrade()
    {
        double TotalGrade = 0;
        foreach (Student student in students)
        {
            TotalGrade += student.Grade;
        }

        double averageGrade = TotalGrade / students.Count;
        Console.WriteLine("Diem trung binh cua tat ca sinh vien: " + averageGrade);
    }
}


class Program

{
    public static void Main(string[] args)
    {
        StudentManager studentManager = new StudentManager();

        Student student1 = new Student();
        Console.Write("Hay nhap ten sinh vien 1: ");
        while (true)
        {
            student1.Name = Console.ReadLine();  // Nhập tên sinh viên
            if (!string.IsNullOrEmpty(student1.Name))  // Kiểm tra xem tên có rỗng không
            {
                break;  // Nếu tên hợp lệ, thoát khỏi vòng lặp
            }
            else
            {
                Console.WriteLine("Ten sinh vien khong hop le. Vui long nhap lai!");
                Console.Write("Hay nhap ten sinh vien 1: ");  // Yêu cầu nhập lại tên
            }
        }
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
        student1.DiemToan = GetValidGrade();
        Console.Write("Hay nhap diem van cua sinh vien 1: ");
        student1.DiemVan = GetValidGrade();
        Console.Write("Hay nhap diem anh cua sinh vien 1: ");
        student1.DiemAnh = GetValidGrade();
        studentManager.AddStudent(student1);

        Student student2 = new Student();
        Console.Write("Hay nhap ten sinh vien 2: ");
        while (true)
        {
            student2.Name = Console.ReadLine();  // Nhập tên sinh viên
            if (!string.IsNullOrEmpty(student2.Name))  // Kiểm tra xem tên có rỗng không
            {
                break;  // Nếu tên hợp lệ, thoát khỏi vòng lặp
            }
            else
            {
                Console.WriteLine("Ten sinh vien khong hop le. Vui long nhap lai!");
                Console.Write("Hay nhap ten sinh vien 2: ");  // Yêu cầu nhập lại tên
            }
        }
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
        student2.DiemToan = GetValidGrade();
        Console.Write("Hay nhap diem van cua sinh vien 2: ");
        student2.DiemVan = GetValidGrade();
        Console.Write("Hay nhap diem anh cua sinh vien 2: ");
        student2.DiemAnh = GetValidGrade();
        studentManager.AddStudent(student2);

        studentManager.DisplayAllStudent();
        studentManager.GetAverageGrade();
    }
    public static float GetValidGrade()
    {
        float grade;
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out grade))
            {
                if (grade >= 0 && grade <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Diem khong hop le, vui long nhap lai (Diem phai tu 0 den 10).");
                }
            }
            else
            {
                Console.WriteLine("Diem khong hop le, vui long nhap lai (Diem phai la so).");
            }
            Console.Write("Vui long nhap lai diem: ");
        }
        return grade;
    }

}