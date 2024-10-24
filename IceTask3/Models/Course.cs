using System.ComponentModel.DataAnnotations;

namespace IceTask3.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CoueseName { get; set; }
        public int CourseCredits {  get; set; }
    }
}
