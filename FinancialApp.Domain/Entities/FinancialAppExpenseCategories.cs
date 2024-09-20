using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinancialApp.Domain.Entities
{
    public class FinancialAppExpenseCategories
    {
        public required int Id { get; set; }
        public string Name { get; set; } = default!;
        public string EncodedName { get; private set; } = default!;
        public void EncodeName() => EncodedName = Name.ToLower().Replace(" ", "-");
    }
}
