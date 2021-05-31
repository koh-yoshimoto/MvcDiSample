using System.Linq;
using MvcSample.Queries.Dtos;

namespace MvcSample.Queries
{
    public interface IGetDepartmentQuery
    {
        DepartmentDto Execute();
    }

    public class GetDepartmentQuery : IGetDepartmentQuery
    {
        public DepartmentDto Execute()
        {
            var repos = ServiceLocator.GetDepartmentRepository();

            var e = repos.GetAll().First();

            return new DepartmentDto
            {
                Id = e.Id,
                Name = e.Name
            };

        }
    }
}