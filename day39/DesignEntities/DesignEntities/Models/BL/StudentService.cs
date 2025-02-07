using DesignEntities.Models.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEntities.Models.BL
{
    public class StudentService : IStudentService
    {
        private List<Student> _students; 

        public StudentService()
        {
            _students = new List<Student>(); 
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetStudentById(int id)
        {
            return _students.Find(s => s.Id == id);
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        
    }
}
