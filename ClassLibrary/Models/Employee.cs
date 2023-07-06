namespace ClassLibrary.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string EmailId { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool Status { get; set; }
    }
}

