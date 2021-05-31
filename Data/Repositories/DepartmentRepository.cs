using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MvcSample.Data.Entities;

namespace MvcSample.Data.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
    }

    public class DepartmentRepository : IDepartmentRepository
    {
        public IEnumerable<Department> GetAll()
        {
            var context = new SampleDbContext();
            return context.Departments.AsNoTracking().ToList();
        }
    }
}