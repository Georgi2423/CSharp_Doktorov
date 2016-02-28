using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    using System;

    public class CollegeTeacher : Teacher, ITeacher
    {
        public string College { get; protected set; }

        public CollegeTeacher(string name, string family, int yearsExperience,
          string subject, string college)
            : base(name, family, yearsExperience, subject)
        {
            this.College = college;
        }

        public CollegeTeacher()
        {
        }
    }
}
