using System;
using Microsoft.EntityFrameworkCore;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();

                // Create a new student
                var student = new Student
                {
                    FirstName = "Alex",
                    LastName = "Chen",
                    DateOfBirth = new DateTime(2001, 3, 10),
                    Email = "alex.chen@example.com",
                    Program = "Computer Science",
                    AcademicYear = "Junior",
                    GPA = 3.95,
                    StudentClubs = "Programming Club, Chess Club",
                    Achievements = "First Place in Coding Competition 2023",
                    EmergencyContact = "555-9876",
                    IsInternational = true
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.WriteLine($"Student ID: {student.StudentId}");
                Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                Console.WriteLine($"Program: {student.Program}");
                Console.WriteLine($"Academic Year: {student.AcademicYear}");
                Console.WriteLine($"GPA: {student.GPA}");
                Console.WriteLine($"Clubs: {student.StudentClubs}");
                Console.WriteLine($"International Student: {student.IsInternational}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}