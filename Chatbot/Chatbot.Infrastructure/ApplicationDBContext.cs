using Chatbot.Domain.Core.Entities.Messages;
using Chatbot.Infrastructure.Membership;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public ChatMessage ChatMessages { get; set; }
        public ApplicationUser Users { get; set; }
    }
}
