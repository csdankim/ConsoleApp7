using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp7.Utility;
using ConsoleApp7.Data.Models;
using ConsoleApp7.Data.Repositories;

namespace ConsoleApp7.UI
{
    class ManageDeparment
    {
        IRepository<Department> departmentRepository;    // upcasting
        public ManageDeparment()
        {
            departmentRepository = new DepartmentRepository();
        }
        void PrintAllDepartment()
        {
            List<Department> deptCollection = departmentRepository.GetAll();
            int length = deptCollection.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(deptCollection[i].Id + "\t" + deptCollection[i].DepartmentName + "\t"
+ deptCollection[i].Location);
            }
        }
        void DeleteDepartment()
        {
            Console.Write("Enter Id => ");
            int id = Convert.ToInt32(Console.ReadLine());
            departmentRepository.Delete(id);
            Console.WriteLine("Department deleted successuflly");
        }
        void UpdateDepartment()
        {
            Department department = new Department();
            Console.Write("Enter Id => ");
            department.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name => ");
            department.DepartmentName = Console.ReadLine();

            Console.Write("Enter Location => ");
            department.Location = Console.ReadLine();

            departmentRepository.Update(department);
            Console.WriteLine("Department updated successuflly");
        }
        void InsertDepartment()
        {
            try
            {
                Department department = new Department();
                Console.Write("Enter Id => ");
                department.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name => ");
                department.DepartmentName = Console.ReadLine();

                Console.Write("Enter Location => ");
                department.Location = Console.ReadLine();

                departmentRepository.Insert(department);
                Console.WriteLine("Department added successfully");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch(StackOverflowException oe)
            {
                Console.WriteLine("Value must be in between 1 to " + int.MaxValue);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some errors have been occured. Contact the admin department");
            }
        }

        public void Run()
        {
            int choice = 0;

            do
            {
                Menu m = new Menu();
                choice = m.Print();
                switch (choice)
                {
                    case (int)MenuOptions.Insert:
                        InsertDepartment();
                        break;
                    case (int)MenuOptions.Delete:
                        DeleteDepartment();
                        break;
                    case (int)MenuOptions.Print:
                        PrintAllDepartment();
                        break;
                    case (int)MenuOptions.Update:
                        UpdateDepartment();
                        break;
                    case (int)MenuOptions.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit Again!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
                Console.Clear();
            } while (choice != (int)MenuOptions.Exit);
        }
    }
}
