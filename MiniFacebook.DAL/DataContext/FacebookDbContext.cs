using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniFacebook.Models.Entities;

namespace MiniFacebook.DAL.DataContext
{
    public partial class FacebookDbContext : DbContext
    {
        public FacebookDbContext(DbContextOptions<FacebookDbContext> options) : base(options)
        {
        }
        public virtual DbSet<UserFriend> UserFriends { get; set; }
        public virtual DbSet<PostPrivacy> PostPrivacy { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFriend>()
                        .HasKey(st => new { st.UserId, st.FriendId });

            modelBuilder.Entity<UserFriend>()
                .HasOne(st => st.User)
                .WithMany(s => s.UserFriends)
                .HasForeignKey(bc => bc.UserId);

            modelBuilder.Entity<UserFriend>()
                .HasOne(t => t.Friend)
                .WithMany(s => s.UserFriends1)
                .HasForeignKey(st => st.FriendId);
        }

    }
}
