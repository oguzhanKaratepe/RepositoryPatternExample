using PersonelApp.Domains;
using PersonnelApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Console.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            
            unitOfWork.PersonnelRepository.Add(new Personnel() { Name = "ahmet", LastName = "kara" });
            unitOfWork.DepartmentRepository.Add(new Department() { Name = "Computer Sceience", CreateDate=DateTime.Now});

            unitOfWork.Complete();
            unitOfWork.Dispose();
        }
    }
}
