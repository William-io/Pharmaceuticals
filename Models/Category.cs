using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmaceuticals.Models
{
    [Table("[Category]")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

    }

}