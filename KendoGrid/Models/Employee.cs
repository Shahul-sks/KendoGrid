using System.ComponentModel.DataAnnotations;

namespace KendoGrid.Models
{
    public class Employee
    {
        [Key]
        public int empid { get; set; }
        public string empname { get; set; }
        public int empsalary { get; set; }
        public string empaddress {  get; set; }
    }
}
