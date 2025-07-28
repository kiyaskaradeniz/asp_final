using System;

namespace StudentManagement
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Program { get; set; }
        public string AcademicYear { get; set; }
        public double GPA { get; set; }
        public string StudentClubs { get; set; }
        public string Achievements { get; set; }
        public string EmergencyContact { get; set; }
        public bool IsInternational { get; set; }
    }
}