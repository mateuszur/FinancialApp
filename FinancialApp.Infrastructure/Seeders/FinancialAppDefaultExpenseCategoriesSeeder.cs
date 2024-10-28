using FinancialApp.Domain.Entities;
using FinancialApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinancialApp.Infrastructure.Seeders
{
    public class FinancialAppDefaultExpenseCategoriesSeeder
    {
        private readonly FinancialAppDbContext _dbContext;

        public FinancialAppDefaultExpenseCategoriesSeeder(FinancialAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SeedDefaultExpenseCategories()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.FinancialAppExpenseCategories.Any())
                {
                    var json = await File.ReadAllTextAsync("..\\FinancialApp.Infrastructure\\Data\\defaultExpenseCategories.json");
                    var categories = JsonSerializer.Deserialize<List<FinancialAppExpenseCategories>>(json);

                    //if (categories != null)
                    //{
                    //    _dbContext.FinancialAppExpenseCategories.AddRange(categories);
                    //    await _dbContext.SaveChangesAsync();
                    //}
                    if (categories != null)
                    {
                        foreach (var category in categories)
                        {
                            category.EncodeName();
                            category.EncodeNamePL();
                            _dbContext.FinancialAppExpenseCategories.Add(category);
                        }
                        await _dbContext.SaveChangesAsync();
                    }
                }
            }
        }
    }
}
