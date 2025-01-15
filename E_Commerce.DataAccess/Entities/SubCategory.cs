using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class SubCategory
    {
        public int subcategoryId { get; set; }
        public int subcategoryName { get; set; }
        public int subcategoryCategoryId { get; set; }
    }
}
