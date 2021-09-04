using System.ComponentModel.DataAnnotations;

namespace EmployeeInfoAPI.Model
{
    public class EmployeeInfo
    {
        [Key]
        public string ID { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string Location { get; set; }
        public string YearsOfExperience { get; set; }
    }
}