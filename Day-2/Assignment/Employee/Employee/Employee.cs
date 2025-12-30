using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private string _dept;
        private float _salary;

        public int Id { 
            get { 
                return _id; 
            }
            set {
                _id = value; 
            } 
        }

        private static int IdCount = 0;

        public Employee(string name, string dept, float salary)
        {
            this._id = ++IdCount;
            this._name = name;
            this._dept = dept;
            this._salary = salary;
        }

        public string toString()
        {
            return "[Current Employee details--\nID : " + _id + " Name : " + _name + " Department : " + _dept + " Salary : " + _salary + "]";
        }
    }
}
