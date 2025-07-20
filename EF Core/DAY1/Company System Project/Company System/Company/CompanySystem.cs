using Company_System.Employees;
using Company_System.Departments;
using Company_System.Projects;
using Company_System.EmployeeProjects;


namespace Company_System.Company
{
    public class CompanySystem
    {
        Employee[] Employees;
        Department[] departments;
        Project[] projects;
        EmployeeProjectAssignment[] Assignment;

        int EmpCount = 0, depCount = 0, projCount = 0, assigCount = 0;

        public CompanySystem(int depSize = 10, int EmpSize = 10, int proSize = 10, int assignmentSize = 100)
        {

            Employees = new Employee[EmpSize];
            departments = new Department[depSize];
            projects = new Project[proSize];
            Assignment = new EmployeeProjectAssignment[assignmentSize];
        }

        public Department FindDep(int depId)
        {
            for (int i = 0; i < depCount; i++)
            {
                if (departments[i].DepId == depId)
                    return departments[i];
            }
            throw new Exception("Department not found.");
        }

        public void AddEmployee(EmployeeType type)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write($"Enter {type} Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Department ID to assign: ");
            int depId = int.Parse(Console.ReadLine());
            Department dep = FindDep(depId);

            Employee e;
            if (type == EmployeeType.Developer)
                e = new Developer(id, name, type, dep);
            else
                e = new Tester(id, name, type, dep);

            Employees[EmpCount] = e;
            EmpCount++;
            Console.WriteLine("Developer Added.\n");
        }

        public void AddDepartment()
        {
            Console.Write("Enter Department ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Department Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Location: ");
            string loc = Console.ReadLine();

            departments[depCount] = new Department(id, name, loc);
            depCount++;
            Console.WriteLine("Department Added.\n");
        }

        public void AddProject()
        {
            Console.Write("Enter Project ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Project Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Description: ");
            string desc = Console.ReadLine();
            Console.Write("Enter End Date (yyyy-mm-dd): ");
            DateTime end = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Department ID: ");
            int depId = int.Parse(Console.ReadLine());
            Department dep = FindDep(depId);

            projects[projCount] = new Project(id, name, desc, end, dep);
            projCount++;
            Console.WriteLine("Project Added.\n");
        }

        public void AssignProjectToDeveloper()
        {
            Console.Write("Enter Employee ID: ");
            int empId = int.Parse(Console.ReadLine());

            Employee e = null;
            for (int i = 0; i < EmpCount; i++)
            {
                if (Employees[i].EmpId == empId)
                {
                    e = Employees[i];
                    break;
                }
            }
            if (e == null)
            {
                Console.WriteLine("Developer not found.");
                return;
            }

            Console.Write("Enter Project ID to assign: ");
            int projId = int.Parse(Console.ReadLine());

            Project proj = null;
            for (int i = 0; i < projCount; i++)
            {
                if (projects[i].ProjectId == projId)
                {
                    proj = projects[i];
                    break;
                }
            }
            if (proj == null)
            {
                Console.WriteLine("Project not found.");
                return;
            }
            //check uniqueness
            for (int i = 0; i < assigCount; i++)
            {
                if (Assignment[i].EmployeeId == empId && Assignment[i].ProjectId == projId)
                { Console.WriteLine("Already Assigned before"); return; }
            }

            Console.Write("Enter estimated hours for this assignment: ");
            double hours = double.Parse(Console.ReadLine());

            Assignment[assigCount] = new EmployeeProjectAssignment
            {
                EmployeeId = empId,
                ProjectId = projId,
                Hours = hours,
                AssignmentDate = DateTime.Now
            };
            assigCount++;

        }

        public void ViewAllEmployees()
        {
            if (EmpCount == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            for (int i = 0; i < EmpCount; i++)
            {
                Employees[i].DisplayInfo();

                Console.WriteLine("Assigned Projects:");
                bool hasProjects = false;

                for (int j = 0; j < assigCount; j++)
                {
                    if (Assignment[j].EmployeeId == Employees[i].EmpId)
                    {
                        Project pro = null;
                        for (int k = 0; k < projCount; k++)
                        {
                            if (projects[k].ProjectId == Assignment[j].ProjectId) { pro = projects[k]; break; }
                        }
                        if (pro != null)
                        {
                            Console.WriteLine($"- {pro.ProjectName} ({Assignment[j].Hours} hours)");
                            hasProjects = true;
                        }
                    }
                }

                if (!hasProjects)
                {
                    Console.WriteLine("No projects assigned");
                }
            }
        }

        public void ViewAllDepartments()
        {
            for (int i = 0; i < depCount; i++)
                departments[i].Display();
        }

        public void ViewAllProjects()
        {
            if (projCount == 0)
            {
                Console.WriteLine("No Projects found.");
                return;
            }

            for (int i = 0; i < projCount; i++)
            {
                projects[i].Display();

                Console.WriteLine("Assigned Employees:");
                bool hasEmployees = false;

                for (int j = 0; j < assigCount; j++)
                {
                    if (Assignment[j].ProjectId == projects[i].ProjectId)
                    {
                        Employee Emp = null;
                        for (int k = 0; k < EmpCount; k++)
                        {
                            if (Employees[k].EmpId == Assignment[j].EmployeeId) { Emp = Employees[k]; break; }
                        }
                        if (Emp != null)
                        {
                            Console.WriteLine($"- {Emp.EmpName} ({Assignment[j].Hours} hours)");
                            hasEmployees = true;
                        }
                    }
                }

                if (!hasEmployees)
                {
                    Console.WriteLine("No Employees Assigned");
                }
            }
        }
    }
}
