using Microsoft.EntityFrameworkCore;
using Restoran.Api.DAL.Entities;
using Restoran.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DataAccessLayer.Contracts
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        DbSet<About> Abouts { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Discount> Discounts { get; set; }
        DbSet<Feature> Features { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<SocialMedia> SocialMedias { get; set; }
        DbSet<Testimonial> Testimonials { get; set; }
    }
}
