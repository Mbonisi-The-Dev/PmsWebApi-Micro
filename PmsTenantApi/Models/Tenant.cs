using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PmsTenantApi.Models;

namespace PmsTenantApi.Models
{
    public class Tenant
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public int CellphoneNumber { get; set; }
    }

    public class TenantContext : DbContext
    {
        public TenantContext(DbContextOptions<TenantContext> options) : base(options)
        {
        }

        public DbSet<Tenant> Tenant { get; set; }
    }
}
