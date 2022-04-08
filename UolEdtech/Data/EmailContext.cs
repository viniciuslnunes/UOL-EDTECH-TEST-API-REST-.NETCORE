using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UolEdtech.Models;

namespace UolEdtech.Data
{
    public class EmailContext : DbContext
    {
        public EmailContext(DbContextOptions<EmailContext> opt) : base(opt)
        {

        }

        public DbSet<Email> Emails { get; set; }
    }
}

