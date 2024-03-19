using System;

namespace EMS.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string projectTitle = "Employee Management System";
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(projectTitle);
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Type your choice and press enter.");
            Console.WriteLine("Choice 1: To add a new employee.");
            Console.WriteLine("Choice 2: To update an existing employee details.");
            Console.WriteLine("Choice 3: To display an existing employee details");
            Console.WriteLine("Choice 4: To export all employee details into a text file");
            Console.WriteLine("Choice 5: To delete an existing employee details.");

            Console.WriteLine();

        ReadChoice:
            Console.Write("Enter your choice and press enter: ");
            string choiceInputed = Console.ReadLine();

            switch (choiceInputed)
            {
                case "1":
                    Employee newEmployee = new Employee();
                    newEmployee.EmployeeCode = ReadTextInput("EmployeeCode");
                    newEmployee.FirstName = ReadTextInput("FirstName");
                    newEmployee.LastName = ReadTextInput("LastName");
                    newEmployee.Department = ReadTextInput("Department");
                    int result = newEmployee.Create();
                    if (result > 0)
                    {
                        Console.WriteLine("New employee added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong.Please contact system administrator");
                    }
                    break;
                case "2":
                    bool updateResult;
                    Employee updatedEmployee = new Employee();
                    updatedEmployee.EmployeeCode = ReadTextInput("EmployeeCode");
                    //Check whether employee exsists with entered EmployeeCode
                    updateResult = updatedEmployee.Exists();
                    if (updateResult)
                    {
                        updatedEmployee.FirstName = ReadTextInput("FirstName");
                        updatedEmployee.LastName = ReadTextInput("LastName");
                        updatedEmployee.Department = ReadTextInput("Department");
                        updateResult = updatedEmployee.Update();
                        if (updateResult)
                        {
                            Console.WriteLine("Employee details updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong.Please contact system administrator");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Employee does not exist with Employee Code = " + updatedEmployee.EmployeeCode);
                    }
                    break;
                case "3":
                    Employee emp = new();
                    emp.EmployeeCode = ReadTextInput("EmployeeCode");
                    if (emp.Exists())
                    {
                        emp.Get();
                        Console.WriteLine("Requested employee details below:");
                        Console.WriteLine("EmployeeCode: " + emp.EmployeeCode);
                        Console.WriteLine("FirstName: " + emp.FirstName);
                        Console.WriteLine("LastName: " + emp.LastName);
                        Console.WriteLine("Department: " + emp.Department);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Employee does not exist with Employee Code = " + emp.EmployeeCode);
                    }
                    break;
                case "4":
                    Console.WriteLine("Employee details are exported successfully.");
                    break;
                case "5":
                    Console.WriteLine("Employee details deleted successfully.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.WriteLine("Type y to re-enter your choice and any other key to exit and press enter.");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                goto ReadChoice;
            }
            else
            {
                Console.WriteLine("EMS program exited....");
                Environment.Exit(0);
            }
        }

        static string ReadTextInput(string fieldName)
        {
            string input = string.Empty;
            bool isValid;
            do
            {
                Console.Write("Enter " + fieldName + ": ");
                input = Console.ReadLine();
                isValid = !string.IsNullOrEmpty(input)
                    && !string.IsNullOrWhiteSpace(input)
                    && input.Trim() != "";
                if (!isValid)
                {
                    Console.WriteLine("Invalid " + fieldName + " should contain at least one alphanumeric character.");
                }
            } while (!isValid);

            return input;
        }
    }
}
