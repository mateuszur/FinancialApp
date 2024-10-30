using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApp.Domain.Entities
{
    public class FinancialAppExpenseAndRevenue
    {
        public int Id { get; set; }
        public required  IdentityUser CreatedById { get; set; }
        public required FinancialAppExpenseAndRevenueCategories CategoriesId { get; set; }

        public string? Title { get; set; }
        public string EncodedTitle { get; private set; } = default!;

        public void EncodeTitle()
        {
            if (Title != null)
            {
                EncodedTitle = Title.ToLower().Replace(" ", "-");
            }
        }

        public string? Description { get; set; }

        public DateTime CreatedAd { get; set; } = DateTime.UtcNow;

        public required string Amount { get; set; }
    }
}
