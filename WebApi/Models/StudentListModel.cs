using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class StudentListModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int StudentClass { get; set; }

        public int StudentAge { get; set; }
    }
}
