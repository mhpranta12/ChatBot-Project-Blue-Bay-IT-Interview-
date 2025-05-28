using Chatbot.Domain.Core.Entities.Messages;
using Chatbot.Infrastructure.Membership;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.Infrastructure
{
    public class ApplicationDBContext:IdentityDbContext<ApplicationUser>
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;

        public ApplicationDBContext(string connectionString, string migrationAssembly)
        {
            _connectionString = connectionString;
            _migrationAssembly = migrationAssembly;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString,
                    m => m.MigrationsAssembly(_migrationAssembly));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ChatMessage>().ToTable("ChatMessages");
            builder.Entity<ChatMessage>().HasKey(x => x.Id);
        }
        public DbSet<ChatMessage> ChatMessages { get; set; }
    }
}
