<<<<<<< HEAD
using HelpDeskWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
=======
﻿using HelpDeskWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
>>>>>>> respaldo-remoto-origin-main
namespace HelpDeskWeb.Data

{
    public class AppDbContext : IdentityDbContext<User>
<<<<<<< HEAD
    {
        public DbSet<TicketStatus> TicketStatus { get; set; }

        public DbSet<TicketPriority> TicketPriority { get; set; }

=======

    {
>>>>>>> respaldo-remoto-origin-main
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)

        {
<<<<<<< HEAD
            base.OnModelCreating(builder);

=======

            base.OnModelCreating(builder);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

>>>>>>> respaldo-remoto-origin-main
            builder.Entity<User>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("GETUTCDATE()");  // SQL Server

<<<<<<< HEAD
=======

>>>>>>> respaldo-remoto-origin-main
            builder.Entity<User>()
            .Property(u => u.UpdatedAt)
            .HasDefaultValueSql("GETUTCDATE()");  // SQL Server

<<<<<<< HEAD
            builder.Entity<TicketStatus>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("GETUTCDATE()");

            builder.Entity<TicketStatus>()
            .Property(u => u.UpdatedAt)
            .HasDefaultValueSql("GETUTCDATE()");

            builder.Entity<TicketStatus>()
                .HasIndex(ts => ts.Name)
                .IsUnique();

            builder.Entity<TicketPriority>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("GETUTCDATE()");

            builder.Entity<TicketPriority>()
            .Property(u => u.UpdatedAt)
            .HasDefaultValueSql("GETUTCDATE()");

            builder.Entity<TicketPriority>()
                .HasIndex(tp => tp.Name)
                .IsUnique();
        }
    }

}

=======
        }
}

 }

>>>>>>> respaldo-remoto-origin-main
