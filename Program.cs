using System;
using System.Data.Entity;

namespace CodeFirstStudentApp
{
    // Student sınıfı (model)
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // DbContext sınıfı
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Yeni öğrenci ekle
                var student = new Student
                {
                    Name = "John Doe",
                    Age = 20
                };

                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Student added successfully!");
        }
    }
}
