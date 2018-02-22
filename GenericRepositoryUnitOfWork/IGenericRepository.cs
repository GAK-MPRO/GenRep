using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryUnitOfWork
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }


    }


    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public Department EmployeeDepartment { get; set; }
    }
    //interface for Igeneric repository
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable GetAll();
        IEnumerable Find(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(object Id);
        void Add(TEntity entity);
        void AddRange(IEnumerable entities);
        void Update(TEntity entity);
        void Remove(object Id);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable entities);


    }

    //implement the generic repository interface
   // ** EfGenericRepository **
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        //create a protected dbcontext here
         public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(object Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable entities)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }

    //what if I still have a class that has requires additional methods than specified in GenericRepository
    //In that case, best approach is to inherit GenericRepository

   public class DepartmentRepository: GenericRepository<Department>, IGenericRepository<Department>
    {

       public bool SetDepartmentByEmployeeID(int EmployeeID)
        {
            
            //Entity Framework Here
            return true;
            
        }

    }
    


}

