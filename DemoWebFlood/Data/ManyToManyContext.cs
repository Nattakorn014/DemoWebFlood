using DemoWebFlood.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWebFlood.Data
{
    public class ManyToManyContext:DbContext
    {
        public ManyToManyContext(DbContextOptions<ManyToManyContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<TypeFlood> TypeFloods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostType>().HasKey(pt => new { pt.PostId, pt.TypeFloodId });
            modelBuilder.Entity<PostType>().
                HasOne(pt => pt.Post).WithMany(pt => pt.PostsType).HasForeignKey(p => p.PostId);
            modelBuilder.Entity<PostType>().
                HasOne(pt => pt.TypeFlood).WithMany(pt => pt.PostTypesFlood).HasForeignKey(p => p.TypeFloodId);
        }
    }
}
