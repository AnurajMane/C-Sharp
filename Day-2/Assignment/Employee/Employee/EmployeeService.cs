using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal
{
    internal class EmployeeService
    {
        List<Employee> emplList = [];

        public bool addEmployee(Employee emp)
        {
            emplList.Add(emp);
            return true;
        }

        public bool removeById(int id)
        {
            foreach (Employee emp in emplList)
            {
                if(emp.Id == id)
                {
                    emplList.Remove(emp);
                    return true;
                }
            }
            return false;
        }

        internal List<Employee> getAllEmployees()
        {
            return emplList;
        }

        internal Employee getById(int id)
        {
            foreach (Employee emp in emplList)
            {
                if(emp.Id == id)
                {
                    return emp;
                }
            }

            return null;
        }
    }
}
