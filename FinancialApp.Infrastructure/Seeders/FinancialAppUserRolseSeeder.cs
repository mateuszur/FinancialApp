using FinancialApp.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApp.Infrastructure.Seeders
{
    public class FinancialAppUserRolseSeeder
    {
        private readonly FinancialAppDbContext _dbContext;

        public FinancialAppUserRolseSeeder(FinancialAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SeedUserRoles()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Roles.Any())
                {
                    var roles = new List<IdentityRole>()
                    {
                        new IdentityRole()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name="Admin",
                            NormalizedName="ADMIN",
                            ConcurrencyStamp= Guid.NewGuid().ToString(),
                        },

                            new IdentityRole()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name="User",
                            NormalizedName="USER",
                            ConcurrencyStamp= Guid.NewGuid().ToString(),
                        },

                            new IdentityRole()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name="Owner",
                            NormalizedName="OWNER",
                            ConcurrencyStamp= Guid.NewGuid().ToString(),
                        },

                    };

                    foreach (var role in roles)
                    {
                        _dbContext.Roles.Add(role);
                    }

                    await _dbContext.SaveChangesAsync();
                }
            }
        }

    }
}
