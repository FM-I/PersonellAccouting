using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenrsDB
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StudentContext context = new StudentContext())
            {
                #region CreateStudet
                //List<Group> groups = new List<Group>()
                //{
                //    new Group(){ Name = @"РП-9\11-31"},
                //    new Group(){ Name = @"СМВ-9\11-41"},
                //    new Group(){ Name = @"ПР-9\11-21"}
                //};

                //context.Groups.AddRange(groups);

                //Console.WriteLine("Group");

                //List<Specialty> specialties = new List<Specialty>()
                //{
                //    new Specialty() { Name = "Programmer" },
                //    new Specialty() { Name = "Teacher" },
                //    new Specialty() { Name = "Lawyer" }
                //};

                //context.Specialties.AddRange(specialties);

                //context.SaveChanges();
                //Console.WriteLine("Spec");


                //Student student = new Student()
                //{
                //    Name = "Petro",
                //    SecondName = "Sagaydachniy",
                //    Surname = "Kononovich",
                //    SpecialtyId = 1,
                //    GroupId = 1,
                //    YearEntry = 2018,
                //    Phone = "0453256123",
                //    Address = "Zaporizska Sich",
                //    ParentOneName = "Konon",
                //    ParentOneSecondName = "Sagaydachniy",
                //    ParentOneSurname = "Mikolayowich",
                //    ParentOnePhone = "0951245653",
                //    ParentTwoName = "Nataliya",
                //    ParentTwoSecondName = "Sagaydachna",
                //    ParentTwoSurname = "Petrivna",
                //    ParentTwoPhone = "0954145553"
                //};

                //context.Students.Add(student);

                //context.SaveChanges();
                #endregion

                #region ShowStudent

                //foreach (var student in context.Students.ToList())
                //{
                //    Console.WriteLine(student.Name);
                //    Console.WriteLine(student.SecondName);
                //    Console.WriteLine(student.Surname);
                //    Console.WriteLine(student.Phone);
                //    Console.WriteLine(student.Address);

                //    Console.WriteLine(student.ParentOneName);
                //    Console.WriteLine(student.ParentOneSecondName);
                //    Console.WriteLine(student.ParentOneSurname);
                //    Console.WriteLine(student.ParentOnePhone);

                //    Console.WriteLine(student.ParentTwoName);
                //    Console.WriteLine(student.ParentTwoSecondName);
                //    Console.WriteLine(student.ParentTwoSurname);
                //    Console.WriteLine(student.ParentTwoPhone);

                //    Console.WriteLine(student.Group.Name);
                //    Console.WriteLine(student.Specialty.Name);
                //}

                #endregion
            }
            //Console.ReadLine();
        }
    }
}
