namespace EmployeePortal
{
    public class Entry
    {
        private EmployeeService empService = new EmployeeService();

        public static void Main(String[] args)
        {
            Entry entry = new Entry();

            int choice;

            do
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Get All Employee");
                Console.WriteLine("3. Get Employee By Id");
                Console.WriteLine("4. Remove Employee By Id");
                Console.WriteLine("0. Exit");


                choice = Convert.ToInt32(Console.ReadLine());

                entry.actsOnChoice(choice);
            }while (choice != 0);

        }

        private void actsOnChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter some details of Employee -- ");
                        Console.WriteLine("Enter Name : ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Department : ");
                        string dept = Console.ReadLine();

                        Console.WriteLine("Enter Salary : ");
                        int salary = Convert.ToInt32(Console.ReadLine());

                        Employee emp = new(name, dept, salary);

                        if (empService.addEmployee(emp))
                        {
                            Console.WriteLine("Employee Added SuccessFully...........!!");
                        }
                        else
                        {
                            Console.WriteLine("Something Went Wrong........!!\nTry Again Later.......!!");
                        }
                        Console.WriteLine("**********************************************************************************");
                    }
                    break;

                case 2:
                    {
                        List<Employee> emps =   empService.getAllEmployees();

                        foreach( Employee emp in emps )
                        {
                            Console.WriteLine(emp.toString());
                            Console.WriteLine("----------------------------------------------------------");
                        }

                        Console.WriteLine("**********************************************************************************");
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Enter Id to see Employee : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Employee emp = empService.getById(id);

                        if( emp == null )
                        {
                            Console.WriteLine("No Employee is Registered with Id " + id);
                        }
                        else
                        {
                            Console.WriteLine("Details if Employee with Id " + id);
                            Console.WriteLine(emp.toString());
                        }
                        Console.WriteLine("**********************************************************************************");
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Enter Id to Remove Employee : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Boolean isDeleted = empService.removeById(id);

                        if (isDeleted)
                        {
                            Console.WriteLine("Successfully Deleted Employee with Id " + id);
                        }
                        else
                        {
                            Console.WriteLine("No Employee is Registered with Id " + id);
                        }
                        Console.WriteLine("**********************************************************************************");
                    }
                    break;

                case 0:
                    {
                        Console.WriteLine("Thank you for using platform......\nSee you again.........!!!!");
                    }
                    break;

                default: Console.WriteLine("You have Entered wrong choice.......Try again and put a choice--"); break;
            }
        }
    }
}