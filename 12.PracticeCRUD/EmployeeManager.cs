using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PracticeCRUD
{
	public class EmployeeManager
	{
		public List<Employee> _Lstemployees;

        public EmployeeManager()
        {
            _Lstemployees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _Lstemployees.Add(employee);
        }

        public void UpdateEmployee(int id, string newEmail)
        {
            var temp = _Lstemployees.FirstOrDefault(e=>e.Id == id); 

            if (temp != null)
            {
                temp.Email = newEmail;
            }

            //if (temp != null)
            //{
            //    temp.FirstName = employee.FirstName;
            //    temp.LastName = employee.LastName;
            //    temp.Email = employee.Email;
            //}
        }

        public void DeleteEmployee(int id)
        {
            _Lstemployees.RemoveAll(e => e.Id == id);
        }

        public Employee FindByID(int id)
        {
            var findID = _Lstemployees.FirstOrDefault(a => a.Id == id);
            return findID;
        }
    }
}
