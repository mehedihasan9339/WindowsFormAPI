namespace WindowsFormAPI.Data.Employee
{
    public class EmployeeInfo:Base
    {
        public string empCode { get; set; }
        public string empName { get; set; }
        public string designation { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int? age { get; set; }
    }
}
