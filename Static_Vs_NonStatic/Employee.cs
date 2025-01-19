namespace Static_Vs_NonStatic
{
    public class Employee(int employeeId)
    {
        private int _employeeId = employeeId;

        // No need to give provide employeeID arguments as it can take the instance variable employeeID
        public int ComputeSalary()
        {
            int salary = 0;

            //do salary calculation based upon EmployeeId
            GetSalaryFromDB(_employeeId);
            return salary;
        }
        public int GetSalaryFromDB(int employeeID)
        {
            return 12345;
        }
    }

}
