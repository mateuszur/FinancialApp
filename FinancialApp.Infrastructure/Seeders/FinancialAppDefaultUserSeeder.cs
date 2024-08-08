using FinancialApp.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApp.Infrastructure.Seeders
{
    public class FinancialAppDefaultUserSeeder
    {
        private readonly FinancialAppDbContext _dbContext;


        public FinancialAppDefaultUserSeeder(FinancialAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SeedUserRoles()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (_dbContext.Users.Count() == 1 && !_dbContext.UserRoles.Any())
                {
                    var user = _dbContext.Users.FirstOrDefault();
                    var adminRoleId = _dbContext.Roles.FirstOrDefault(c => c.Name == "Admin");
                    var userRoleId = _dbContext.Roles.FirstOrDefault(c => c.Name == "User");


                    if (adminRoleId != null && userRoleId != null)
                    {
                        var userRole = new List<IdentityUserRole<string>>
                        {
                            new IdentityUserRole<string>
                            {

                            RoleId = adminRoleId.Id,
                            UserId = user.Id,

                            },

                            new IdentityUserRole<string>
                            {

                            RoleId = userRoleId.Id,
                            UserId = user.Id,

                            },

                        };

                        foreach (var role in userRole)
                        {

                            _dbContext.UserRoles.Add(role);
                        }
                        await _dbContext.SaveChangesAsync();
                    }

                }
            }
        }
    }
}
