using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Connect
{
    public class Teacher
    {
        public int id { get; set; }
        public string teacher_name { get; set; }
        public string teacher_surname { get; set; }
        public string teacher_subject { get; set; }
        public string teacher_gender { get; set; }
        public string teacher_mail { get; set; }

       public Teacher()
        {

        }
        public Teacher(int id, string teacher_name, string teacher_surname, string teacher_subject, string teacher_gender, string teacher_mail)
        {
            this.id = id;
            this.teacher_name = teacher_name;
            this.teacher_surname = teacher_surname;
            this.teacher_subject = teacher_subject;
            this.teacher_gender = teacher_gender;
            this.teacher_mail = teacher_mail;
        }
    }
}
