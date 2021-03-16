using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp7.Data.Models;

namespace ConsoleApp7.Data.Repositories
{
    class DepartmentRepository : IRepository<Department>
    {
        List<Department> lstDeparmentCollection = new List<Department>();
        public void Delete(int id)
        {
            Department d = GetById(id);
            if (d != null)
            {
                lstDeparmentCollection.Remove(d);
            }
        }

        public List<Department> GetAll()
        {
            return lstDeparmentCollection;
        }

        public Department GetById(int id)
        {
            int length = lstDeparmentCollection.Count;
            for (int i = 0; i < length; i++)
            {
                if (lstDeparmentCollection[i].Id == id)
                    return lstDeparmentCollection[i];
            }

            return null;
        }

        public void Insert(Department item)
        {
            lstDeparmentCollection.Add(item);
        }

        public void Update(Department item)
        {
            Department d = GetById(item.Id);
            if(d!=null)
            {
                d.DepartmentName = item.DepartmentName;
                d.Location = item.Location;
            }
        }
    }
}
