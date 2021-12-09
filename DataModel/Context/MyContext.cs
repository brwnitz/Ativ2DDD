using DataModel.Mapping;
using DomainModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Notices> Notices { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Dislike> Dislikes { get; set; }
        public DbSet<Commentary> Commentaries { get; set; }
        public DbSet<Chat> Chats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);

            modelBuilder.Entity<Post>(new PostMap().Configure);

            modelBuilder.Entity<Notices>(new NoticesMap().Configure);

            modelBuilder.Entity<Like>(new LikeMap().Configure);

            modelBuilder.Entity<Dislike>(new DislikeMap().Configure);

            modelBuilder.Entity<Commentary>(new CommentaryMap().Configure);

            modelBuilder.Entity<Chat>(new ChatMap().Configure);

        }
    }
}
