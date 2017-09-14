namespace InnovationApp.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }

        public virtual DbSet<FeatureOption> FeatureOptions { get; set; }
        public virtual DbSet<FeatureOptionType> FeatureOptionTypes { get; set; }
        public virtual DbSet<MasterFeature> MasterFeatures { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }
        public virtual DbSet<TemplateDetail> TemplateDetails { get; set; }
        public virtual DbSet<TemplateFeature> TemplateFeatures { get; set; }
        public virtual DbSet<TemplateMaster> TemplateMasters { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleMaster>()
                .HasMany(e => e.UserRoles)
                .WithRequired(e => e.RoleMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TemplateMaster>()
                .HasMany(e => e.TemplateDetails)
                .WithRequired(e => e.TemplateMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TemplateMaster>()
                .HasMany(e => e.TemplateFeatures)
                .WithRequired(e => e.TemplateMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TemplateMasters)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserRoles)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
