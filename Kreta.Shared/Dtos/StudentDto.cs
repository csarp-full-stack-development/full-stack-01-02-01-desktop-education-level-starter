using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Dtos
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; } = string.Empty;
        public bool IsWoman { get; set; }
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public Guid EducationLevelId { get; set; } = Guid.Empty;
        public virtual EducationLevel? EducationLevel { get; set; }
    }
}
