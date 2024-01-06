using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VuNgocTuyen715.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public string StudentFullName { get; set; }
        public int Age { get; set; }
    }
}