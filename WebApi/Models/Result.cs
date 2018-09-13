using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Result
    {
        public List<StudentResult> GetResults(StudentSearchAttribute searchAttributeData)
        {
            if (searchAttributeData.MaxRange == 0)
            {
                searchAttributeData.MaxRange = 999999999;
            }
            List<StudentListModel> studentListModel = StudentDataModel.GetStudentDetail();
            List<StudentTransactionListModel> studentTrasactionListModel = StudentTransactionDataModel.GetStudentTrsactionDetail();
            List<StudentResult> studentJoinList = (from studentList in studentListModel
                                                   join studentTrasactionList in studentTrasactionListModel on studentList.StudentId equals studentTrasactionList.StudentId
                                                   where isValidAttribute(studentList, searchAttributeData.SearchByAttribute, searchAttributeData.SearchText)
                                                   && (studentTrasactionList.StudentFees >= searchAttributeData.MinRange && studentTrasactionList.StudentFees <= searchAttributeData.MaxRange)
                                                   select new StudentResult
                                                   {
                                                       StudentId = studentList.StudentId,
                                                       StudentName = studentList.StudentName,
                                                       StudentClass = studentList.StudentClass,
                                                       StudentAge = studentList.StudentAge,
                                                       StudentFees = studentTrasactionList.StudentFees,
                                                       TrasactionDate = studentTrasactionList.TrasactionDate
                                                   }
                                                     ).ToList();
            StudentViewList studentViewList = new StudentViewList();
            studentViewList.StudentListData = Sort(studentJoinList, searchAttributeData.SortByAttribute);
            return studentViewList.StudentListData;
        }


        private bool isValidAttribute(StudentListModel studentList, string searchByAttribute, string searchText)
        {
            if (searchByAttribute == "StudentName")
            {
                if (studentList.StudentName == searchText)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (searchByAttribute == "StudentClass")
            {
                int number;
                if (!int.TryParse(searchText, out number))
                    return false;
                return studentList.StudentClass == Convert.ToInt32(searchText) ? true : false;
            }
            if (searchByAttribute == "StudentId")
            {
                int number;
                if (!int.TryParse(searchText, out number))
                    return false;

                if (studentList.StudentId == Convert.ToInt32(searchText))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
        private List<StudentResult> Sort(List<StudentResult> studentResult, string sortByAttribute)
        {
            if (sortByAttribute == "StudentId")
                studentResult = (from studentResultObject in studentResult
                                 orderby studentResultObject.StudentId
                                 select studentResultObject).ToList();

            if (sortByAttribute == "StudentName")
                studentResult = (from studentResultObject in studentResult
                                 orderby studentResultObject.StudentName
                                 select studentResultObject).ToList();
            if (sortByAttribute == "StudentClass")
                studentResult = (from studentResultObject in studentResult
                                 orderby studentResultObject.StudentClass
                                 select studentResultObject).ToList();

            return studentResult;
        }

    }
}
