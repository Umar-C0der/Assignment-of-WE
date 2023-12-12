using System.ComponentModel.DataAnnotations;

namespace Assignment.Data
{
    public class Class
    {
        [Key]
        public int Cid { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public int Fid { get; set; }

        // Navigation properties to represent the relationships
        public Faculty Faculty { get; set; }
        public List<Enrolled> Enrollments { get; set; } = new List<Enrolled>();
    }
}
