using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Model
{
    public class Category
    {
        public long Id { get; set; }
        public int  IsLeaf {get; set; }
        public string CategoryName { get; set; }
        public long ParentId { get; set; }
    }
}
