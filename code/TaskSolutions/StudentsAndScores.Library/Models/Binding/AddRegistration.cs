﻿using StudentsAndScores.Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndScores.Library.Models.Binding
{
    public class AddRegistration
    {
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
