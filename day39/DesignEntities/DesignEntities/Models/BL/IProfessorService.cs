using DesignEntities.Models.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEntities.Models.BL
{
    public interface IProfessorService
    {
        List<Professor> GetAllProfessors();
        Professor GetProfessorById(int id);
        void AddProfessor(Professor professor);
        decimal CalculateSalary(int professorId); 
                                                 
    }
}
