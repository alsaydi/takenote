using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
namespace TakeNote.Model
{
    public class TakeNoteContext : DbContext
    {
        public TakeNoteContext()
            : base("name=TakeNote")
        {
            
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<SourceType> SourceTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //an alternative to using attributes
            modelBuilder.Configurations.Add<Post>(new PostConfiguration());
            modelBuilder.Configurations.Add<User>(new UserConfiguration());
        }
    }
    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            
            Property(p => p.PostTitle).HasMaxLength(500);
            Property(p => p.DateAdded).IsOptional ();
            Property(p => p.DateModified).IsOptional();
            Property(p => p.DateDeleted).IsOptional();
            Property(p => p.DatePublished).IsOptional();
            Property(p => p.IsPublic).IsOptional();
            
            /* an author has zero to many posts. The foreign key field is authorId */
            this.HasOptional<User>(p => p.Author).WithMany(u => u.Posts).HasForeignKey<int?>(auth => auth.AuthorId);            
            this.HasOptional<User>(p => p.LastModifier).WithMany().HasForeignKey<int?>(mod => mod.LastModifierId);

            /* self-referencing relationship */
            this.HasOptional<Post>(p => p.ParentPost).WithMany().HasForeignKey<int?>(post => post.ParentPostId);
        }
    }
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.Property(u => u.Username).HasMaxLength(50).IsRequired();
        }
    }
}
