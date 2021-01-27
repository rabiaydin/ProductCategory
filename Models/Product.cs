using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int CategoryId{ get; set; }

        [NotMapped]
        public string CategoryName { get; set; }
        public Category Category { get; set; }
    }
}
