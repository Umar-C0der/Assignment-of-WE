using System.ComponentModel.DataAnnotations;

namespace Assignment.Data
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Major { get; set; }
        public string Standing { get; set; }

        public List<Enrolled> Enrollments { get; set; } = new List<Enrolled>();
    }
}
