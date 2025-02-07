using DesignEntities.Models.BL;
using DesignEntities.Models.DL;

namespace DesignEntities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentService studentService = new StudentService();
            IProfessorService professorService = new ProfessorService();

            // Student:
            Student newStudent = new Student { Id = 1, Address = "Kalyan", Dob = new DateTime(2002, 10, 20), Branch = "Computer Science" };
            Student newStudent1 = new Student { Id = 2, Address = "Mumbai", Dob = new DateTime(2002, 10, 10), Branch = "Electrical" };
            studentService.AddStudent(newStudent);
            studentService.AddStudent(newStudent1);


            // Professor:
            Professor newProfessor = new Professor { Id = 101, Address = "Mumbai", Dob = new DateTime(1975, 5, 15), BaseSalary = 50000, YearsOfExperience = 10, Department = "Computer Science" };
            Professor newProfessor1 = new Professor { Id = 102, Address = "Kalyan", Dob = new DateTime(1985, 5, 15), BaseSalary = 40000, YearsOfExperience = 10, Department = "History" };
            professorService.AddProfessor(newProfessor);
            professorService.AddProfessor(newProfessor1);


            List<Student> allStudents = studentService.GetAllStudents();
            foreach (var student in allStudents)
            {
                Console.WriteLine($"Student: Id={student.Id}, Branch={student.Branch}");
            }

            Console.WriteLine();

            List<Professor> pro=professorService.GetAllProfessors(); ;
            foreach (var professor in pro)
            {
                Console.WriteLine($"Professor: Id={professor.Id}, Dob :{professor.Dob}, Branch : {professor.Department}");
                decimal professorSalary = professorService.CalculateSalary(professor.Id);
                Console.WriteLine($"Professor Salary: {professorSalary}");
            }


            

            Console.ReadKey();
        }
    }
}
