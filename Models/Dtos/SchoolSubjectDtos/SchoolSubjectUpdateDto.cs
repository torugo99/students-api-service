#nullable disable warnings
namespace studentsAPI.Models.Dtos.SchoolSubjectDtos
{
    public class SchoolSubjectUpdateDto
    {
        public string name { get; set; }
        public Guid teacher_id { get; set; }
        public DateTime updated_at { get; set; }
        public bool is_active { get; set; }
    }
}