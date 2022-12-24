namespace HomeWork_LinoyDangur.Server.Pages


        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_LinoyDangur.Shared.Models.Courses
{
    public class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public double Credits { get; set; }
        public bool Exam { get; set; }

    }
    }
}
