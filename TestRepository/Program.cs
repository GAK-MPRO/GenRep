using GenericRepositoryUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepository
{
    /// <summary>
    /// Program to use a stub to showcase calling of generic methods
    /// Lets check staging
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //two ways in which , we will show the use of generic repository
            //#1 : Use Generic Repository to perform CRUD operations on Employee
            //#2 : In case you have a specific operation, not covered by methods in generic repisotory, you can use a specific repository inheriting 

            //specific method of the department repository
            DepartmentRepository depRep = new DepartmentRepository();
            depRep.SetDepartmentByEmployeeID(10);

            //other methods from generic repository
            depRep.Add(new Department());

            //shows how to use generic repository
            GenericRepository<Employee> gRecEmployee = new GenericRepository<Employee>();
            gRecEmployee.Add(new Employee());


        }


    }
}
