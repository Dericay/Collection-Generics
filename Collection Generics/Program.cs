using System.Collections.Immutable;

namespace Collection_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee()
            {
                ID = 111,
                Name = "Tobias",
                Salary = 25000,
                Gender = "Male",
            };

            Employee em2 = new Employee()
            {
                ID = 112,
                Name = "Anas",
                Salary = 24000,
                Gender = "Male",
            };
            Employee em3 = new Employee()
            {
                ID = 113,
                Name = "Sara",
                Salary = 24000,
                Gender = "Female",
            };
            Employee em4 = new Employee()
            {
                ID = 114,
                Name = "Eva",
                Salary = 12000,
                Gender = "Female",
            };
            Employee em5 = new Employee()
            {
                ID = 115,
                Name = "Daniel",
                Salary = 20000,
                Gender = "Male",
            };

            //Stack
            
            Stack<Employee> EmpStack = new Stack<Employee>();

            EmpStack.Push(em1);
            EmpStack.Push(em2);
            EmpStack.Push(em3);
            EmpStack.Push(em4);
            EmpStack.Push(em5);

            
            foreach (Employee employee in EmpStack) //Prints stack in order
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", employee.ID, employee.Name, employee.Salary, employee.Gender);
                Console.WriteLine("Item in stack = " + EmpStack.Count);

            }

            Console.WriteLine("--------------------------------------------------------------------------");

            while (EmpStack.Count > 0)
            {
                Employee employee = EmpStack.Pop();  //Pop method to reduce the stack count
                Console.WriteLine("{0} - {1} - {2} - {3}", employee.ID, employee.Name, employee.Salary, employee.Gender);
                Console.WriteLine("Item in stack = " + EmpStack.Count);

            }

            Console.WriteLine("---------------------------------------------------------------------------");

            EmpStack.Push(em1);
            EmpStack.Push(em2);
            EmpStack.Push(em3);
            EmpStack.Push(em4);
            EmpStack.Push(em5);

            Employee emp = EmpStack.Peek();
            Console.WriteLine("{0} - {1} - {2} - {3}", emp.ID, emp.Name, emp.Salary, emp.Gender);
            Console.WriteLine("Item in stack = " + EmpStack.Count);
            Console.WriteLine("{0} - {1} - {2} - {3}", emp.ID, emp.Name, emp.Salary, emp.Gender);
            Console.WriteLine("Item in stack = " + EmpStack.Count);



            if (EmpStack.Contains(em1))   //Checks if stack contains "em1"
            {
                Console.WriteLine("em1 is in stack");
            }


            Console.WriteLine("-----------------------------------------------------------------------------");

            //List

            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(em1);
            EmpList.Add(em2);
            EmpList.Add(em3);
            EmpList.Add(em4);
            EmpList.Add(em5);

            if(EmpList.Contains(em1)) //Checks list if object exists
            {
                Console.WriteLine("Object em1 exist in the list");
            }
            else
            {
                Console.WriteLine("Object em1 does not exist in list");
            }

            Console.WriteLine();

            
            Employee result = EmpList.Find(e => e.Gender.Contains("Male"));         //Finds first person with "male"
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", result.ID, result.Name, result.Gender, result.Salary);
            Console.WriteLine();

            List<Employee> EmpMale = EmpList.FindAll(s => s.Gender.Contains("Male")); //Finds All people with "Male"

            foreach(Employee item in EmpMale)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", item.ID, item.Name, item.Gender, item.Salary);
            }

        }
    }
}