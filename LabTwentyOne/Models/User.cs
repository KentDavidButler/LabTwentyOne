﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabTwentyOne.Models
{
    public class User
    {
        public string Pronoun { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}