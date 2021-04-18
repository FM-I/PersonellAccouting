using System.ComponentModel.DataAnnotations;

namespace StudenrsDB
{
    public class Student
    {
        //Студент
        public int? Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength(15)]
        public string SecondName { get; set; }
        [MaxLength(15)]
        public string Surname { get; set; }
        [MaxLength(12)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        public int YearEntry { get; set; }
        //Батьки
        [MaxLength(15)]
        public string ParentOneName { get; set; }
        [MaxLength(15)]
        public string ParentOneSecondName { get; set; }
        [MaxLength(15)]
        public string ParentOneSurname { get; set; }
        [MaxLength(12)]
        public string ParentOnePhone { get; set; }

        [MaxLength(15)]
        public string ParentTwoName { get; set; }
        public string ParentTwoSecondName { get; set; }
        [MaxLength(15)]
        public string ParentTwoSurname { get; set; }
        [MaxLength(12)]
        public string ParentTwoPhone { get; set; }
        //Спеціальність
        public int SpecialtyId { get; set; }
        public virtual Specialty Specialty { get; set; }
        //Група
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

    }
}
