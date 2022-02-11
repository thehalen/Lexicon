using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LexiconA11.Models;

namespace LexiconA11.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PersonModel> People { get; set; }

        protected override void OnModelCreating(ModelBuilder entityModelBuilder)
        {
            entityModelBuilder.Seed();
        }
    }
}
