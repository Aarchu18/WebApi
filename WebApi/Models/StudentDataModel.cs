using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class StudentDataModel
    {
        public static List<StudentListModel> GetStudentDetail()
        {
            return new List<StudentListModel>
            {
                new StudentListModel
                {
                    StudentId=1,
                    StudentName="Archana",
                    StudentAge=6,
                    StudentClass=3
                },
                new StudentListModel
                {
                    StudentId=2,
                    StudentName="Abhi",
                    StudentAge=16,
                    StudentClass=3
                },
                new StudentListModel
                {StudentId=3,
                    StudentName="Ranjana",
                    StudentAge=23,
                    StudentClass=4
                },
                new StudentListModel
                {
                   StudentId=4,
                    StudentName="Suraj",
                    StudentAge=12,
                    StudentClass=6
                },
                new StudentListModel
                {
                   StudentId=5,
                    StudentName="Ram",
                    StudentAge=12,
                    StudentClass=9
                },
                new StudentListModel
                {
                   StudentId=6,
                    StudentName="Ramlal",
                    StudentAge=20,
                    StudentClass=16
                },
                new StudentListModel
                {
                   StudentId=7,
                    StudentName="Tanya",
                    StudentAge=20,
                    StudentClass=13
                },
                new StudentListModel
                {
                   StudentId=8,
                    StudentName="Ramya",
                    StudentAge=20,
                    StudentClass=7
                },
                new StudentListModel
                {
                   StudentId=9,
                    StudentName="Raghu",
                    StudentAge=20,
                    StudentClass=16
                },
                new StudentListModel
                {
                   StudentId=10,
                    StudentName="Neha",
                    StudentAge=20,
                    StudentClass=10
                }
            };

        }
    }
}
