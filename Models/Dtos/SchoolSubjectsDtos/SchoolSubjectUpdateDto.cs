#nullable disable warnings
namespace studentsAPI.Models.Dtos.SchoolSubjectsDtos
{
    public class SchoolSubjectUpdateDto
    {
        public string Name { get; set; }
        public Guid Teacher { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}