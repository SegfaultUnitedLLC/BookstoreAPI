using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BookstoreAPI.Data
{
    public class BooksForAllContext : DbContext
    {
        public BooksForAllContext(DbContextOptions<BooksForAllContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
