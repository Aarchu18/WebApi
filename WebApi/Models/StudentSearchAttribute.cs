using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class StudentSearchAttribute
    {
        public string SearchByAttribute { get; set; }
        public string SearchText { get; set; }
        public string SortByAttribute { get; set; }
        public int MinRange { set; get; }
        public int MaxRange { set; get; }
    }
}
