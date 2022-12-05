using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rutra_Thavamani_Selvi.Models
{
    public class Education
    {
        //public string Schoolname { get; internal set; }
        public string Collegename { get;  set; }
        public string Location { get;  set; }
        public int Year { get;  set; }
        public string Specialization
        {
            get; set;
        }
        public double Aggregate { get;  set; }
    }
   
}