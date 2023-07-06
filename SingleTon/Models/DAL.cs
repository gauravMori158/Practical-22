namespace SingleTon.Models
{
    public class DAL
    {
        private static DAL _instance = null;
        private readonly EmployeeDbContext _contexr;
        private DAL()
        {

        }
        public static DAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL();

                return _instance;

            }
        }

        public void CreateEmployee(Employee employee)
        {
            using (var context = new EmployeeDbContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }
        public List<Employee> GetEmployees()
        {
            using (var context = new EmployeeDbContext())
            {
                var employees = context.Employees.Where(e=>e.Status == true).ToList();
                return employees;
            
            }
        }
        public  Employee GetEmployeeById(int id)
        {
            using (var context = new EmployeeDbContext())
            {
                return context.Employees.Where(e=>e.Status==true).FirstOrDefault(e=>e.Id == id);
            }
        }
        public void DeleteEmployee(int id)
        {
            using (var context = new EmployeeDbContext())
            {
                var employee = context.Employees.Find(id);
                employee.Status = false;
                //context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            using (var context = new EmployeeDbContext())
            {
                context.Employees.Update(employee);
                context.SaveChanges();

            }
        }

    }
}
