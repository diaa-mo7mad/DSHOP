using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSHOP.DAL.Models
{
    public class CategoryTranslation
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Language { get; set; }= "en";
        public int categoryId { get; set; }
        [ForeignKey("categoryId")]
        public Category Category { get; set; }
    }
}
