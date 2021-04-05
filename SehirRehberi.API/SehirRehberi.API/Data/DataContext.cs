﻿using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Data
{


    // Modeldeki sınıfı veritabanındaki tabloya yansıtma
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Value> Values { get; set; }
    }
}
