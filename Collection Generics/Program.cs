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

            Stack<Employee> EmpStack = new Stack<Employee>();

            EmpStack.Push(em1);
            EmpStack.Push(em2);
            EmpStack.Push(em3);
            EmpStack.Push(em4);
            EmpStack.Push(em5);

            
            foreach (Employee emp in EmpStack)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", emp.ID, emp.Name, emp.Salary, emp.Gender);
                Console.WriteLine("Item in stack = " + EmpStack.Count);
                
            }


           
                
        }   
    }
}