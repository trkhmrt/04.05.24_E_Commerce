using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class SubCategory
    {
        public int subCategoryId { get; set; }
        public string subCategoryName { get; set; }
        public int subcategoryCategoryId { get; set; }
    }
}
