using MVCPatternExample.Models;
using MVCPatternExample.Views;
using MVCPatternExample.Controllers;

Student student = new Student();

Console.Write("Enter Student ID: ");
student.Id = int.Parse(Console.ReadLine()!);

Console.Write("Enter Student Name: ");
student.Name = Console.ReadLine()!;

Console.Write("Enter Grade: ");
student.Grade = Console.ReadLine()!;

StudentView view = new StudentView();
StudentController controller = new StudentController(student, view);

controller.ShowStudent();

Console.WriteLine("\nUpdate Student Details");

Console.Write("Enter New Name: ");
string newName = Console.ReadLine()!;

Console.Write("Enter New Grade: ");
string newGrade = Console.ReadLine()!;

controller.UpdateStudent(newName, newGrade);

controller.ShowStudent();