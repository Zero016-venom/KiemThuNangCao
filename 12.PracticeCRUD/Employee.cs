﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PracticeCRUD
{
	public class Employee
	{

		public Employee(int id, string? firstName, string? lastName, string? email)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
		}

		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set;}
		public string? Email { get; set; }
	}
}
