using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAPI.Models
{
    public class ContactDetailContext : DbContext
    {
        public ContactDetailContext(DbContextOptions<ContactDetailContext> options) : base(options)
        {

        }

        public DbSet<ContactDetail> ContactDetails{ get; set;}
    }
}
