using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.TeacherDtos
{
    public class TeacherDetailDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool is_active { get; set; }
    }
}