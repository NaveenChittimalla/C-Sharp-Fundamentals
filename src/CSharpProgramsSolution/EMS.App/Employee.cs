using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace EMS.App
{
    class Employee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string Department { get; set; }


        public bool Exists()
        {
            return EmployeeCode.StartsWith("EMS");
        }

        public int Create()
        {
            int result = 0;
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=EMS;Integrated Security=True";
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string query = "INSERT INTO Employee(EmployeeCode, FirstName, LastName, Department)" +
                    "values('" + EmployeeCode + "','" + FirstName + "','" + LastName + "','" + Department + "')";
                command.CommandText = query;
                command.CommandType = System.Data.CommandType.Text;

                result = command.ExecuteNonQuery();
                //To Do: Read the employee with Id from database
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            // To Do: Insert new employee into database
            return result;
        }

        public Employee Get()
        {
            Employee employee = new();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=EMS;Integrated Security=True";
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT EmployeeCode, FirstName, LastName, Department FROM Employee";
                command.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeCode = reader.GetString(0);
                    FirstName = reader.GetString(1);
                    LastName = reader.GetString(2);
                    Department = reader.GetString("Department");
                }
                //To Do: Read the employee with Id from database
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return employee;
        }

        public List<Employee> GetAll()
        {
            List<Employee> employeeList = new();

            //To Do: Read all the employees from database

            return employeeList;
        }

        public bool Update()
        {
            // To Do: update the details of existing employee with Id
            return true;
        }

        public void Delete(int id)
        {
            // To Do: delete the existing employee with Id
        }
    }
}
