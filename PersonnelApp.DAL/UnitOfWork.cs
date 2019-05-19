using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.DAL.Repositories.Concrete;

namespace PersonnelApp.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private PersonnelContext _context;
        public UnitOfWork(PersonnelContext context)
        {
            _context = context;
            DepartmentRepository = new DepartmentRepository(_context);
            PersonnelRepository = new PersonnelRepository(_context);
        }
        public IDepartmentRepository DepartmentRepository { get; private set; }

        public IPersonnelRepository PersonnelRepository { get; private set; }

        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
