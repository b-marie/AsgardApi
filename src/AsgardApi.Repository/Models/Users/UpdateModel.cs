﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AsgardApi.Repository.Models
{
    public class UpdateModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
