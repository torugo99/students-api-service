using studentsAPI.Models.Dtos.TeacherDtos;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.SchoolSubjectDtos
{
    public class SchoolSubjectDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string teacher_name { get; set; }
        public bool is_active { get; set; }
    }
}