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
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string EncodedName { get; private set; } = default!;
        public void EncodeName() => EncodedName = Name.ToLower().Replace(" ", "-");

        public bool? IsDefault { get; set; }
        public string? NamePL {  get; set; }= default!;
        public string? EncodedNamePL { get; private set; } = default!;
        public void EncodeNamePL()
        {
            if (NamePL != null) {
                EncodedNamePL = NamePL.ToLower().Replace(" ", "-");
            }
        }
    }
}
