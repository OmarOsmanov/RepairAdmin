using jkhkhkuhuh.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Data
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext (DbContextOptions options) : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Blogimage> Blogimages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DisCount> DisCounts { get; set; }
        public DbSet<Feddback> Feddbacks { get; set; }
        public DbSet<Future> Futures { get; set; }
        public DbSet<GetAFreeEstimate> GetAFreeEstimates { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Sosial> Sosials { get; set; }
        public DbSet<Sponsered> Sponsereds { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }
        //public DbSet<CustomUser> Users { get; set; }
        public DbSet<UserCostumer> UserCostumers { get; set; }
        
    }
}
