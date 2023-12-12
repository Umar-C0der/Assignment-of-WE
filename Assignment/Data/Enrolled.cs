using System.ComponentModel.DataAnnotations;

namespace Assignment.Data
{
    public class Enrolled
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int Cid { get; set; }
        public int Sid { get; set; }

        // Navigation properties to represent the relationships
        public Class Class { get; set; }
        public Student Student { get; set; }
    }
}
