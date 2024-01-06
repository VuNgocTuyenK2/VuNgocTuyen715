using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VuNgocTuyen715.Models
{
    
    public class Faculty
    {
        [Key]
        public string FacultyId { get; set; }
        public string FacultyName { get; set; }
        public String PhongBan { get; set; }
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }
    }
}