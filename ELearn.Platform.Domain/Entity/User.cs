﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Platform.Data.Entity
{
    public class User
    {
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public Guid Id { get; set; }
        public string? LastName { get; set; }
    }
}