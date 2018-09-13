using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class StudentTransactionListModel
    {
        public int StudentId { get; set; }

        public int StudentFees { get; set; }

        public string TrasactionDate { get; set; }

    }
}
