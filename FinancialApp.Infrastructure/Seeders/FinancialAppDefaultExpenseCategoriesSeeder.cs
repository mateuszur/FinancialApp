using FinancialApp.Domain.Entities;
using FinancialApp.Infrastructure.Persistence;
using System.Text.Json;

namespace FinancialApp.Infrastructure.Seeders
{
    public class FinancialAppDefaultExpenseAndRevenueCategoriesSeeder
    {
        private readonly FinancialAppDbContext _dbContext;
        private readonly string _jsonFilePathExpense;
        private readonly string _jsonFilePathRevenue;

        public FinancialAppDefaultExpenseAndRevenueCategoriesSeeder(FinancialAppDbContext dbContext)
        {
            _dbContext = dbContext;
            _jsonFilePathExpense = Path.Combine(AppContext.BaseDirectory, "Data", "defaultExpenseCategories.json");
            _jsonFilePathRevenue = Path.Combine(AppContext.BaseDirectory, "Data", "defaultRevenueCategories.json");
        }

        public async Task SeedDefaultExpenseCategories()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.FinancialAppExpenseAndRevenueCategories.Any())
                {
                    var jsonExpense = await File.ReadAllTextAsync(_jsonFilePathExpense);
                    var jsonRevenue = await File.ReadAllTextAsync(_jsonFilePathRevenue);
                    var categoriesExpense = JsonSerializer.Deserialize<List<FinancialAppExpenseAndRevenueCategories>>(jsonExpense);


                    var categoriesRevenue = JsonSerializer.Deserialize<List<FinancialAppExpenseAndRevenueCategories>>(jsonRevenue);
                    if (categoriesExpense != null)
                    {
                        foreach (var category in categoriesExpense)
                        {
                            category.EncodeName();
                            category.EncodeNamePL();
                            _dbContext.FinancialAppExpenseAndRevenueCategories.Add(category);
                        }
                        
                    }
                    if(categoriesRevenue != null)
                    {
                        foreach (var category in categoriesRevenue)
                        {
                            category.EncodeName();
                            category.EncodeNamePL();
                            _dbContext.FinancialAppExpenseAndRevenueCategories.Add(category);
                        }
                    }
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
