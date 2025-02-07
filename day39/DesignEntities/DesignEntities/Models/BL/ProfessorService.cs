using DesignEntities.Models.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEntities.Models.BL
{
    public class ProfessorService : IProfessorService
    {
        private List<Professor> _professors;

        public ProfessorService()
        {
            _professors = new List<Professor>();
        }

        public List<Professor> GetAllProfessors()
        {
            return _professors;
        }

        public Professor GetProfessorById(int id)
        {
            return _professors.Find(p => p.Id == id);
        }

        public void AddProfessor(Professor professor)
        {
            _professors.Add(professor);
        }
        public decimal CalculateSalary(int professorId)
        {
            Professor professor = GetProfessorById(professorId);
            if (professor != null)
            {
                return professor.CalculateSalary();
            }
            return 0; 
        }

        
    }
}
