using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationLibrary.Models
{
    public class JobApplication
    {
        public Applicant Applicant { get; set; } = null;
        public int YearsOfExperience { get; set; }
        public List<string> TechStack { get; set; }

        public JobApplication() => TechStack = new List<string>();
     


    }
}
