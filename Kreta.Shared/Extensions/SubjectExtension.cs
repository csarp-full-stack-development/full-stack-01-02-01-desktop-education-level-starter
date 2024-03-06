using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class SubjectExtension
    {
        public static SubjectDto ToDto(this Subject subject)
        { 
            return new SubjectDto
            {
                Id = subject.Id,
                SubjectName = subject.SubjectName,
                CompulsoryExaminationSubject=subject.CompulsoryExaminationSubject,
                OptionalExaminationSubject = subject.OptionalExaminationSubject,

            };
        }

        public static Subject ToModel(this SubjectDto subjectDto)
        {
            return new Subject
            {
                Id = subjectDto.Id,
                SubjectName=subjectDto.SubjectName,
                CompulsoryExaminationSubject=subjectDto.CompulsoryExaminationSubject,
                OptionalExaminationSubject= subjectDto.OptionalExaminationSubject,
            };
        }
    }
}
