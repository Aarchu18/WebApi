using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class StudentTransactionDataModel
    {
        public static List<StudentTransactionListModel> GetStudentTrsactionDetail()
        {
            return new List<StudentTransactionListModel>
            {
                new StudentTransactionListModel
                {
                    StudentId=1,
                    StudentFees=4000,
                    TrasactionDate="02/03/2013"
                },
                new StudentTransactionListModel
                {
                    StudentId=2,
                    StudentFees=5000,
                    TrasactionDate="04/03/2013"
                },
                new StudentTransactionListModel
                {
                    StudentId =3,
                    StudentFees=1000,
                    TrasactionDate="02/03/2014"
                },
                new StudentTransactionListModel
                {
                    StudentId=4,
                    StudentFees=4000,
                    TrasactionDate="10/03/2018"
                },
                new StudentTransactionListModel
                {
                    StudentId=5,
                    StudentFees=7000,
                    TrasactionDate="02/09/2009"
                },
                new StudentTransactionListModel
                {
                    StudentId=6,
                    StudentFees=10000,
                    TrasactionDate="02/03/2014"
                },
                new StudentTransactionListModel
                {
                    StudentId=7,
                    StudentFees=7000,
                    TrasactionDate="02/03/2002"
                },
                new StudentTransactionListModel
                {
                     StudentId=8,
                     StudentFees=9000,
                     TrasactionDate="02/03/2004"
                },
                new StudentTransactionListModel
                {
                     StudentId=9,
                     StudentFees=8000,
                     TrasactionDate="02/03/2005"
                },
                new StudentTransactionListModel
                {
                     StudentId=10,
                     StudentFees=2600,
                     TrasactionDate="02/03/2017"
                },
            };

        }

    }
}
