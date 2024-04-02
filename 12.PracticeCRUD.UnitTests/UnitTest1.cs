namespace _12.PracticeCRUD.UnitTests
{
	public class Tests
	{
		public Employee _employee;
		public EmployeeManager _employeeManager;

		[SetUp]
		public void Setup()
		{
			_employeeManager = new EmployeeManager();
		}

		[Test]
		public void Test_AddEm()
		{
			_employee = new Employee(1, "Anh", "Hoang", "anhhvph31156@fpt.edu.vn");

			_employeeManager.AddEmployee(_employee);

			Assert.Contains(_employee, _employeeManager._Lstemployees);
		}

		[Test]
		public void Test_UpdateEm()
		{
			_employee = new Employee(1, "Anh", "Hoang", "anhhvph31156@fpt.edu.vn");

			_employeeManager.AddEmployee(_employee);
			//_employeeManager.UpdateEmployee(1, "venom@qa.team");
			//Assert.Contains(_employee, _employeeManager._Lstemployees);

			string newEmail = "venom@qa.team";
			_employeeManager.UpdateEmployee(1, newEmail);

			Assert.AreEqual(_employee.Email, newEmail);
		}

		[Test]
		public void Test_DeleteEm()
		{
			_employee = new Employee(1, "Anh", "Hoang", "anhhvph31156@fpt.edu.vn");
			_employeeManager.AddEmployee(_employee);

			_employeeManager.DeleteEmployee(1);

			Assert.IsFalse(_employeeManager._Lstemployees.Contains(_employee));
		}

		[Test]
		public void Test_FindByID()
		{
			_employee = new Employee(1, "Anh", "Hoang", "anhhvph31156@fpt.edu.vn");
			_employeeManager.AddEmployee(_employee);

			var temp = _employeeManager.FindByID(1);
			Assert.IsNotNull(temp);
		}


	}
}