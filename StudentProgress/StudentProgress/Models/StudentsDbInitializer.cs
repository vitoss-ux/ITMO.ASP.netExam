using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentProgress.Models
{
    public class StudentsDbInitializer : DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            context.Students.Add(new Student { SecondName = "Иванов", FirstName = "Иван", GroupNumber = 12345, Course = 1, Grade = 3});
            context.Students.Add(new Student { SecondName = "Петров", FirstName = "Петр", GroupNumber = 12453,  Course = 1, Grade = 5});
            context.Students.Add(new Student { SecondName = "Сидоров", FirstName = "Артем", GroupNumber = 75473, Course = 4, Grade = 5});

            base.Seed(context);
        }
    }
}