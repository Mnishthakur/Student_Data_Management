using System.Collections.Generic;
using System.Linq;
namespace Student_Data_Management
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public double TotalMarks { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // Create a list of Student objects
            List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ankit", PhoneNumber = "1234567890", Address = "Address 1", Age = 16, TotalMarks = 85.5 },
            new Student { Id = 2, Name = "Rahul", PhoneNumber = "9876543210", Address = "Address 2", Age = 14, TotalMarks = 92.0 },
            new Student { Id = 3, Name = "Payal", PhoneNumber = "4567890123", Address = "Address 1", Age = 18, TotalMarks = 78.5 },
            new Student { Id = 4, Name = "Salet", PhoneNumber = "3210987654", Address = "Address 3", Age = 20, TotalMarks = 88.7 },
            new Student { Id = 5, Name = "Juhi", PhoneNumber = "7890123456", Address = "Address 2", Age = 15, TotalMarks = 76.2 }
        };

            Console.WriteLine("All Student Details:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}, Total Marks: {student.TotalMarks}");
            }
        }
    }
}

