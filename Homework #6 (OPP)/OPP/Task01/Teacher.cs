﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    using System;

    public class Teacher : Person, ITeacher
    {
        public string Subject { get; protected set; }

        public Teacher()
        {
        }

        public Teacher(string name, string family, int yearsExperience, string subject)
            : base(name, family, yearsExperience)
        {
            this.Subject = subject;
        }

        public void CheckHomework()
        {
            Console.WriteLine("Checking the homework!");
        }

        public string Greeting()
        {
            return "Good afternoon, students!";
        }

        public void Goodbay()
        {
            Console.WriteLine("Goodbay, students!");
        }
    }
}


