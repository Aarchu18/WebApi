using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public StudentViewList Get()
        {
            List<StudentListModel> studentListModel = StudentDataModel.GetStudentDetail();
            List<StudentTransactionListModel> studentTrasactionListModel = StudentTransactionDataModel.GetStudentTrsactionDetail();
            List<StudentResult> studentResult = (from studentList in studentListModel
                                                 join studentTrasactionList in studentTrasactionListModel
                                                 on studentList.StudentId equals studentTrasactionList.StudentId
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
            studentViewList.StudentListData = studentResult;
            return studentViewList;
        }

       

        // POST api/values
        [HttpPost]
        public List<StudentResult> Post([FromBody] StudentSearchAttribute studentSearchAttribute)
        {
            Result resultObj = new Result();
            List<StudentResult> studentListData = resultObj.GetResults(studentSearchAttribute);
            return studentListData;
        }
    }
}
