﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi1.Models
{
    public class CountryContext:DbContext
    {
        public CountryContext() : base("name=Country")
        {

        }
        public DbSet<Country> country { get; set; }
    }
}
