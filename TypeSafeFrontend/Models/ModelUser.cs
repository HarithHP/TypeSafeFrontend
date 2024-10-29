﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSafeFrontend.Models
{
    internal class ModelUser
    {
        public int? Id { get; set; }
        public string? AuthToken { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ContactNumber { get; set; }
        public string? UserStatus { get; set; }

    }
}
