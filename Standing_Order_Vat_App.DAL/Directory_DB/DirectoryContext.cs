using Microsoft.EntityFrameworkCore;
using Standing_Order_Vat_App.DAL.Sp_DirectoryDB;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class DirectoryContext : DbContext
    {
        public DirectoryContext()
        {
        }

        public DirectoryContext(DbContextOptions<DirectoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Applications { get; set; } = null!;
        public virtual DbSet<ApplicationDataFilter> ApplicationDataFilters { get; set; } = null!;
        public virtual DbSet<ApplicationModule> ApplicationModules { get; set; } = null!;
        public virtual DbSet<ApplicationRole> ApplicationRoles { get; set; } = null!;
        public virtual DbSet<ApplicationRoleModule> ApplicationRoleModules { get; set; } = null!;
        public virtual DbSet<ApplicationUserDataFilter> ApplicationUserDataFilters { get; set; } = null!;
        public virtual DbSet<ApplicationUserModule> ApplicationUserModules { get; set; } = null!;
        public virtual DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; } = null!;
        public virtual DbSet<ApplicationUserRoleModule> ApplicationUserRoleModules { get; set; } = null!;
        public virtual DbSet<Audit> Audits { get; set; } = null!;
        public virtual DbSet<DataFilter> DataFilters { get; set; } = null!;
        public virtual DbSet<Module> Modules { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserDataFilter> UserDataFilters { get; set; } = null!;
        public virtual DbSet<Sp_userRole> Sp_UserRoles { get; set; } = null!;

        public virtual DbSet<UserPermission> UserPermissions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SYS60\\SQLEXPRESS;Database=Directory;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Path)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uri)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("web address of the  application");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1.0.0')");
            });

            modelBuilder.Entity<ApplicationDataFilter>(entity =>
            {
                entity.HasKey(e => e.ApplicationFilterId);

                entity.HasIndex(e => new { e.ApplicationId, e.FilterId }, "IX_ApplicationDataFilters")
                    .IsUnique();

                entity.Property(e => e.ApplicationFilterId).HasColumnName("ApplicationFilterID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.FilterId).HasColumnName("FilterID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationDataFilters)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_ApplicationDataFilters_Applications");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.ApplicationDataFilters)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_ApplicationDataFilters_DataFilters");
            });

            modelBuilder.Entity<ApplicationModule>(entity =>
            {
                entity.HasIndex(e => new { e.ApplicationId, e.ModuleId }, "IX_ApplicationModules")
                    .IsUnique();

                entity.Property(e => e.ApplicationModuleId).HasColumnName("ApplicationModuleID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationModules)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_Modules_Applications");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.ApplicationModules)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_ApplicationModules_Modules");
            });

            modelBuilder.Entity<ApplicationRole>(entity =>
            {
                entity.HasIndex(e => new { e.ApplicationId, e.RoleId }, "IX_ApplicationRoles")
                    .IsUnique();

                entity.Property(e => e.ApplicationRoleId).HasColumnName("ApplicationRoleID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_ApplicationRoles_Applications");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ApplicationRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_ApplicationRoles_Roles");
            });

            modelBuilder.Entity<ApplicationRoleModule>(entity =>
            {
                entity.HasKey(e => e.RoleModuleId)
                    .HasName("PK_RoleDetails");

                entity.Property(e => e.RoleModuleId).HasColumnName("RoleModuleID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Permission)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')")
                    .IsFixedLength();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.ApplicationModule)
                    .WithMany(p => p.ApplicationRoleModules)
                    .HasPrincipalKey(p => new { p.ApplicationId, p.ModuleId })
                    .HasForeignKey(d => new { d.ApplicationId, d.ModuleId })
                    .HasConstraintName("FK_ApplicationRoleModules_ApplicationModules");

                entity.HasOne(d => d.ApplicationRole)
                    .WithMany(p => p.ApplicationRoleModules)
                    .HasPrincipalKey(p => new { p.ApplicationId, p.RoleId })
                    .HasForeignKey(d => new { d.ApplicationId, d.RoleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationRoleModules_ApplicationRoles");
            });

            modelBuilder.Entity<ApplicationUserDataFilter>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.UserId, e.FilterId }, "IX_ApplicationUserDataFilters")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.FilterId).HasColumnName("FilterID");

                entity.Property(e => e.Permission)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')")
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ApplicationDataFilter)
                    .WithMany(p => p.ApplicationUserDataFilters)
                    .HasPrincipalKey(p => new { p.ApplicationId, p.FilterId })
                    .HasForeignKey(d => new { d.ApplicationId, d.FilterId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationUserDataFilters_ApplicationDataFilters");

                entity.HasOne(d => d.ApplicationUserRole)
                    .WithMany(p => p.ApplicationUserDataFilters)
                    .HasPrincipalKey(p => new { p.ApplicationId, p.UserId })
                    .HasForeignKey(d => new { d.ApplicationId, d.UserId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationUserDataFilters_ApplicationUserRoles");
            });

            modelBuilder.Entity<ApplicationUserModule>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.UserId, e.ModuleId }, "IX_ApplicationUserModules")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Permission)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')")
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ApplicationModule)
                    .WithMany(p => p.ApplicationUserModules)
                    .HasPrincipalKey(p => new { p.ApplicationId, p.ModuleId })
                    .HasForeignKey(d => new { d.ApplicationId, d.ModuleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationUserModules_ApplicationModules");

                entity.HasOne(d => d.ApplicationUserRole)
                    .WithMany(p => p.ApplicationUserModules)
                    .HasPrincipalKey(p => new { p.ApplicationId, p.UserId })
                    .HasForeignKey(d => new { d.ApplicationId, d.UserId })
                    .HasConstraintName("FK_ApplicationUserModules_ApplicationUserRoles");
            });

            modelBuilder.Entity<ApplicationUserRole>(entity =>
            {
                entity.HasKey(e => e.UserApplicationId)
                    .HasName("PK_UserApplications");

                entity.HasIndex(e => new { e.ApplicationId, e.UserId }, "IX_ApplicationUserRoles")
                    .IsUnique();

                entity.Property(e => e.UserApplicationId).HasColumnName("UserApplicationID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApplicationUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserApplicationModes_Users");
            });

            modelBuilder.Entity<ApplicationUserRoleModule>(entity =>
            {
                entity.HasKey(e => e.UserRoleModuleId)
                    .HasName("PK_UserRoleModule");

                entity.Property(e => e.UserRoleModuleId).HasColumnName("UserRoleModuleID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ApplicationUserRoleModules)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationUserRoleModules_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApplicationUserRoleModules)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserApplicationModules_Users");

                entity.HasOne(d => d.ApplicationModule)
                    .WithMany(p => p.ApplicationUserRoleModules)
                    .HasPrincipalKey(p => new { p.ApplicationId, p.ModuleId })
                    .HasForeignKey(d => new { d.ApplicationId, d.ModuleId })
                    .HasConstraintName("FK_ApplicationUserRoleModules_ApplicationModules");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.ToTable("Audit");

                entity.Property(e => e.AuditId).HasColumnName("audit_id");

                entity.Property(e => e.AuditAction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_action");

                entity.Property(e => e.AuditApplication)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_application")
                    .HasDefaultValueSql("(app_name())");

                entity.Property(e => e.AuditField)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_field");

                entity.Property(e => e.AuditNewVal)
                    .HasMaxLength(3500)
                    .IsUnicode(false)
                    .HasColumnName("audit_new_val");

                entity.Property(e => e.AuditOldVal)
                    .HasMaxLength(3500)
                    .IsUnicode(false)
                    .HasColumnName("audit_old_val");

                entity.Property(e => e.AuditTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_table");

                entity.Property(e => e.AuditTableRow).HasColumnName("audit_table_row");

                entity.Property(e => e.AuditTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("audit_timestamp")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AuditUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.AuditWorkstation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_workstation")
                    .HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<DataFilter>(entity =>
            {
                entity.HasKey(e => e.FilterId);

                entity.Property(e => e.FilterId).HasColumnName("FilterID");

                entity.Property(e => e.FilterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoSyncDomain)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AccessCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Path)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDataFilter>(entity =>
            {
                entity.HasKey(e => e.UserFilterId);

                entity.HasIndex(e => new { e.UserId, e.FilterId }, "IX_UserDataFilters")
                    .IsUnique();

                entity.Property(e => e.UserFilterId).HasColumnName("UserFilterID");

                entity.Property(e => e.FilterId).HasColumnName("FilterID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.UserDataFilters)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_UserDataFilters_DataFilters1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDataFilters)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserDataFilters_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
