using PersonelApp.Domains;
using PersonnelApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    class DepartmentRepository: Repository<Department>, IDepartmentRepository
    {
        
        public DepartmentRepository(PersonnelContext context) : base(context)
        {
            
        }

        public IEnumerable<Department> GetDepartmentsWithPersonnels()
        {
            return PersonnelContext.Departments.Include("Personnel").ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonnelContext.Departments.Take(count);
        }
        public PersonnelContext PersonnelContext { get { return _context as PersonnelContext; } }
    }
}
