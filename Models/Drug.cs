using Dapper.Contrib.Extensions;

namespace Pharmaceuticals.Models
{
    [Table("[Drug]")]
    public class Drug
    {
        public int Id { get; set; }
        public int EANId { get; set; }
        public string ActivePrinciple { get; set; }
        public string Product { get; set; }
        public string TherapeuticClasses { get; set; }
        public string Slug { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public int LaboratoryId { get; set; }



    }

}