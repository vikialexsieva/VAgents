﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VAgents.Areas.Users.Models
{
    public class ListAllBusinessViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}