using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentProgress.Models
{
    public class Student
    {
        //ID студента
        public virtual int StudentId { get; set; }
        //Имя студента
        [DisplayName("Имя студента")]
        public virtual string FirstName { get; set; }
        //Фамилия студента
        [DisplayName("Фамилия студента")]
        public virtual string SecondName { get; set; }
        //Группа
        [DisplayName("Группа")]
        public virtual int GroupNumber { get; set; }
        //Курс
        [DisplayName("Курс")]
        public virtual int Course { get; set; }
        //Оценка
        [DisplayName("Оценка")]
        public virtual int Grade { get; set; }
    }
}