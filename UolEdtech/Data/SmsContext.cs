using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UolEdtech.Models;

namespace UolEdtech.Data
{
    public class SmsContext : DbContext
    {
        public SmsContext(DbContextOptions<SmsContext> opt) : base(opt)
        {

        }

        public DbSet<Sms> Smss { get; set; }
    }
}
