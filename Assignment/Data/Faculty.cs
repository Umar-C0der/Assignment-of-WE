using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Assignment.Data
{
    public class Faculty
    {
        [Key]
        public int Fid { get; set; }
        public string Fname { get; set; }
        public string Deptid { get; set; }
        public string Standing { get; set; }

        public List<Class> Classes { get; set; } = new List<Class>();
    }
}
