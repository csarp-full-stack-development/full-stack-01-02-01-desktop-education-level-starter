using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Guid EducatuionLevelId1 = Guid.NewGuid();
            Guid EducatuionLevelId2 = Guid.NewGuid();
            List<EducationLevel> educationLevels = new()
            {
                new EducationLevel
                {
                    Id=EducatuionLevelId1,
                    StudentEducationLevel="érettségi",
                    DurationOfEducation=4,
                },
                new EducationLevel
                {
                    Id=EducatuionLevelId2,
                    StudentEducationLevel="szakképzés",
                    DurationOfEducation=2,
                }
            };

            List<Student> students = new()
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    IsWoman=false,
                    BirthDay=new DateTime(2022,10,10),
                    PlaceOfBirth="Szeged",
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevelId=EducatuionLevelId1,
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Nóra",
                    LastName="Nagy",
                    IsWoman=true,
                    BirthDay=new DateTime(2021,4,4),
                    PlaceOfBirth="Kiskunhalas",
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevelId=EducatuionLevelId2,
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Vas",
                    LastName="Valér",
                    IsWoman=false,
                    BirthDay=new DateTime(2022,7,7),
                    PlaceOfBirth="Makó",
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevelId=EducatuionLevelId1,
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Kis",
                    LastName="Márta",
                    PlaceOfBirth="Szabadka",
                    IsWoman=true,
                    BirthDay=new DateTime(2019,9,9),
                    SchoolYear=12,
                    SchoolClass = SchoolClassType.ClassC,
                    EducationLevelId=EducatuionLevelId1,
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Magas",
                    LastName="Milán",
                    IsWoman=false,
                    BirthDay=new DateTime(2017,7,7),
                    PlaceOfBirth="Apátfalva",
                    SchoolYear=13,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevelId=EducatuionLevelId2,
                }
            };
            List<Teacher> teachers = new()
            {
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Martin",
                    LastName="Magyar",
                    BirthDay=new DateTime(2000,10,10),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Miskolc",
                    IsWoman=false,
                    MathersName="Miskolci Mária"
                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Mirjam",
                    LastName="Metek",
                    BirthDay=new DateTime(2000,11,11),
                    IsHeadTeacher=true,
                    PlaceOfBirth="Eger",
                    IsWoman=true,
                    MathersName="Egri Etelka"

                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Feri",
                    LastName="Földrajz",
                    BirthDay=new DateTime(2000,12,12),
                    IsHeadTeacher=true,
                    PlaceOfBirth="Szabadka",
                    IsWoman=false,
                    MathersName="Szabadkai Szabina"

                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Éva",
                    LastName="Ének",
                    BirthDay=new DateTime(2000,1,1),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Baja",
                    IsWoman=true,
                    MathersName="Bajai Betti"
                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Adorján",
                    LastName="Angol",
                    BirthDay=new DateTime(2000,3,3),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Kecskemét",
                    IsWoman=false,
                    MathersName="Kecskeméti Kati"
                }
            };
            List<Parent> parents = new()
            {
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Virág",
                    LastName="Vas",
                    IsWoman=true,
                    BirthDay=new DateTime(1998,8,8),
                    PlaceOfBirth="Szeged",
                    MathersName="Érc Kitti",
                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Petra",
                    LastName="Pénzes",
                    IsWoman=true,
                    BirthDay=new DateTime(1997,7,7),
                    PlaceOfBirth="Kistelek",
                    MathersName="Szegény Szandi",

                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Ferenc",
                    LastName="Fukar",
                    IsWoman=false,
                    BirthDay=new DateTime(1995,5,5),
                    PlaceOfBirth="Szeged",
                    MathersName="Adakozó Andor",

                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Fruzsi",
                    LastName="Fukar",
                    IsWoman=true,
                    BirthDay=new DateTime(1994,4,4),
                    PlaceOfBirth="Makó",
                    MathersName="Adó Anna",

                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Hedvig",
                    LastName="Hosszú",
                    IsWoman=true,
                    BirthDay=new DateTime(1992,2,2),
                    PlaceOfBirth="Szeged",
                    MathersName="Alacsony Anikó",

                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Milán",
                    LastName="Magas",
                    IsWoman=false,
                    BirthDay=new DateTime(1992,2,2),
                    PlaceOfBirth="Deszk",
                    MathersName="Alacsony Anikó",

                }
            };

            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Teacher>().HasData(teachers);
            modelBuilder.Entity<Parent>().HasData(parents);
            modelBuilder.Entity<EducationLevel>().HasData(educationLevels);
        }
    }
}
