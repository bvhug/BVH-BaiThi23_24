using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BVHBaiThi.Models;

    public class LTQDD : DbContext
    {
        public LTQDD (DbContextOptions<LTQDD> options)
            : base(options)
        {}

        public DbSet<BVHBaiThi.Models.Person> Person { get; set; } = default!;

public DbSet<BVHBaiThi.Models.Student> Student { get; set; } = default!;

public DbSet<BVHBaiThi.Models.Employee> Employee { get; set; } = default!;
    }
