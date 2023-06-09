﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mijnDBContext
{
    public class MijnDatabaseContext : DbContext
    {
        public MijnDatabaseContext(DbContextOptions options) : base(options) { }
        public DbSet<Recept> recipes { get; set; }
        public DbSet<Ingredient> Ingredienten { get; set; }
        public DbSet<User> Users { get; set; }

 

    }
}
