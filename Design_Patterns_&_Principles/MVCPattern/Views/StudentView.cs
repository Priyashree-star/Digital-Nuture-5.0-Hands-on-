using MVCPatternExample.Models;

namespace MVCPatternExample.Views
{
    public class StudentView
    {
        public void DisplayStudentDetails(Student student)
        {
            Console.WriteLine("\n----- Student Details -----");
            Console.WriteLine($"ID    : {student.Id}");
            Console.WriteLine($"Name  : {student.Name}");
            Console.WriteLine($"Grade : {student.Grade}");
        }
    }
}